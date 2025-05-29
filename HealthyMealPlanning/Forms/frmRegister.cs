using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HealthyMealPlanning
{
    public partial class frmRegister : Form
    {
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
                    ClearForm();
                    this.Close();
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
    }
}