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
    public partial class ExploreControl : UserControl
    {
        public ExploreControl()
        {
            InitializeComponent();
        }

        private void ExploreControl_Load(object sender, EventArgs e)
        {
            LoadAllRecipes();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSearch.PerformClick();
            }
        }

        private void SearchExplore(string keyword)
        {
            pnlExplore.Controls.Clear();

            int totalResults = 0;

            // --- Пошук користувачів ---
            using (MySqlConnection conn1 = DBUtils.GetDBConnection())
            {
                try
                {
                    conn1.Open();

                    string queryUsers = @"
                        select u.id, u.username
                        from users u
                        where (u.username like @keyword or u.full_name like @keyword)
                        and exists (select 1 from recipes r where r.user_id = u.id)";

                    MySqlCommand cmdUsers = new MySqlCommand(queryUsers, conn1);
                    cmdUsers.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    using (var reader = cmdUsers.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userId = reader.GetInt32("id");
                            string username = reader.GetString("username");

                            Panel panel = CreateSearchItem(username, Properties.Resources.account_circle, () =>
                            {
                                LoadUserRecipes(userId);
                            });

                            pnlExplore.Controls.Add(panel);
                            totalResults++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при пошуку користувачів: " + ex.Message);
                }
            }

            // --- Пошук рецептів ---
            using (MySqlConnection conn2 = DBUtils.GetDBConnection())
            {
                try
                {
                    conn2.Open();

                    string queryRecipes = @"
                        select id, name, image_path
                        from recipes
                        where name like @keyword
                           or category like @keyword
                           or ingredients like @keyword";

                    MySqlCommand cmdRecipes = new MySqlCommand(queryRecipes, conn2);
                    cmdRecipes.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    using (var reader = cmdRecipes.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int recipeId = reader.GetInt32("id");
                            string name = reader.GetString("name");
                            string imagePath = reader.GetString("image_path");

                            Image recipeImage;
                            try
                            {
                                string fullPath = Path.Combine(Application.StartupPath, imagePath);
                                recipeImage = File.Exists(fullPath) ? Image.FromFile(fullPath) : Properties.Resources.placeholder;
                            }
                            catch
                            {
                                recipeImage = Properties.Resources.placeholder;
                            }

                            Panel panel = CreateSearchItem(name, recipeImage, () =>
                            {
                                frmRecipe recipeForm = new frmRecipe(recipeId);
                                recipeForm.ShowDialog();
                            });

                            pnlExplore.Controls.Add(panel);
                            totalResults++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при пошуку рецептів: " + ex.Message);
                }
            }

            if (totalResults == 0)
            {
                MessageBox.Show("Нічого не знайдено.");
            }
        }

        private Panel CreateSearchItem(string title, Image image, Action onClick)
        {
            Panel panel = new Panel
            {
                Width = 200,
                Height = 180,
                Margin = new Padding(10),
                Cursor = Cursors.Hand
            };

            PictureBox picture = new PictureBox
            {
                Width = 180,
                Height = 140,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = image,
                Dock = DockStyle.Top
            };

            Label label = new Label
            {
                Text = title,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Bottom,
                Height = 40
            };

            panel.Controls.Add(picture);
            panel.Controls.Add(label);

            panel.Click += (s, e) => onClick?.Invoke();
            picture.Click += (s, e) => onClick?.Invoke();
            label.Click += (s, e) => onClick?.Invoke();

            return panel;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchExplore(txtSearch.Text.Trim());
        }

        private void LoadAllRecipes()
        {
            pnlExplore.Controls.Clear();

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                try
                {
                    conn.Open();

                    string query = "select id, name, image_path from recipes";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int recipeId = reader.GetInt32("id");
                            string name = reader.GetString("name");
                            string imagePath = reader.GetString("image_path");

                            Image recipeImage;
                            try
                            {
                                string fullPath = Path.Combine(Application.StartupPath, imagePath);
                                recipeImage = File.Exists(fullPath) ? Image.FromFile(fullPath) : Properties.Resources.placeholder;
                            }
                            catch
                            {
                                recipeImage = Properties.Resources.placeholder;
                            }

                            Panel panel = CreateSearchItem(name, recipeImage, () =>
                            {
                                frmRecipe recipeForm = new frmRecipe(recipeId);
                                recipeForm.ShowDialog();
                            });

                            pnlExplore.Controls.Add(panel);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні рецептів: " + ex.Message);
                }
            }
        }

        public void LoadUserRecipes(int userId)
        {
            pnlExplore.Controls.Clear();

            string username = "";

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                try
                {
                    conn.Open();

                    // Отримати ім’я користувача
                    string userQuery = "select username from users where id = @userId";
                    using (var cmdUser = new MySqlCommand(userQuery, conn))
                    {
                        cmdUser.Parameters.AddWithValue("@userId", userId);
                        var result = cmdUser.ExecuteScalar();
                        if (result != null)
                            username = result.ToString();
                    }

                    // Отримати рецепти
                    string query = "select id, name, image_path from recipes where user_id = @userId";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int recipeId = reader.GetInt32("id");
                                string name = reader.GetString("name");
                                string imagePath = reader.GetString("image_path");

                                Image recipeImage;
                                try
                                {
                                    string fullPath = Path.Combine(Application.StartupPath, imagePath);
                                    recipeImage = File.Exists(fullPath) ? Image.FromFile(fullPath) : Properties.Resources.placeholder;
                                }
                                catch
                                {
                                    recipeImage = Properties.Resources.placeholder;
                                }

                                Panel panel = CreateRecipeItemWithAuthor(recipeImage, username, name, () =>
                                {
                                    frmRecipe recipeForm = new frmRecipe(recipeId);
                                    recipeForm.ShowDialog();
                                });

                                pnlExplore.Controls.Add(panel);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні рецептів користувача: " + ex.Message);
                }
            }
        }

        private Panel CreateRecipeItemWithAuthor(Image image, string authorName, string recipeName, Action onClick)
        {
            Panel panel = new Panel
            {
                Width = 200,
                Height = 220,
                Margin = new Padding(10),
                Cursor = Cursors.Hand
            };

            PictureBox picture = new PictureBox
            {
                Width = 180,
                Height = 140,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = image,
                Dock = DockStyle.Top
            };

            Label lblAuthor = new Label
            {
                Text = authorName,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };

            Label lblRecipeName = new Label
            {
                Text = recipeName,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 30
            };

            panel.Controls.Add(lblRecipeName);
            panel.Controls.Add(lblAuthor);
            panel.Controls.Add(picture);

            // Клік на весь елемент
            panel.Click += (s, e) => onClick?.Invoke();
            picture.Click += (s, e) => onClick?.Invoke();
            lblAuthor.Click += (s, e) => onClick?.Invoke();
            lblRecipeName.Click += (s, e) => onClick?.Invoke();

            return panel;
        }
    }
}
