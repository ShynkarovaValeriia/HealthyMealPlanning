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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            frmHome homeForm = new frmHome();
            homeForm.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Створюємо новий екземпляр контролу
            HomeControl home = new HomeControl();

            // Очищаємо попередній вміст
            pnlMain.Controls.Clear();

            // Додаємо новий UserControl
            home.Dock = DockStyle.Fill; // щоб заповнив панель
            pnlMain.Controls.Add(home);
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            // Створюємо новий екземпляр контролу
            ExploreControl explore = new ExploreControl();

            // Очищаємо попередній вміст
            pnlMain.Controls.Clear();

            // Додаємо новий UserControl
            explore.Dock = DockStyle.Fill; // щоб заповнив панель
            pnlMain.Controls.Add(explore);
        }

        private void btnPlanner_Click(object sender, EventArgs e)
        {
            // Створюємо новий екземпляр контролу
            PlannerControl planner = new PlannerControl();

            // Очищаємо попередній вміст
            pnlMain.Controls.Clear();

            // Додаємо новий UserControl
            planner.Dock = DockStyle.Fill; // щоб заповнив панель
            pnlMain.Controls.Add(planner);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            // Створюємо новий екземпляр контролу
            ProfileControl profile = new ProfileControl();

            // Очищаємо попередній вміст
            pnlMain.Controls.Clear();

            // Додаємо новий UserControl
            profile.Dock = DockStyle.Fill; // щоб заповнив панель
            pnlMain.Controls.Add(profile);
        }
    }
}
