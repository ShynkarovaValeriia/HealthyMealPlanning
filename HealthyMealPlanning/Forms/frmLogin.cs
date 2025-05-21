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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Будь ласка, введіть ім'я користувача та пароль.");
                return;
            }

            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();

                string sql = "select id, username, full_name from users where username = @Username and password = @Password";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Зберігаємо дані користувача у Session
                    Session.UserId = reader.GetInt32("id");
                    Session.Username = reader.GetString("username");
                    Session.FullName = reader.GetString("full_name");

                    MessageBox.Show("Вхід виконано успішно!");
                    this.Hide();
                    new frmHome().Show();
                }
                else
                {
                    MessageBox.Show("Невірне ім'я користувача або пароль.");
                }

                reader.Close();
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

        private void lblRegisterNow_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister registerForm = new frmRegister();
            registerForm.Show();
        }
    }
}
