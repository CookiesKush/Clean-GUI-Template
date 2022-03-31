using System;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Net;
using System.Management;
using System.IO;
using System.Runtime.InteropServices;

namespace Tester
{
    public partial class FrmLogin : Form
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

        #region Variables
        string pc_username = Environment.UserName;
        bool password_Visibility = false;
        #endregion

        #region Clear Input Fields
        private void clear_inputfields()
        {
            usernameTxt.Text = "";
            passwordTxt.Text = "";
        }
        #endregion

        #region Download Notification Sound
        private void download_noti_sound()
        {
            #region Notification Sound URL
            Uri sounds = new Uri("https://cdn.discordapp.com/attachments/947224575622676520/956591975174373416/noti.wav");
            string file_sound = $@"{Environment.CurrentDirectory}\noti.wav";
            #endregion

            #region Check if noti sound is downloaded then delete and redownload it just incase
            if (File.Exists(file_sound))
            {
                File.Delete(file_sound);
                WebClient wc = new WebClient();
                wc.DownloadFileAsync(sounds, file_sound);
            }
            #endregion

            #region Else we download it
            else
            {
                WebClient wc = new WebClient();
                wc.DownloadFileAsync(sounds, file_sound);
            }
            #endregion
        }
        #endregion

        #region Form Initialize
        public FrmLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            download_noti_sound(); // Download the sound ready for use to stop errors occuring
        }
        #endregion

        #region Login Button Click
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            string username = new System.Net.WebClient() { Proxy = null }.DownloadString("https://pastebin.com/raw/bvu0PLKm");
            string password = new System.Net.WebClient() { Proxy = null }.DownloadString("https://pastebin.com/raw/wx32Fszi");


            if (username.Contains(usernameTxt.Text) && (password.Contains(passwordTxt.Text)))
            {
                MessageBox.Show("Welcome " + pc_username);
                alert.Show("Logged In", alert.AlertType.success);
                this.Hide();
                var main_form = new Form1();
                main_form.Closed += (s, args) => this.Close();
                main_form.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect.");
            }
        }


        #region Close & Minimize Btns
        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes this Form
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized; // Minimizes this Form
        }
        #endregion

        #region Form Load
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            bunifuCustomTextbox1.Visible = true;

        }
        #endregion

        #region How to Login Button
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var HowToLoginFrm = new FrmHowToLogin();
            HowToLoginFrm.Closed += (s, args) => this.Close();
            HowToLoginFrm.Show();
        }
        #endregion

        #region Show Pass Btn
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // If turned on then we turn off
            if (password_Visibility == true)
                password_Visibility = false;
            // If turned off we turn on
            else
                password_Visibility = true;

            if (password_Visibility == true)
            {
                passwordTxt.PasswordChar = '\0';
            }
            else
            {
                passwordTxt.PasswordChar = '*';
            }
        }
        #endregion
    }
}
