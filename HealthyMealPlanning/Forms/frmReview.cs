using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HealthyMealPlanning
{
    public partial class frmReview : Form
    {
        // Зовнішні методи для роботи з WinAPI
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private int recipeId;
        private int userId;
        private int selectedRating = 0;
        private bool isEditMode = false;
        private int reviewId;

        // Перший конструктор - для створення нового відгуку
        public frmReview(int recipeId, int userId)
        {
            InitializeComponent();
            this.recipeId = recipeId;
            this.userId = userId;
            this.isEditMode = false;
        }

        // Другий конструктор - для редагування існуючого відгуку
        public frmReview(int recipeId, bool isEditMode, int reviewId)
        {
            InitializeComponent();
            this.recipeId = recipeId;
            this.isEditMode = isEditMode;
            this.reviewId = reviewId;

            LoadReviewData();     // завантажити дані відгуку
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

        // Завантаження назви рецепта
        private void frmReview_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();
                string sql = "select name from recipes where id = @RecipeId";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RecipeId", recipeId);

                object result = cmd.ExecuteScalar();
                lblReviewFor.Text = "Огляд для: " + result?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження назви рецепта: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            pbStar1.Tag = 1;
            pbStar2.Tag = 2;
            pbStar3.Tag = 3;
            pbStar4.Tag = 4;
            pbStar5.Tag = 5;

            pbStar1.Click += Star_Click;
            pbStar2.Click += Star_Click;
            pbStar3.Click += Star_Click;
            pbStar4.Click += Star_Click;
            pbStar5.Click += Star_Click;
        }

        // Події натискань на зірки
        private void Star_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = sender as PictureBox;
            int starNumber = int.Parse(clickedStar.Tag.ToString());
            selectedRating = starNumber;
            UpdateStars();
        }

        private void UpdateStars()
        {
            PictureBox[] stars = { pbStar1, pbStar2, pbStar3, pbStar4, pbStar5 };

            for (int i = 0; i < stars.Length; i++)
            {
                if (i < selectedRating)
                    stars[i].Image = Properties.Resources.star_filled;
                else
                    stars[i].Image = Properties.Resources.star_empty;
            }
        }

        // Подія btnSave_Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            string comment = txtDescription.Text.Trim();

            if (selectedRating == 0)
            {
                MessageBox.Show("Оцініть рецепт від 1 до 5 зірок.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();

                string query;

                if (isEditMode)
                {
                    query = @"update ratings set rating = @Rating, comment = @Comment 
                      where id = @ReviewId";
                }
                else
                {
                    query = @"insert into ratings (user_id, recipe_id, rating, comment, created_at)
                      values (@UserId, @RecipeId, @Rating, @Comment, now())";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Rating", selectedRating);
                cmd.Parameters.AddWithValue("@Comment", comment);

                if (isEditMode)
                {
                    cmd.Parameters.AddWithValue("@ReviewId", reviewId);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@RecipeId", recipeId);
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show("Відгук збережено.", "Успішне збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                frmRecipe recipeForm = new frmRecipe(recipeId);
                recipeForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Метод для заповнення форми при редагуванні
        private void LoadReviewData()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();
                string query = "select user_id, rating, comment from ratings where id = @ReviewId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ReviewId", reviewId);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userId = Convert.ToInt32(reader["user_id"]);
                    int rating = Convert.ToInt32(reader["rating"]);
                    string comment = reader["comment"].ToString();

                    txtDescription.Text = comment;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні відгуку: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Переміщення форми
        private void frmReview_MouseDown(object sender, MouseEventArgs e)
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