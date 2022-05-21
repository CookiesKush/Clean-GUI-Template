using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace Tester
{
    public partial class FrmBuild : Form
    {
        #region Initialize
        public FrmBuild()
        {
            InitializeComponent();
        }
        #endregion
        
        #region Button clicks
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 2");
        }
        #endregion

        #region Clear Inputs On Focus
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "TEMPLATE")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "TEMPLATE";
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "TEMPLATE")
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "TEMPLATE";
            }
        }
        #endregion
    }
}
