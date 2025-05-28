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
    public partial class frmCreateRecipe : Form
    {
        private string selectedImagePath = null;

        public frmCreateRecipe()
        {
            InitializeComponent();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            frmHome homeForm = new frmHome();
            homeForm.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Кнопка Додавання зображення
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

        // Кнопка Збереження нового рецепту
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
            string imageFileName = Guid.NewGuid().ToString() + Path.GetExtension(selectedImagePath);
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
                        long insertedId = cmd.LastInsertedId;

                        MessageBox.Show("Рецепт успішно збережено!");
                        ClearForm();

                        // Відкрити форму рецепта
                        frmRecipe recipeForm = new frmRecipe((int)insertedId);
                        recipeForm.Show();
                        this.Close(); // Закрити форму створення
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні рецепта: " + ex.Message);
            }
        }

        private void ClearForm()
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
    }
}
