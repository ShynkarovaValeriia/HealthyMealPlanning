using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HealthyMealPlanning
{
    public partial class frmAddToMealPlan : Form
    {
        private int userId;
        private int recipeId;
        private string recipeName;
        private string imagePath;
        private DateTime selectedDate;

        public frmAddToMealPlan(int userId, int recipeId, string recipeName, string imagePath, DateTime date)
        {
            InitializeComponent();

            this.userId = userId;
            this.recipeId = recipeId;
            this.recipeName = recipeName;
            this.imagePath = imagePath;
            this.selectedDate = date;
        }

        private void frmAddToMealPlan_Load(object sender, EventArgs e)
        {
            lblRecipeName.Text = recipeName;

            try
            {
                string fullPath = Path.Combine(Application.StartupPath, imagePath);
                if (File.Exists(fullPath))
                    pictureBoxRecipe.Image = Image.FromFile(fullPath);
                else
                    pictureBoxRecipe.Image = Properties.Resources.placeholder;
            }
            catch
            {
                pictureBoxRecipe.Image = Properties.Resources.placeholder;
            }

            rbLunch.Checked = true; // Значення за замовчуванням
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string selectedMealType = "";

            if (rbBreakfast.Checked) selectedMealType = "Breakfast";
            else if (rbLunch.Checked) selectedMealType = "Lunch";
            else if (rbSnacks.Checked) selectedMealType = "Snacks";
            else if (rbDinner.Checked) selectedMealType = "Dinner";

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"insert into meal_plans (user_id, recipe_id, plan_date, meal_type, created_at)
                                     values (@userId, @recipeId, @planDate, @mealType, now())";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@recipeId", recipeId);
                    cmd.Parameters.AddWithValue("@planDate", selectedDate.Date);
                    cmd.Parameters.AddWithValue("@mealType", selectedMealType);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Рецепт додано до плану!");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при збереженні: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
