using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ModernFlatUIDashboard
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse);
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.pnlFormLoad.Controls.Clear();
            frmDashboard frmDashboard = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoad.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.pnlFormLoad.Controls.Clear();
            frmDashboard frmDashboard = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoad.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Analytics";
            this.pnlFormLoad.Controls.Clear();
            frmAnalytics frmDashboard = new frmAnalytics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoad.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalendar.Height;
            pnlNav.Top = btnCalendar.Top;
            btnCalendar.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Calendar";
            this.pnlFormLoad.Controls.Clear();
            frmCalender frmDashboard = new frmCalender() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoad.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContact.Height;
            pnlNav.Top = btnContact.Top;
            btnContact.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Contact";
            this.pnlFormLoad.Controls.Clear();
            frmContact frmDashboard = new frmContact() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoad.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Settings";
            this.pnlFormLoad.Controls.Clear();
            frmSettings frmDashboard = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoad.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalendar_Leave(object sender, EventArgs e)
        {
            btnCalendar.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContact_Leave(object sender, EventArgs e)
        {
            btnContact.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
