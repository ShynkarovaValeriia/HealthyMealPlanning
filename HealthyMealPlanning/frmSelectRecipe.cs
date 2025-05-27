using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HealthyMealPlanning
{
    public partial class frmSelectRecipe : Form
    {
        private DateTime selectedDate;

        public frmSelectRecipe(DateTime date)
        {
            InitializeComponent();
            selectedDate = date;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadRecipes(txtSearch.Text.Trim());
        }

        private void LoadRecipes(string keyword)
        {
            flowLayoutPanelResults.Controls.Clear();

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"select id, name, image_path from recipes 
                                     where name like @Keyword order by created_at desc";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int recipeId = reader.GetInt32("id");
                            string name = reader.GetString("name");
                            string imagePath = reader.GetString("image_path");

                            // Створення панелі
                            Panel panel = new Panel
                            {
                                Width = 350,
                                Height = 60,
                                BorderStyle = BorderStyle.FixedSingle,
                                Margin = new Padding(5),
                                Tag = recipeId // збережемо id рецепта
                            };

                            Label label = new Label
                            {
                                Text = name,
                                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                                AutoSize = false,
                                TextAlign = ContentAlignment.MiddleLeft,
                                Dock = DockStyle.Left,
                                Width = 250
                            };

                            PictureBox picture = new PictureBox
                            {
                                Width = 60,
                                Height = 60,
                                SizeMode = PictureBoxSizeMode.Zoom,
                                Dock = DockStyle.Right
                            };

                            try
                            {
                                string fullPath = Path.Combine(Application.StartupPath, imagePath);
                                if (File.Exists(fullPath))
                                    picture.Image = Image.FromFile(fullPath);
                                else
                                    picture.Image = Properties.Resources.placeholder;
                            }
                            catch
                            {
                                picture.Image = Properties.Resources.placeholder;
                            }

                            panel.Controls.Add(label);
                            panel.Controls.Add(picture);

                            // Подія на клік по панелі
                            panel.Click += (s, ev) =>
                            {
                                frmAddToMealPlan form = new frmAddToMealPlan(Session.UserId, recipeId, name, imagePath, selectedDate);
                                if (form.ShowDialog() == DialogResult.OK)
                                {
                                    this.Close(); // Закриваємо форму вибору рецепта після успішного додавання
                                }
                            };

                            flowLayoutPanelResults.Controls.Add(panel);
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
}