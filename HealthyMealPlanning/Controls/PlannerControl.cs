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
    public partial class PlannerControl : UserControl
    {
        public PlannerControl()
        {
            InitializeComponent();
        }

        // Заповнення лейблів датами відповідно до поточного тижня
        private void PlannerControl_Load(object sender, EventArgs e)
        {
            // Поточна дата
            DateTime today = DateTime.Today;

            // Визначаємо, який сьогодні день тижня (понеділок — 1, неділя — 0)
            int delta = DayOfWeek.Monday - today.DayOfWeek;
            if (delta > 0) delta -= 7; // якщо сьогодні неділя, вона вважається останнім днем тижня

            // Отримуємо понеділок поточного тижня
            DateTime monday = today.AddDays(delta);

            // Заповнюємо лейбли датами відповідно до днів тижня
            lblMonday.Text = $"Понеділок {monday:dd.MM}";
            lblTuesday.Text = $"Вівторок {monday.AddDays(1):dd.MM}";
            lblWednesday.Text = $"Середа {monday.AddDays(2):dd.MM}";
            lblThursday.Text = $"Четвер {monday.AddDays(3):dd.MM}";
            lblFriday.Text = $"П'ятниця {monday.AddDays(4):dd.MM}";
            lblSaturday.Text = $"Субота {monday.AddDays(5):dd.MM}";
            lblSunday.Text = $"Неділя {monday.AddDays(6):dd.MM}";

            // Автоматичне оновлення при завантаженні
            UpdateWeekLabels(DateTime.Today);
        }

        // Метод, який оновлює дати в лейблах на основі вибраної дати
        private void UpdateWeekLabels(DateTime selectedDate)
        {
            // Обчислюємо дату понеділка для вибраної дати
            int delta = DayOfWeek.Monday - selectedDate.DayOfWeek;
            if (delta > 0) delta -= 7;
            DateTime monday = selectedDate.AddDays(delta);

            // Заповнюємо лейбли на основі дати понеділка
            lblMonday.Text = $"Понеділок {monday:dd.MM}";
            lblTuesday.Text = $"Вівторок {monday.AddDays(1):dd.MM}";
            lblWednesday.Text = $"Середа {monday.AddDays(2):dd.MM}";
            lblThursday.Text = $"Четвер {monday.AddDays(3):dd.MM}";
            lblFriday.Text = $"П'ятниця {monday.AddDays(4):dd.MM}";
            lblSaturday.Text = $"Субота {monday.AddDays(5):dd.MM}";
            lblSunday.Text = $"Неділя {monday.AddDays(6):dd.MM}";

            // Задання Tag кожній кнопці під час завантаження
            btnAddMonday.Tag = monday;
            btnAddTuesday.Tag = monday.AddDays(1);
            btnAddWednesday.Tag = monday.AddDays(2);
            btnAddThursday.Tag = monday.AddDays(3);
            btnAddFriday.Tag = monday.AddDays(4);
            btnAddSaturday.Tag = monday.AddDays(5);
            btnAddSunday.Tag = monday.AddDays(6);

            // Виклик LoadMealPlans(monday)
            LoadMealPlans(monday);
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateWeekLabels(e.Start); // e.Start — вибрана дата
        }

        // Код для відкриття меню
        private void btnAddMonday_Click(object sender, EventArgs e)
        {
            contextMenuAdd.Tag = btnAddMonday.Tag;
            contextMenuAdd.Show(Cursor.Position);
        }

        private void btnAddTuesday_Click(object sender, EventArgs e)
        {
            contextMenuAdd.Tag = btnAddTuesday.Tag;
            contextMenuAdd.Show(Cursor.Position);
        }

        private void btnAddWednesday_Click(object sender, EventArgs e)
        {
            contextMenuAdd.Tag = btnAddWednesday.Tag;
            contextMenuAdd.Show(Cursor.Position);
        }

        private void btnAddThursday_Click(object sender, EventArgs e)
        {
            contextMenuAdd.Tag = btnAddThursday.Tag;
            contextMenuAdd.Show(Cursor.Position);
        }

        private void btnAddFriday_Click(object sender, EventArgs e)
        {
            contextMenuAdd.Tag = btnAddFriday.Tag;
            contextMenuAdd.Show(Cursor.Position);
        }

        private void btnAddSaturday_Click(object sender, EventArgs e)
        {
            contextMenuAdd.Tag = btnAddSaturday.Tag;
            contextMenuAdd.Show(Cursor.Position);
        }

        private void btnAddSunday_Click(object sender, EventArgs e)
        {
            contextMenuAdd.Tag = btnAddSunday.Tag;
            contextMenuAdd.Show(Cursor.Position);
        }

        // Обробник пункту меню Додати рецепт
        private void addRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contextMenuAdd.Tag == null)
                return;

            if (contextMenuAdd.Tag is DateTime selectedDate)
            {
                // Відкриваємо форму вибору рецепта і передаємо дату
                frmSelectRecipe selectForm = new frmSelectRecipe(selectedDate);
                selectForm.ShowDialog();
            }
        }

        // Відображення доданих рецептів для кожного дня
        private void LoadMealPlans(DateTime monday)
        {
            // Спочатку очищаємо всі панелі
            pnlMonday.Controls.Clear();
            pnlTuesday.Controls.Clear();
            pnlWednesday.Controls.Clear();
            pnlThursday.Controls.Clear();
            pnlFriday.Controls.Clear();
            pnlSaturday.Controls.Clear();
            pnlSunday.Controls.Clear();

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                        select mp.id, mp.plan_date, mp.meal_type, r.id as recipe_id, r.name, r.image_path
                        from meal_plans mp
                        join recipes r on mp.recipe_id = r.id
                        where mp.user_id = @UserId and mp.plan_date between @Start and @End
                        order by mp.plan_date, mp.meal_type";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", Session.UserId);
                    cmd.Parameters.AddWithValue("@Start", monday.Date);
                    cmd.Parameters.AddWithValue("@End", monday.AddDays(6).Date);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime date = reader.GetDateTime("plan_date");
                            string mealType = reader.GetString("meal_type");
                            string recipeName = reader.GetString("name");
                            string imagePath = reader.GetString("image_path");
                            int recipeId = reader.GetInt32("recipe_id");

                            // Створюємо картку рецепта
                            Panel recipeCard = CreateRecipeCard(recipeId, recipeName, mealType, imagePath);

                            // Додаємо до відповідної панелі
                            switch (date.DayOfWeek)
                            {
                                case DayOfWeek.Monday: pnlMonday.Controls.Add(recipeCard); break;
                                case DayOfWeek.Tuesday: pnlTuesday.Controls.Add(recipeCard); break;
                                case DayOfWeek.Wednesday: pnlWednesday.Controls.Add(recipeCard); break;
                                case DayOfWeek.Thursday: pnlThursday.Controls.Add(recipeCard); break;
                                case DayOfWeek.Friday: pnlFriday.Controls.Add(recipeCard); break;
                                case DayOfWeek.Saturday: pnlSaturday.Controls.Add(recipeCard); break;
                                case DayOfWeek.Sunday: pnlSunday.Controls.Add(recipeCard); break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні плану харчування: " + ex.Message);
                }
            }
        }

        // Метод для створення картки рецепта
        private Panel CreateRecipeCard(int recipeId, string name, string mealType, string imagePath)
        {
            Panel panel = new Panel
            {
                Width = 520,
                Height = 70,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5),
                Tag = recipeId
            };

            PictureBox picture = new PictureBox
            {
                Width = 60,
                Height = 60,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(5, 5)
            };

            try
            {
                string fullPath = Path.Combine(Application.StartupPath, imagePath);
                picture.Image = File.Exists(fullPath)
                    ? Image.FromFile(fullPath)
                    : Properties.Resources.placeholder;
            }
            catch
            {
                picture.Image = Properties.Resources.placeholder;
            }

            Label lblName = new Label
            {
                Text = name,
                Font = new Font("Calibri", 14, FontStyle.Regular),
                Location = new Point(75, 5),
                AutoSize = true
            };

            Label lblMealType = new Label
            {
                Text = mealType,
                Font = new Font("Calibri", 14, FontStyle.Regular),
                ForeColor = Color.Gray,
                Location = new Point(75, 30),
                AutoSize = true
            };

            panel.Controls.Add(picture);
            panel.Controls.Add(lblName);
            panel.Controls.Add(lblMealType);

            panel.Cursor = Cursors.Hand;
            panel.Click += (s, e) =>
            {
                frmRecipe recipeForm = new frmRecipe(recipeId);
                recipeForm.ShowDialog();
            };

            return panel;
        }
    }
}
