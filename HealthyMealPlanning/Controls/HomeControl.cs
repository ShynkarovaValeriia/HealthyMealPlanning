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
                    string query = @"SELECT DISTINCT u.id, u.full_name
                             FROM users u
                             JOIN recipes r ON u.id = r.user_id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userId = reader.GetInt32("id");
                            string fullName = reader.GetString("full_name");

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
                                Width = 80,
                                Height = 80,
                                Top = 0,
                                Left = 10,
                                Cursor = Cursors.Hand
                            };

                            Label label = new Label
                            {
                                Text = fullName,
                                AutoSize = false,
                                TextAlign = ContentAlignment.MiddleCenter,
                                Dock = DockStyle.Bottom,
                                Height = 40
                            };

                            picture.Click += (s, e) =>
                            {
                                MessageBox.Show("Успішне відкриття!");
                                // Тут можна буде викликати форму з профілем користувача
                            };

                            panel.Controls.Add(picture);
                            panel.Controls.Add(label);
                            pnlPopularCreators.Controls.Add(panel);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні авторів: " + ex.Message);
                }
            }
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
                                Width = 150,
                                Height = 180,
                                Margin = new Padding(10),
                                BorderStyle = BorderStyle.FixedSingle
                            };

                            PictureBox recipeImage = new PictureBox
                            {
                                SizeMode = PictureBoxSizeMode.Zoom,
                                Width = 130,
                                Height = 100,
                                Top = 10,
                                Left = 10
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
                                Top = 115,
                                Left = 10,
                                Width = 130,
                                Height = 30,
                                TextAlign = ContentAlignment.TopCenter
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
                    MessageBox.Show("Помилка при завантаженні рецептів: " + ex.Message);
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

                    MessageBox.Show("Рецепт додано в обране!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при додаванні в обране: " + ex.Message);
                }
            }
        }

    }
}
