using System;
using System.Windows.Forms;

namespace Tester
{
    public partial class FrmAbout : Form
    {
        #region Form Initialize
        public FrmAbout()
        {
            InitializeComponent();
        }
        #endregion

        #region Both button clicks
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 2");
        }
        #endregion
    }
}
