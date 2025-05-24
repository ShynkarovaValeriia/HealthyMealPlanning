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


        // Сторінка Створення нового рецепту
        private string selectedImagePath = null;

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
                MessageBox.Show("Зображення вибрано: " + Path.GetFileName(selectedImagePath));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtIngredients.Text) ||
                string.IsNullOrWhiteSpace(txtCookingTime.Text) ||
                cbDifficulty.SelectedItem == null ||
                cbCategory.SelectedItem == null ||
                selectedImagePath == null)
            {
                MessageBox.Show("Будь ласка, заповніть усі поля і виберіть зображення.");
                return;
            }

            string recipeName = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            string ingredients = txtIngredients.Text.Trim();
            int cookingTime = int.Parse(txtCookingTime.Text.Trim());
            int portionsNumber = (int)numUpDownPortionsNumber.Value;
            string difficulty = cbDifficulty.SelectedItem.ToString();
            string category = cbCategory.SelectedItem.ToString();

            // Зберегти зображення у папку Resources
            string resourcesFolder = Path.Combine(Application.StartupPath, "Resources");
            Directory.CreateDirectory(resourcesFolder);
            string imageFileName = Guid.NewGuid().ToString() + Path.GetExtension(selectedImagePath); // унікальна назва
            string destImagePath = Path.Combine(resourcesFolder, imageFileName);
            File.Copy(selectedImagePath, destImagePath, true);

            // Шлях для збереження у БД
            string dbImagePath = "Resources/" + imageFileName;

            try
            {
                using (MySqlConnection conn = DBUtils.GetDBConnection())
                {
                    conn.Open();

                    string sql = @"insert into recipes 
                        (user_id, name, description, ingredients, cooking_time, portions_number, image_path, difficulty, category) 
                        values 
                        (@UserId, @Name, @Description, @Ingredients, @CookingTime, @Portions, @ImagePath, @Difficulty, @Category)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        int userId = Session.UserId;

                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@Name", recipeName);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@Ingredients", ingredients);
                        cmd.Parameters.AddWithValue("@CookingTime", cookingTime);
                        cmd.Parameters.AddWithValue("@Portions", portionsNumber);
                        cmd.Parameters.AddWithValue("@ImagePath", dbImagePath);
                        cmd.Parameters.AddWithValue("@Difficulty", difficulty);
                        cmd.Parameters.AddWithValue("@Category", category);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Рецепт успішно збережено!");
                        ClearRecipeForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні рецепта: " + ex.Message);
            }
        }

        private void ClearRecipeForm()
        {
            txtName.Clear();
            txtDescription.Clear();
            txtIngredients.Clear();
            txtCookingTime.Clear();
            numUpDownPortionsNumber.Value = 1;
            cbDifficulty.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;
            selectedImagePath = null;
        }

        // Завантаження даних користувача
        // Сторінка Перегляду рецептів користувача
        private void LoadUserRecipes()
        {
            flowLayoutPanelRecipes.Controls.Clear();

            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();

                string query = "select name, image_path from recipes where user_id = @UserId order by created_at desc";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", Session.UserId);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string recipeName = reader.GetString("name");
                    string imagePath = reader.GetString("image_path");

                    // Створення панелі для рецепта
                    Panel panel = new Panel();
                    panel.Width = 150;
                    panel.Height = 200;
                    panel.Margin = new Padding(10);

                    // Картинка
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 140;
                    pictureBox.Height = 140;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    try
                    {
                        string fullPath = Path.Combine(Application.StartupPath, imagePath);
                        if (File.Exists(fullPath))
                            pictureBox.Image = Image.FromFile(fullPath);
                        else
                            pictureBox.Image = Properties.Resources.placeholder; // Якщо зображення не знайдено
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
            if (tabControl1.SelectedTab.Text == "View own recipes")
            {
                LoadUserRecipes();
            }

            if (tabControl1.SelectedTab.Text == "Manage profile")
            {
                LoadUserProfile();
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
                MessageBox.Show("Будь ласка, введіть хоча б одне поле для зміни.");
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
                MessageBox.Show("Помилка БД: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
