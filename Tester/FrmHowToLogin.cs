using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tester
{
    public partial class FrmHowToLogin : Form
    {
        public FrmHowToLogin()
        {
            InitializeComponent();
        }

        #region Back to login page button
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new FrmLogin();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(173, 35, 35);
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }
        #endregion

    }
}
