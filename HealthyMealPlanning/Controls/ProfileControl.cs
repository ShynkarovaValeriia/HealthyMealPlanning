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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "View own recipes")
            {
                LoadUserRecipes();
            }
        }
    }
}
