using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyMealPlanning
{
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
            SetUsernameLabel();
        }

        private void SetUsernameLabel()
        {
            if (!string.IsNullOrEmpty(Session.Username))
            {
                lblUsername.Text = Session.Username;
            }
            else
            {
                lblUsername.Text = "Користувач не авторизований";
            }
        }

        // Кнопка Вийти з акаунту
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Очистити Session
            Session.Clear();

            // Закрити поточне вікно
            Form currentForm = this.FindForm();
            currentForm.Hide();

            // Відкрити головну форму
            frmMain mainForm = new frmMain();
            mainForm.Show();
        }

        // Сторінка Перегляду рецептів користувача
        private void LoadUserRecipes()
        {
            flowLayoutPanelRecipes.Controls.Clear();

            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();

                string query = "select id, name, image_path from recipes where user_id = @UserId order by created_at desc";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", Session.UserId);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int recipeId = reader.GetInt32("id");
                    string recipeName = reader.GetString("name");
                    string imagePath = reader.GetString("image_path");

                    // Створення панелі
                    Panel panel = new Panel();
                    panel.Width = 150;
                    panel.Height = 200;
                    panel.Margin = new Padding(10);
                    panel.Tag = recipeId;
                    panel.Cursor = Cursors.Hand;

                    // Обробник кліку
                    panel.Click += PanelRecipe_Click;

                    // Картинка
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 140;
                    pictureBox.Height = 140;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Tag = recipeId;
                    pictureBox.Cursor = Cursors.Hand;
                    pictureBox.Click += PanelRecipe_Click; // також обробник

                    try
                    {
                        string fullPath = Path.Combine(Application.StartupPath, imagePath);
                        if (File.Exists(fullPath))
                            pictureBox.Image = Image.FromFile(fullPath);
                        else
                            pictureBox.Image = Properties.Resources.placeholder;
                    }
                    catch
                    {
                        pictureBox.Image = Properties.Resources.placeholder;
                    }

                    // Назва рецепта
                    Label label = new Label();
                    label.Text = recipeName;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Dock = DockStyle.Bottom;
                    label.Height = 40;
                    label.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    label.MaximumSize = new Size(140, 40);
                    label.AutoEllipsis = true;
                    label.Tag = recipeId;
                    label.Click += PanelRecipe_Click;
                    label.Cursor = Cursors.Hand;

                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(label);

                    flowLayoutPanelRecipes.Controls.Add(panel);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні рецептів: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadUserProfile()
        {
            int userId = Session.UserId;
            if (userId == 0)
            {
                MessageBox.Show("Сесія недійсна. Увійдіть знову.");
                return;
            }

            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();

                string sql = "select username, full_name, email from users where id = @UserId";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserId", userId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtChangeUsername.Text = reader["username"].ToString();
                        txtChangeFullname.Text = reader["full_name"].ToString();
                        txtChangeEmail.Text = reader["email"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Користувача не знайдено.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при завантаженні профілю: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Activity")
            {
                LoadFavoriteRecipes();
                LoadSavedRecipes();
                LoadUserReviews();
            }

            if (tabControl1.SelectedTab.Text == "View own recipes")
            {
                LoadUserRecipes();
            }

            if (tabControl1.SelectedTab.Text == "Manage profile")
            {
                LoadUserProfile();
            }
        }

        private void PanelRecipe_Click(object sender, EventArgs e)
        {
            int recipeId = 0;

            if (sender is Control control && control.Tag is int id)
            {
                recipeId = id;
            }

            if (recipeId > 0)
            {
                frmRecipe recipeForm = new frmRecipe(recipeId);
                recipeForm.ShowDialog();
            }
        }

        // Сторінка Змінити налаштування профілю
        private void btnChangeSave_Click(object sender, EventArgs e)
        {
            int userId = Session.UserId;
            if (userId == 0)
            {
                MessageBox.Show("Сесія недійсна. Увійдіть знову.");
                return;
            }

            string newUsername = txtChangeUsername.Text.Trim();
            string newFullName = txtChangeFullname.Text.Trim();
            string newEmail = txtChangeEmail.Text.Trim();
            string newPassword = txtChangePassword.Text.Trim();

            List<string> updates = new List<string>();
            MySqlCommand cmd = new MySqlCommand();

            if (!string.IsNullOrEmpty(newUsername))
            {
                updates.Add("username = @Username");
                cmd.Parameters.AddWithValue("@Username", newUsername);
            }

            if (!string.IsNullOrEmpty(newFullName))
            {
                updates.Add("full_name = @FullName");
                cmd.Parameters.AddWithValue("@FullName", newFullName);
            }

            if (!string.IsNullOrEmpty(newEmail))
            {
                updates.Add("email = @Email");
                cmd.Parameters.AddWithValue("@Email", newEmail);
            }

            if (!string.IsNullOrEmpty(newPassword))
            {
                updates.Add("password = @Password");
                cmd.Parameters.AddWithValue("@Password", newPassword);
            }

            if (updates.Count == 0)
            {
                MessageBox.Show("Введіть хоча б одне поле для зміни.");
                return;
            }

            string updateQuery = $"update users set {string.Join(", ", updates)} where id = @UserId";
            cmd.Parameters.AddWithValue("@UserId", userId);
            cmd.CommandText = updateQuery;

            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd.Connection = conn;

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Дані успішно оновлено!");

                    // Оновлюємо сесію, якщо потрібно
                    if (!string.IsNullOrEmpty(newUsername)) Session.Username = newUsername;
                    if (!string.IsNullOrEmpty(newFullName)) Session.FullName = newFullName;
                }
                else
                {
                    MessageBox.Show("Оновлення не вдалося. Спробуйте ще раз.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Завантаження відгуків користувача
        private void LoadUserReviews()
        {
            pnlReview.Controls.Clear();

            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();

                string query = @"select rt.id as review_id, rt.recipe_id, r.name as recipe_name,
                                rt.created_at, rt.rating, rt.comment
                         from ratings rt
                         join recipes r on rt.recipe_id = r.id
                         where rt.user_id = @UserId
                         order by rt.created_at desc";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", Session.UserId);

                MySqlDataReader reader = cmd.ExecuteReader();

                int yOffset = 0;

                while (reader.Read())
                {
                    int reviewId = Convert.ToInt32(reader["review_id"]);
                    int recipeId = Convert.ToInt32(reader["recipe_id"]);
                    string recipeName = reader["recipe_name"].ToString();
                    DateTime date = Convert.ToDateTime(reader["created_at"]);
                    int rating = Convert.ToInt32(reader["rating"]);
                    string comment = reader["comment"].ToString();

                    // Панель для відгуку
                    Panel reviewPanel = new Panel();
                    reviewPanel.Width = pnlReview.Width - 20;
                    reviewPanel.Height = 110;
                    reviewPanel.Location = new Point(10, yOffset);
                    reviewPanel.BorderStyle = BorderStyle.FixedSingle;
                    reviewPanel.Cursor = Cursors.Hand;
                    reviewPanel.Tag = recipeId; // для переходу до рецепту

                    // Подія кліку по панелі → відкриття frmRecipe
                    reviewPanel.Click += (s, e) =>
                    {
                        frmRecipe recipeForm = new frmRecipe(recipeId);
                        recipeForm.Show();
                    };

                    // Назва рецепта
                    Label lblRecipe = new Label();
                    lblRecipe.Text = "Recipe: " + recipeName;
                    lblRecipe.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    lblRecipe.Location = new Point(10, 5);
                    lblRecipe.AutoSize = true;

                    // Дата
                    Label lblDate = new Label();
                    lblDate.Text = date.ToString("yyyy-MM-dd");
                    lblDate.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                    lblDate.Location = new Point(10, 30);
                    lblDate.AutoSize = true;

                    // Зірки
                    Panel starPanel = new Panel();
                    starPanel.Location = new Point(10, 50);
                    starPanel.Size = new Size(150, 24);

                    for (int i = 0; i < 5; i++)
                    {
                        PictureBox pb = new PictureBox();
                        pb.Size = new Size(24, 24);
                        pb.Location = new Point(i * 26, 0);
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Image = (i < rating)
                            ? Properties.Resources.star_filled
                            : Properties.Resources.star_empty;
                        starPanel.Controls.Add(pb);
                    }

                    // Коментар
                    Label lblComment = new Label();
                    lblComment.Text = comment;
                    lblComment.Location = new Point(180, 30);
                    lblComment.Size = new Size(reviewPanel.Width - 280, 60);
                    lblComment.Font = new Font("Segoe UI", 9);
                    lblComment.AutoEllipsis = true;

                    // Кнопка Edit
                    PictureBox btnEdit = new PictureBox();
                    btnEdit.Size = new Size(24, 24);
                    btnEdit.Location = new Point(reviewPanel.Width - 70, 10);
                    btnEdit.Image = Properties.Resources.edit; // твоя картинка edit
                    btnEdit.SizeMode = PictureBoxSizeMode.Zoom;
                    btnEdit.Cursor = Cursors.Hand;
                    btnEdit.Click += (s, e) =>
                    {
                        frmReview editForm = new frmReview(recipeId, true, reviewId);
                        editForm.ShowDialog();
                        LoadUserReviews(); // оновлення після редагування
                    };

                    // Кнопка Delete
                    PictureBox btnDelete = new PictureBox();
                    btnDelete.Size = new Size(24, 24);
                    btnDelete.Location = new Point(reviewPanel.Width - 40, 10);
                    btnDelete.Image = Properties.Resources.delete; // твоя картинка delete
                    btnDelete.SizeMode = PictureBoxSizeMode.Zoom;
                    btnDelete.Cursor = Cursors.Hand;
                    btnDelete.Click += (s, e) =>
                    {
                        var result = MessageBox.Show("Ви впевнені, що хочете видалити цей відгук?",
                                                     "Підтвердження", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            DeleteReview(reviewId);
                            LoadUserReviews(); // оновлення після видалення
                        }
                    };

                    // Додаємо все на панель
                    reviewPanel.Controls.Add(lblRecipe);
                    reviewPanel.Controls.Add(lblDate);
                    reviewPanel.Controls.Add(starPanel);
                    reviewPanel.Controls.Add(lblComment);
                    reviewPanel.Controls.Add(btnEdit);
                    reviewPanel.Controls.Add(btnDelete);

                    // Додаємо панель на pnlReview
                    pnlReview.Controls.Add(reviewPanel);

                    yOffset += reviewPanel.Height + 10;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні відгуків: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Метод для видалення відгуку
        private void DeleteReview(int reviewId)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();

                string query = "delete from ratings where id = @ReviewId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ReviewId", reviewId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при видаленні відгуку: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Методи для завантаження обраних і збережених рецептів
        private void LoadFavoriteRecipes()
        {
            pnlFavoriteRecipes.Controls.Clear();

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                        select r.id, r.name, r.image_path
                        from favorites f
                        join recipes r on f.recipe_id = r.id
                        where f.user_id = @UserId
                        order by f.created_at desc";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", Session.UserId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int recipeId = reader.GetInt32("id");
                            string name = reader.GetString("name");
                            string imagePath = reader.GetString("image_path");

                            Panel panel = CreateRecipePanel(name, imagePath, recipeId);
                            pnlFavoriteRecipes.Controls.Add(panel);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні обраних рецептів: " + ex.Message);
                }
            }
        }

        private void LoadSavedRecipes()
        {
            pnlSavedRecipes.Controls.Clear();

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                        select r.id, r.name, r.image_path
                        from saved_recipes s
                        join recipes r on s.recipe_id = r.id
                        where s.user_id = @UserId
                        order by s.created_at desc";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", Session.UserId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int recipeId = reader.GetInt32("id");
                            string name = reader.GetString("name");
                            string imagePath = reader.GetString("image_path");

                            Panel panel = CreateRecipePanel(name, imagePath, recipeId);
                            pnlSavedRecipes.Controls.Add(panel);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні збережених рецептів: " + ex.Message);
                }
            }
        }

        // Метод створення панелі рецепта
        private Panel CreateRecipePanel(string name, string imagePath, int recipeId)
        {
            Panel panel = new Panel();
            panel.Width = 150;
            panel.Height = 200;
            panel.Margin = new Padding(10);
            panel.Cursor = Cursors.Hand;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Width = 140;
            pictureBox.Height = 140;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            try
            {
                string fullPath = Path.Combine(Application.StartupPath, imagePath);
                pictureBox.Image = File.Exists(fullPath)
                    ? Image.FromFile(fullPath)
                    : Properties.Resources.placeholder;
            }
            catch
            {
                pictureBox.Image = Properties.Resources.placeholder;
            }

            Label label = new Label();
            label.Text = name;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Bottom;
            label.Height = 40;
            label.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            label.MaximumSize = new Size(140, 40);
            label.AutoEllipsis = true;

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(label);

            // Відкриття рецепта по кліку
            panel.Click += (s, e) => OpenRecipe(recipeId);
            pictureBox.Click += (s, e) => OpenRecipe(recipeId);
            label.Click += (s, e) => OpenRecipe(recipeId);

            return panel;
        }

        private void OpenRecipe(int recipeId)
        {
            frmRecipe recipeForm = new frmRecipe(recipeId);
            recipeForm.Show();
        }

        // Кнопка Створення нового рецепту
        private void btnAddOwnRecipe_Click(object sender, EventArgs e)
        {
            frmCreateRecipe createForm = new frmCreateRecipe();
            createForm.Show();
        }
    }
}
