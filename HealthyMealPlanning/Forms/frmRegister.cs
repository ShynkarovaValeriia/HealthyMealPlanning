using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Runtime.InteropServices;

namespace HealthyMealPlanning
{
    public partial class frmRegister : Form
    {
        // Зовнішні методи для роботи з WinAPI
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string gender = rbMale.Checked ? "male" : rbFemale.Checked ? "female" : "";

            // Перевірка заповнення полів
            if (email == "" || username == "" || fullName == "" || password == "" || confirmPassword == "" || gender == "")
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка формату електронної пошти
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Невірний формат електронної пошти.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка паролів
            if (password != confirmPassword)
            {
                MessageBox.Show("Паролі не співпадають.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();

                // Перевірка чи email або username вже існують
                string checkSql = "select count(*) from users where email = @Email or username = @Username";
                MySqlCommand checkCmd = new MySqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@Email", email);
                checkCmd.Parameters.AddWithValue("@Username", username);

                int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (existingCount > 0)
                {
                    MessageBox.Show("Користувач з такою електронною поштою або іменем вже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Вставка нового користувача
                string sql = "insert into users (email, username, full_name, password, gender) " +
                             "values (@Email, @Username, @FullName, @Password, @Gender)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Password", password); // Хочеш — можемо додати хешування
                cmd.Parameters.AddWithValue("@Gender", gender);

                int rowsInserted = cmd.ExecuteNonQuery();

                if (rowsInserted > 0)
                {
                    // Отримуємо user_id та повне ім’я новоствореного користувача
                    string getUserQuery = "select id, full_name from users where username = @Username";
                    MySqlCommand getUserCmd = new MySqlCommand(getUserQuery, conn);
                    getUserCmd.Parameters.AddWithValue("@Username", username);

                    using (MySqlDataReader reader = getUserCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Session.UserId = reader.GetInt32("id");
                            Session.Username = username;
                            Session.FullName = reader.GetString("full_name");
                        }
                    }

                    ClearForm();
                    this.Hide();
                    new frmHome().Show();
                }
                else
                {
                    MessageBox.Show("Сталася помилка при реєстрації.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка підключення або запиту: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void ClearForm()
        {
            txtEmail.Clear();
            txtUsername.Clear();
            txtFullName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        // Переміщення форми
        private void frmRegister_MouseDown(object sender, MouseEventArgs e)
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