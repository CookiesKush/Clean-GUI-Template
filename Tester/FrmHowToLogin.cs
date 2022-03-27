using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        #endregion
    }
}
