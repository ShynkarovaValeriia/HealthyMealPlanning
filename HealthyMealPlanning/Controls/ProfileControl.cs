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

            // Приховати вкладку, якщо користувач не адміністратор
            if (Session.UserId != 1)
            {
                tabControl1.TabPages.Remove(tabAdminPanel);
            }

            if (Session.UserId == 1)
            {
                InitializeAdminPanel();
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

                    Panel panel = new Panel();
                    panel.Width = 200;
                    panel.Height = 180;
                    panel.Margin = new Padding(10);
                    panel.Tag = recipeId;
                    panel.Cursor = Cursors.Hand;

                    // Зображення рецепта
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 180;
                    pictureBox.Height = 140;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Tag = recipeId;
                    pictureBox.Click += PanelRecipe_Click;

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

                    // Нижня панель з назвою та кнопками
                    Panel bottomPanel = new Panel();
                    bottomPanel.Width = 150;
                    bottomPanel.Height = 60;
                    bottomPanel.Dock = DockStyle.Bottom;

                    // Назва рецепта
                    Label label = new Label();
                    label.Text = recipeName;
                    label.Font = new Font("Calibri", 14, FontStyle.Regular);
                    label.AutoSize = false;
                    label.Size = new Size(90, 60);
                    label.Location = new Point(0, 0);
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.AutoEllipsis = true;
                    label.Tag = recipeId;
                    label.Click += PanelRecipe_Click;

                    // Кнопка Змінити
                    PictureBox btnEdit = new PictureBox();
                    btnEdit.Image = Properties.Resources.edit;
                    btnEdit.Width = 24;
                    btnEdit.Height = 24;
                    btnEdit.SizeMode = PictureBoxSizeMode.Zoom;
                    btnEdit.Cursor = Cursors.Hand;
                    btnEdit.Tag = recipeId;
                    btnEdit.Click += BtnEdit_Click;

                    // Кнопка Видалити
                    PictureBox btnDelete = new PictureBox();
                    btnDelete.Image = Properties.Resources.delete;
                    btnDelete.Width = 24;
                    btnDelete.Height = 24;
                    btnDelete.SizeMode = PictureBoxSizeMode.Zoom;
                    btnDelete.Cursor = Cursors.Hand;
                    btnDelete.Tag = recipeId;
                    btnDelete.Click += BtnDelete_Click;

                    // Панель кнопок
                    FlowLayoutPanel actionPanel = new FlowLayoutPanel();
                    actionPanel.FlowDirection = FlowDirection.LeftToRight;
                    actionPanel.Size = new Size(60, 60);
                    actionPanel.Location = new Point(130, 15);
                    actionPanel.Controls.Add(btnEdit);
                    actionPanel.Controls.Add(btnDelete);

                    // Додаємо в нижню панель
                    bottomPanel.Controls.Add(label);
                    bottomPanel.Controls.Add(actionPanel);

                    // Додати все до головної панелі
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(bottomPanel);

                    // Додати до списку
                    flowLayoutPanelRecipes.Controls.Add(panel);

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні рецептів: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Кнопка Редагувати рецепт
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (sender is Control control && control.Tag is int recipeId)
            {
                frmCreateRecipe editForm = new frmCreateRecipe(recipeId); // Передати id рецепта
                editForm.ShowDialog();
                LoadUserRecipes(); // Перезавантажити після змін
            }
        }

        // Кнопка Видалити рецепт
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (sender is Control control && control.Tag is int recipeId)
            {
                DialogResult result = MessageBox.Show("Ви дійсно хочете видалити цей рецепт?",
                                                      "Підтвердження видалення",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = DBUtils.GetDBConnection())
                        {
                            conn.Open();
                            string deleteSql = "delete from recipes where id = @Id and user_id = @UserId";
                            MySqlCommand cmd = new MySqlCommand(deleteSql, conn);
                            cmd.Parameters.AddWithValue("@Id", recipeId);
                            cmd.Parameters.AddWithValue("@UserId", Session.UserId);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Рецепт успішно видалено!", "Успішне збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUserRecipes(); // Перезавантажити список
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка при видаленні: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void LoadUserProfile()
        {
            int userId = Session.UserId;
            if (userId == 0)
            {
                MessageBox.Show("Сесія недійсна. Увійдіть знову.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Користувача не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при завантаженні профілю: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Активність")
            {
                LoadFavoriteRecipes();
                LoadSavedRecipes();
                LoadUserReviews();
            }

            if (tabControl1.SelectedTab.Text == "Власні рецепти")
            {
                LoadUserRecipes();
            }

            if (tabControl1.SelectedTab.Text == "Налаштування профілю")
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
                MessageBox.Show("Сесія недійсна. Увійдіть знову.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Введіть хоча б одне поле для зміни.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Дані успішно оновлено!", "Успішне збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Оновлюємо сесію, якщо потрібно
                    if (!string.IsNullOrEmpty(newUsername)) Session.Username = newUsername;
                    if (!string.IsNullOrEmpty(newFullName)) Session.FullName = newFullName;
                }
                else
                {
                    MessageBox.Show("Оновлення не вдалося. Спробуйте ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Завантаження відгуків користувача
        public void LoadUserReviews()
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
                    lblRecipe.Text = "Рецепт: " + recipeName;
                    lblRecipe.Font = new Font("Calibri", 14, FontStyle.Regular);
                    lblRecipe.Location = new Point(10, 5);
                    lblRecipe.AutoSize = true;

                    // Дата
                    Label lblDate = new Label();
                    lblDate.Text = date.ToString("yyyy-MM-dd");
                    lblDate.Font = new Font("Calibri", 14, FontStyle.Regular);
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
                    lblComment.Location = new Point(10, 70);
                    lblComment.Size = new Size(reviewPanel.Width - 280, 60);
                    lblComment.Font = new Font("Calibri", 14, FontStyle.Regular);
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
                                                     "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                MessageBox.Show("Помилка при завантаженні відгуків: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Помилка при видаленні відгуку: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Методи для завантаження обраних і збережених рецептів
        public void LoadFavoriteRecipes()
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
                    MessageBox.Show("Помилка при завантаженні обраних рецептів: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LoadSavedRecipes()
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
                    MessageBox.Show("Помилка при завантаженні збережених рецептів: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Метод створення панелі рецепта
        private Panel CreateRecipePanel(string name, string imagePath, int recipeId)
        {
            Panel panel = new Panel();
            panel.Width = 200;
            panel.Height = 180;
            panel.Margin = new Padding(10);
            panel.Cursor = Cursors.Hand;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Width = 180;
            pictureBox.Height = 140;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Dock = DockStyle.Top;

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
            label.Font = new Font("Calibri", 14, FontStyle.Regular);

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


        // Лише для Адміністратора
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

        private void InitializeAdminPanel()
        {
            if (Session.UserId == 1) // Лише адміністратор
            {
                cmbTables.Items.AddRange(new string[]
                {
                    "users",
                    "recipes",
                    "saved_recipes",
                    "favorites",
                    "meal_plans",
                    "ratings"
                });

                cmbTables.SelectedIndex = 0;
            }
        }

        // Завантаження таблиці у DataGridView
        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            string selectedTable = cmbTables.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedTable))
            {
                MessageBox.Show("Оберіть таблицю для завантаження.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadTable(selectedTable);
        }

        private void LoadTable(string tableName)
        {
            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                try
                {
                    conn.Open();
                    string query = $"select * from {tableName}";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewAdmin.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewAdmin.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть рядок для видалення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string table = cmbTables.SelectedItem.ToString();
            DataGridViewRow selectedRow = dataGridViewAdmin.SelectedRows[0];

            // Визначаємо первинний ключ
            string pkField = GetPrimaryKeyField(table);
            if (string.IsNullOrEmpty(pkField))
            {
                MessageBox.Show("Неможливо визначити первинний ключ.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object pkValue = selectedRow.Cells[pkField].Value;

            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                try
                {
                    conn.Open();
                    string deleteSql = $"delete from {table} where {pkField} = @pk";
                    MySqlCommand cmd = new MySqlCommand(deleteSql, conn);
                    cmd.Parameters.AddWithValue("@pk", pkValue);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Запис видалено.", "Успішне видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTable(table); // Оновлення таблиці
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при видаленні: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetPrimaryKeyField(string table)
        {
            switch (table)
            {
                case "users":
                case "recipes":
                case "ratings":
                case "meal_plans":
                    return "id";

                case "favorites":
                case "saved_recipes":
                    return "user_id"; // тимчасово, бо це композитний ключ

                default:
                    return "";
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewAdmin.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть рядок для редагування.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string table = cmbTables.SelectedItem.ToString();
            DataGridViewRow row = dataGridViewAdmin.SelectedRows[0];
            string pkField = GetPrimaryKeyField(table);
            object pkValue = row.Cells[pkField].Value;

            List<string> setClauses = new List<string>();
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            foreach (DataGridViewCell cell in row.Cells)
            {
                string column = cell.OwningColumn.Name;
                object value = cell.Value;

                if (column == pkField) continue;

                setClauses.Add($"{column} = @{column}");
                parameters.Add(new MySqlParameter($"@{column}", value ?? DBNull.Value));
            }

            string setClause = string.Join(", ", setClauses);

            string updateSql = $"update {table} set {setClause} where {pkField} = @pk";

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(updateSql, conn);
                    cmd.Parameters.AddWithValue("@pk", pkValue);
                    cmd.Parameters.AddRange(parameters.ToArray());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Запис оновлено.", "Успішне збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTable(table);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при оновленні: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string selectedTable = cmbTables.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedTable))
            {
                MessageBox.Show("Оберіть таблицю для додавання.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (selectedTable)
            {
                case "recipes":
                    frmCreateRecipe createForm = new frmCreateRecipe();
                    createForm.FormClosed += (s, args) =>
                    {
                        LoadTable("recipes"); // Оновлюємо дані після створення
                    };
                    createForm.Show();
                    break;

                default:
                    MessageBox.Show("Додавання нових записів поки що підтримується лише для таблиці рецептів.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
