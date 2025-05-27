using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyMealPlanning
{
    public partial class ExploreControl : UserControl
    {
        public ExploreControl()
        {
            InitializeComponent();
            LoadRecipes();
        }

        // Метод завантаження рецептів
        private void LoadRecipes()
        {
            pnlDiscoverRecipes.Controls.Clear();

            try
            {
                using (MySqlConnection conn = DBUtils.GetDBConnection())
                {
                    conn.Open();

                    string sql = "select id, name, image_path from recipes order by created_at desc";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int recipeId = reader.GetInt32("id");
                            string recipeName = reader.GetString("name");
                            string imagePath = reader.GetString("image_path");

                            RecipeCard card = new RecipeCard();
                            card.SetRecipe(recipeName, imagePath);
                            card.Margin = new Padding(10);

                            // За бажанням — подія при натисканні
                            card.Click += (s, e) =>
                            {
                                frmRecipe recipeForm = new frmRecipe(recipeId);
                                recipeForm.Show();
                            };

                            pnlDiscoverRecipes.Controls.Add(card);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні рецептів: " + ex.Message);
            }
        }

    }
}
