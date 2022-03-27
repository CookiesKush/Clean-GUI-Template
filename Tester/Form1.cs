using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Tester
{
    public partial class Form1 : Form
    {
        #region Rounded Window Imports
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        #endregion

        #region Form Closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        { 
        }
        #endregion

        #region Form Fade In
        private void fade_in_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 100)
                fade_in.Stop();
            else
                this.Opacity += 0.05;
        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Set Dashboard Panel
            // Set Current Button Color
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.BackColor = Color.FromArgb(26, 26, 26);

            // Change other buttons colors
            button5.ForeColor = Color.White;
            button5.BackColor = Color.FromArgb(35, 40, 45);
            button6.ForeColor = Color.White;
            button6.BackColor = Color.FromArgb(35, 40, 45);

            this.panelWindow.Controls.Clear();
            FrmBuild FrmDashboard_Vrb = new FrmBuild() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelWindow.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
            #endregion
        }
        #endregion

        #region Close & Minimize Form
        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        
        #region Side Bar Functions
        bool sliderExpanded;

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            #region Expand Slider
            if (sliderExpanded)
            {
                // If sidebar is expanded, minimze
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sliderExpanded = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sliderExpanded = true;
                    sidebarTimer.Stop();
                }
            }
            #endregion
        }

        private void menuButton_Click(object sender, EventArgs e)
        {       
            sidebarTimer.Start();
        }

        #region Tabs

        #region Build
        private void button2_Click(object sender, EventArgs e)
        {
            // Current Button
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.BackColor = Color.FromArgb(26, 26, 26);

            // Change other buttons colors
            button5.ForeColor = Color.White;
            button5.BackColor = Color.FromArgb(35, 40, 45);
            button6.ForeColor = Color.White;
            button6.BackColor = Color.FromArgb(35, 40, 45);

            this.panelWindow.Controls.Clear(); // Clear panel
            FrmBuild FrmDashboard_Vrb = new FrmBuild() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; // Set new panel Properties
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None; // Set some more Properties
            this.panelWindow.Controls.Add(FrmDashboard_Vrb); // Add the form the "tab form"
            FrmDashboard_Vrb.Show(); // Show the form
        }
        #endregion

        #region Help 
        private void button5_Click(object sender, EventArgs e)
        {
            // Current Button
            button5.ForeColor = Color.FromArgb(116, 86, 174);
            button5.BackColor = Color.FromArgb(26, 26, 26);

            // Change other buttons colors
            button2.ForeColor = Color.White;
            button2.BackColor = Color.FromArgb(35, 40, 45);
            button6.ForeColor = Color.White;
            button6.BackColor = Color.FromArgb(35, 40, 45);

            this.panelWindow.Controls.Clear();
            FrmHelp FrmDashboard_Vrb = new FrmHelp() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelWindow.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }
        #endregion

        #region About
        private void button6_Click(object sender, EventArgs e)
        {
            // Current Button
            button6.ForeColor = Color.FromArgb(116, 86, 174);
            button6.BackColor = Color.FromArgb(26, 26, 26);

            // Change other buttons colors
            button2.ForeColor = Color.White;
            button2.BackColor = Color.FromArgb(35, 40, 45);
            button5.ForeColor = Color.White;
            button5.BackColor = Color.FromArgb(35, 40, 45);

            this.panelWindow.Controls.Clear();
            FrmAbout FrmDashboard_Vrb = new FrmAbout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelWindow.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }
        #endregion

        #endregion

        #endregion

        #region Form Initialize
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Opacity = 0; // Set Opacity = 0 so the form can fade in
        }
        #endregion
    }
}
