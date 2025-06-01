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
    public partial class HomeControl : UserControl
    {
        public Panel MainPanel { get; set; }

        public HomeControl()
        {
            InitializeComponent();
            LoadPopularCreators();
            LoadDiscoverRecipes();
        }

        // Відображення популярних творців
        private void LoadPopularCreators()
        {
            pnlPopularCreators.Controls.Clear();

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT DISTINCT u.id, u.username
                             FROM users u
                             JOIN recipes r ON u.id = r.user_id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userId = reader.GetInt32("id");
                            string fullName = reader.GetString("username");

                            Panel panel = new Panel
                            {
                                Width = 100,
                                Height = 120,
                                Margin = new Padding(10)
                            };

                            PictureBox picture = new PictureBox
                            {
                                Image = Properties.Resources.account_circle,
                                SizeMode = PictureBoxSizeMode.Zoom,
                                Width = 60,
                                Height = 60,
                                Top = 5,
                                Left = 20,
                                Cursor = Cursors.Hand
                            };

                            Label label = new Label
                            {
                                Text = fullName,
                                Font = new Font("Calibri", 16, FontStyle.Regular),
                                AutoSize = false,
                                TextAlign = ContentAlignment.MiddleCenter,
                                Dock = DockStyle.Bottom,
                                Height = 50
                            };

                            picture.Click += (s, e) =>
                            {
                                ShowExploreWithUserRecipes(userId);
                            };

                            panel.Controls.Add(picture);
                            panel.Controls.Add(label);
                            pnlPopularCreators.Controls.Add(panel);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні авторів: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowExploreWithUserRecipes(int userId)
        {
            ExploreControl explore = new ExploreControl();
            explore.Dock = DockStyle.Fill;
            explore.LoadUserRecipes(userId);

            MainPanel.Controls.Clear(); // використовуємо передану панель
            MainPanel.Controls.Add(explore);
        }

        // Відображення рецептів
        private void LoadDiscoverRecipes()
        {
            pnlDiscoverRecipes.Controls.Clear();

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT id, name, image_path FROM recipes ORDER BY created_at DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int recipeId = reader.GetInt32("id");
                            string name = reader.GetString("name");
                            string imagePath = reader.GetString("image_path");

                            Panel recipePanel = new Panel
                            {
                                Width = 200,
                                Height = 180,
                                Margin = new Padding(10),
                                BackColor = Color.White
                            };

                            PictureBox recipeImage = new PictureBox
                            {
                                SizeMode = PictureBoxSizeMode.Zoom,
                                Width = 160,
                                Height = 140,
                                Dock = DockStyle.Top,
                                Cursor = Cursors.Hand
                            };

                            try
                            {
                                string fullPath = Path.Combine(Application.StartupPath, imagePath);
                                if (File.Exists(fullPath))
                                    recipeImage.Image = Image.FromFile(fullPath);
                                else
                                    recipeImage.Image = Properties.Resources.placeholder;
                            }
                            catch
                            {
                                recipeImage.Image = Properties.Resources.placeholder;
                            }

                            Label lblName = new Label
                            {
                                Text = name,
                                Font = new Font("Calibri", 14, FontStyle.Regular),
                                AutoSize = false,
                                Height = 40,
                                TextAlign = ContentAlignment.MiddleCenter,
                                Dock = DockStyle.Bottom,
                                Cursor = Cursors.Hand
                            };

                            recipeImage.Click += (s, e) =>
                            {
                                frmRecipe recipeForm = new frmRecipe(recipeId);
                                recipeForm.ShowDialog();
                            };

                            lblName.Click += (s, e) =>
                            {
                                frmRecipe recipeForm = new frmRecipe(recipeId);
                                recipeForm.ShowDialog();
                            };

                            Button btnFavorite = new Button
                            {
                                Image = Properties.Resources.favorite_empty,
                                Width = 24,
                                Height = 24,
                                FlatStyle = FlatStyle.Flat,
                                Top = 10,
                                Left = 110,
                                BackColor = Color.Transparent,
                                Cursor = Cursors.Hand,
                                Tag = recipeId
                            };

                            btnFavorite.FlatAppearance.BorderSize = 0;

                            btnFavorite.Click += (s, e) =>
                            {
                                AddToFavorites(Session.UserId, recipeId);
                            };

                            recipePanel.Controls.Add(recipeImage);
                            recipePanel.Controls.Add(lblName);
                            recipePanel.Controls.Add(btnFavorite);
                            pnlDiscoverRecipes.Controls.Add(recipePanel);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні рецептів: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Метод додавання в обране
        private void AddToFavorites(int userId, int recipeId)
        {
            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                try
                {
                    conn.Open();
                    string insert = @"INSERT IGNORE INTO favorites (user_id, recipe_id, created_at) 
                              VALUES (@UserId, @RecipeId, NOW())";

                    MySqlCommand cmd = new MySqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@RecipeId", recipeId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Рецепт додано в обране!", "Успіхішне збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при додаванні в обране: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Відображення рецептів за певною категорією
        private void ShowExploreByCategory(string category)
        {
            // Отримати головну форму
            Form parentForm = this.FindForm();
            if (parentForm is frmHome homeForm)
            {
                ExploreControl explore = new ExploreControl();
                explore.Dock = DockStyle.Fill;
                homeForm.MainPanel.Controls.Clear();
                homeForm.MainPanel.Controls.Add(explore);

                explore.LoadRecipesByCategory(category);
            }
        }

        private void pnlDesserts_Click(object sender, EventArgs e)
        {
            ShowExploreByCategory("Десерт");
        }

        private void pnlFruits_Click(object sender, EventArgs e)
        {
            ShowExploreByCategory("Фрукти");
        }

        private void pnlMaindish_Click(object sender, EventArgs e)
        {
            ShowExploreByCategory("Основна страва");
        }

        private void pnlSalads_Click(object sender, EventArgs e)
        {
            ShowExploreByCategory("Салати");
        }

        private void pnlSoups_Click(object sender, EventArgs e)
        {
            ShowExploreByCategory("Супи");
        }

        private void pnlVegetables_Click(object sender, EventArgs e)
        {
            ShowExploreByCategory("Овочі");
        }
    }
}
