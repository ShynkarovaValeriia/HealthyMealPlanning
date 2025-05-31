using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HealthyMealPlanning
{
    public partial class frmSelectRecipe : Form
    {
        // Зовнішні методи для роботи з WinAPI
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private DateTime selectedDate;

        public frmSelectRecipe(DateTime date)
        {
            InitializeComponent();
            selectedDate = date;
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
            flowLayoutPanelResults.Controls.Clear();

            int totalResults = 0;

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

                            Panel panel = CreateSearchItem(recipeId, name, imagePath, recipeImage);
                            flowLayoutPanelResults.Controls.Add(panel);
                            totalResults++;

                            flowLayoutPanelResults.Controls.Add(panel);
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

        private Panel CreateSearchItem(int recipeId, string name, string imagePath, Image image)
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
                Text = name,
                Font = new Font("Calibri", 14, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Bottom,
                Height = 40
            };

            // Обробник кліку
            EventHandler clickHandler = (s, ev) =>
            {
                frmAddToMealPlan form = new frmAddToMealPlan(Session.UserId, recipeId, name, imagePath, selectedDate);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.Close(); // Закриваємо форму вибору рецепта після додавання
                }
            };

            panel.Click += clickHandler;
            picture.Click += clickHandler;
            label.Click += clickHandler;

            panel.Controls.Add(picture);
            panel.Controls.Add(label);

            return panel;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchExplore(txtSearch.Text.Trim());
        }

        // Переміщення форми
        private void frmSelectRecipe_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}