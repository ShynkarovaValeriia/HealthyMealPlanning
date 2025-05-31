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
using System.Runtime.InteropServices;

namespace HealthyMealPlanning
{
    public partial class frmHome : Form
    {
        // Зовнішні методи для роботи з WinAPI
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        
        public Panel MainPanel => pnlMain;

        public frmHome()
        {
            InitializeComponent();
            LoadHomeControl();
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
            LoadHomeControl();
        }

        private void LoadHomeControl()
        {
            // Створюємо новий екземпляр контролу
            HomeControl home = new HomeControl();
            home.MainPanel = pnlMain; // Передаємо головну панель

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

            profile.LoadFavoriteRecipes();
            profile.LoadSavedRecipes();
            profile.LoadUserReviews();
        }

        // Переміщення форми
        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
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
