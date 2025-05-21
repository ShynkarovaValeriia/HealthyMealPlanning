using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            // Перевірка паролів
            if (password != confirmPassword)
            {
                MessageBox.Show("Паролі не співпадають.");
                return;
            }

            // Підключення до БД
            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();
                string sql = "insert into users (email, username, full_name, password, gender) " +
                             "values (@Email, @Username, @FullName, @Password, @Gender)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Password", password); // бажано хешувати!
                cmd.Parameters.AddWithValue("@Gender", gender);

                int rowsInserted = cmd.ExecuteNonQuery();

                if (rowsInserted > 0)
                {
                    MessageBox.Show("Реєстрація успішна!");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Сталася помилка при реєстрації.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка підключення або запиту: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
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
