using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HealthyMealPlanning
{
    public partial class frmRecipe : Form
    {
        // Зовнішні методи для роботи з WinAPI
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private int recipeId;
        private bool isFavorite = false;
        private bool isSaved = false;

        public frmRecipe(int recipeId)
        {
            InitializeComponent();
            this.recipeId = recipeId;
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

        private void frmRecipe_Load(object sender, EventArgs e)
        {
            LoadRecipe();
            LoadReviews();
            LoadAverageRating();
        }

        private void LoadRecipe()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();

                string sql = @"select r.*, u.full_name 
                       from recipes r 
                       join users u on r.user_id = u.id 
                       where r.id = @RecipeId";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RecipeId", recipeId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblNameRecipe.Text = reader["name"].ToString();
                    lblAuthor.Text = "Автор: " + reader["full_name"].ToString();
                    lblCategory.Text = "Категорія: " + reader["category"].ToString();
                    lblDifficulty.Text = "Складність: " + reader["difficulty"].ToString();
                    lblCookingTime.Text = "Час приготування: " + reader["cooking_time"].ToString() + " хвилин";
                    lblPortionsNumber.Text = "Кількість порцій: " + reader["portions_number"].ToString();

                    string imagePath = reader["image_path"].ToString();

                    try
                    {
                        string fullPath = Path.Combine(Application.StartupPath, imagePath);
                        if (File.Exists(fullPath))
                            pbRecipeImage.Image = Image.FromFile(fullPath);
                        else
                            pbRecipeImage.Image = Properties.Resources.placeholder;
                    }
                    catch
                    {
                        pbRecipeImage.Image = Properties.Resources.placeholder;
                    }

                    // Обробка інгредієнтів
                    string ingredientsRaw = reader["ingredients"].ToString();
                    DisplayIngredients(ingredientsRaw);

                    string description = reader["description"].ToString();
                    DisplayDescription(description);
                }
                else
                {
                    MessageBox.Show("Рецептів не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();

                string favQuery = "select count(*) from favorites where user_id = @UserId and recipe_id = @RecipeId";
                MySqlCommand favCmd = new MySqlCommand(favQuery, conn);
                favCmd.Parameters.AddWithValue("@UserId", Session.UserId);
                favCmd.Parameters.AddWithValue("@RecipeId", recipeId);

                int count = Convert.ToInt32(favCmd.ExecuteScalar());
                isFavorite = (count > 0);

                // Встановлення відповідної іконки
                btnFavorite.Image = isFavorite
                    ? Properties.Resources.favorite_filled
                    : Properties.Resources.favorite_empty;

                // Перевірка, чи рецепт збережений
                string saveQuery = "select count(*) from saved_recipes where user_id = @UserId and recipe_id = @RecipeId";
                MySqlCommand saveCmd = new MySqlCommand(saveQuery, conn);
                saveCmd.Parameters.AddWithValue("@UserId", Session.UserId);
                saveCmd.Parameters.AddWithValue("@RecipeId", recipeId);

                int savedCount = Convert.ToInt32(saveCmd.ExecuteScalar());
                isSaved = (savedCount > 0);

                // Встановлення відповідної іконки
                btnSave.Image = isSaved
                    ? Properties.Resources.save_filled
                    : Properties.Resources.save_empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void DisplayIngredients(string ingredientsRaw)
        {
            pnlIngredients.Controls.Clear(); // очищаємо попередні елементи

            if (string.IsNullOrWhiteSpace(ingredientsRaw))
                return;

            // Розділити по кому, крапці з комою, переносу або новому рядку
            string[] ingredients = ingredientsRaw
                .Split(new[] { ',', ';', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string ingredient in ingredients)
            {
                Label lbl = new Label();
                lbl.Text = ingredient.Trim();
                lbl.AutoSize = true;
                lbl.Font = new Font("Calibri", 16, FontStyle.Regular);
                lbl.Margin = new Padding(3);
                pnlIngredients.Controls.Add(lbl);
            }
        }

        private void DisplayDescription(string description)
        {
            pnlDescription.Controls.Clear();

            if (string.IsNullOrWhiteSpace(description))
                return;

            Label lblDescription = new Label();
            lblDescription.Text = description.Trim();
            lblDescription.Font = new Font("Calibri", 16, FontStyle.Regular);
            lblDescription.AutoSize = true;
            lblDescription.MaximumSize = new Size(pnlDescription.Width - 20, 0);
            lblDescription.Padding = new Padding(10);

            pnlDescription.AutoScroll = true;

            pnlDescription.Controls.Add(lblDescription);
        }

        private void btnCreateReview_Click(object sender, EventArgs e)
        {
            frmReview reviewForm = new frmReview(recipeId, Session.UserId);
            reviewForm.ShowDialog();
            this.Close();
        }

        // Метод для завантаження відгуків
        private void LoadReviews()
        {
            pnlReviews.Controls.Clear();

            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();

                string query = @"select r.rating, r.comment, r.created_at, u.full_name 
                         from ratings r 
                         join users u on r.user_id = u.id 
                         where r.recipe_id = @RecipeId 
                         order by r.created_at desc";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RecipeId", recipeId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    int y = 10; // Відступ зверху

                    while (reader.Read())
                    {
                        int rating = Convert.ToInt32(reader["rating"]);
                        string comment = reader["comment"].ToString();
                        string fullName = reader["full_name"].ToString();
                        string date = Convert.ToDateTime(reader["created_at"]).ToString("dd.MM.yyyy");

                        // Панель для одного відгуку
                        Panel reviewPanel = new Panel();
                        reviewPanel.Width = pnlReviews.Width - 30;
                        reviewPanel.Height = 100;
                        reviewPanel.Location = new Point(10, y);
                        reviewPanel.BorderStyle = BorderStyle.FixedSingle;

                        // Ім'я та дата
                        Label lblInfo = new Label();
                        lblInfo.Text = $"{fullName}, {date}";
                        lblInfo.Font = new Font("Calibri", 16, FontStyle.Regular);
                        lblInfo.Location = new Point(10, 10);
                        lblInfo.AutoSize = true;

                        // Зірки
                        int starX = 10;
                        for (int i = 1; i <= 5; i++)
                        {
                            PictureBox star = new PictureBox();
                            star.Width = 20;
                            star.Height = 20;
                            star.SizeMode = PictureBoxSizeMode.Zoom;
                            star.Image = (i <= rating) ? Properties.Resources.star_filled : Properties.Resources.star_empty;
                            star.Location = new Point(starX, 35);
                            reviewPanel.Controls.Add(star);
                            starX += 25;
                        }

                        // Коментар
                        Label lblComment = new Label();
                        lblComment.Text = comment;
                        lblComment.Font = new Font("Calibri", 18, FontStyle.Regular);
                        lblComment.Location = new Point(10, 60);
                        lblComment.AutoSize = true;
                        lblComment.MaximumSize = new Size(reviewPanel.Width - 20, 0);

                        // Додавання елементів
                        reviewPanel.Controls.Add(lblInfo);
                        reviewPanel.Controls.Add(lblComment);

                        pnlReviews.Controls.Add(reviewPanel);
                        y += reviewPanel.Height + 10;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні відгуків: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Метод для завантаження середнього рейтингу
        private void LoadAverageRating()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();

                string query = "select avg(rating) as avg_rating from ratings where recipe_id = @RecipeId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RecipeId", recipeId);

                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    double avgRating = Math.Round(Convert.ToDouble(result), 1); // округлення до 1 знаку
                    UpdateAverageStars(avgRating);
                }
                else
                {
                    UpdateAverageStars(0); // якщо відгуків немає
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні рейтингу: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Метод для заповнення зірок
        private void UpdateAverageStars(double avgRating)
        {
            PictureBox[] stars = pnlAverageRatings.Controls.OfType<PictureBox>().ToArray();

            int fullStars = (int)Math.Floor(avgRating);
            bool hasHalfStar = (avgRating - fullStars) >= 0.5;

            for (int i = 0; i < 5; i++)
            {
                if (i < fullStars)
                {
                    stars[i].Image = Properties.Resources.star_filled;
                }
                else if (i == fullStars && hasHalfStar)
                {
                    stars[i].Image = Properties.Resources.star_half;
                }
                else
                {
                    stars[i].Image = Properties.Resources.star_empty;
                }
            }
        }

        // Додавання рецепта до обраного
        private void btnFavorite_Click(object sender, EventArgs e)
        {
            int userId = Session.UserId;
            if (userId == 0)
            {
                MessageBox.Show("Будь ласка, увійдіть у систему.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();

                if (isFavorite)
                {
                    // Видалити з обраного
                    string deleteQuery = "delete from favorites where user_id = @UserId and recipe_id = @RecipeId";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@UserId", userId);
                    deleteCmd.Parameters.AddWithValue("@RecipeId", recipeId);
                    deleteCmd.ExecuteNonQuery();

                    isFavorite = false;
                    btnFavorite.Image = Properties.Resources.favorite_empty;
                }
                else
                {
                    // Додати в обране
                    string insertQuery = "insert into favorites (user_id, recipe_id, created_at) values (@UserId, @RecipeId, now())";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@UserId", userId);
                    insertCmd.Parameters.AddWithValue("@RecipeId", recipeId);
                    insertCmd.ExecuteNonQuery();

                    isFavorite = true;
                    btnFavorite.Image = Properties.Resources.favorite_filled;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при оновленні обраного: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Функціонал збережених рецептів
        private void btnSave_Click(object sender, EventArgs e)
        {
            int userId = Session.UserId;
            if (userId == 0)
            {
                MessageBox.Show("Будь ласка, увійдіть у систему.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();

                if (isSaved)
                {
                    // Видалити з збережених
                    string deleteQuery = "delete from saved_recipes where user_id = @UserId and recipe_id = @RecipeId";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@UserId", userId);
                    deleteCmd.Parameters.AddWithValue("@RecipeId", recipeId);
                    deleteCmd.ExecuteNonQuery();

                    isSaved = false;
                    btnSave.Image = Properties.Resources.save_empty;
                }
                else
                {
                    // Додати в збережені
                    string insertQuery = "insert into saved_recipes (user_id, recipe_id, created_at) values (@UserId, @RecipeId, now())";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@UserId", userId);
                    insertCmd.Parameters.AddWithValue("@RecipeId", recipeId);
                    insertCmd.ExecuteNonQuery();

                    isSaved = true;
                    btnSave.Image = Properties.Resources.save_filled;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при оновленні збереженого: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Переміщення форми
        private void frmRecipe_MouseDown(object sender, MouseEventArgs e)
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
