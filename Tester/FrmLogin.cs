using System;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Net;
using System.Management;
using System.IO;
using System.Drawing;
using System.Diagnostics;

namespace Tester
{
    public partial class FrmLogin : Form
    {
        #region Variables
        string pc_username = Environment.UserName;
        bool password_Visibility = false;
        string temp = Path.GetTempPath();
        #endregion

        #region Clear Inputs
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
            Uri sounds = new Uri("https://cdn.discordapp.com/attachments/947224575622676520/958721082460872744/noti_new.wav");
            string file_sound = $@"{temp}\noti.wav";
            #endregion

            #region Download Sound if dont downloaded
            if (!File.Exists(file_sound))
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
        }
        #endregion

        #region Login Function / Button Click
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            #region Login
            WebClient wc = new WebClient();
            string PASSLIST = wc.DownloadString("https://pastebin.com/raw/LINK-HERE");
            string pass = passwordTxt.Text;

            #region Check if never logged in before & they entered username and password into textboxs
            if (Properties.Settings.Default.Password == "" && PASSLIST.Contains(passwordTxt.Text) && pc_username == usernameTxt.Text)
            {
                #region Set Password
                Properties.Settings.Default.Password = passwordTxt.Text;
                Properties.Settings.Default.Save();
                #endregion

                alert.Show("Account Created Relogin!", alert.AlertType.success);
            }
            #endregion

            #region Check if logged in before and inputs are correct
            else if (PASSLIST.Contains(passwordTxt.Text) && pc_username == usernameTxt.Text)
            {
                #region Set Password
                Properties.Settings.Default.Password = passwordTxt.Text;
                Properties.Settings.Default.Save();
                #endregion

                alert.Show("Logged In", alert.AlertType.success);

                if (remembermeCheckbox.Checked == true)
                {
                    Properties.Settings.Default.rememberMe = true;
                    Properties.Settings.Default.Save();
                }

                this.Hide();
                var main_form = new Form1();
                main_form.Closed += (s, args) => this.Close();
                main_form.Show();
            }

            else if (!PASSLIST.Contains(passwordTxt.Text))
            {
                clear_inputfields();
                alert.Show("Password not found!", alert.AlertType.error);
            }

            else
            {
                clear_inputfields();
                alert.Show("Invalid Credentials", alert.AlertType.error);
            }
            #endregion

            wc.Dispose();
            #endregion
        }
        #endregion

        #region Detect if Python is installed
        private void Detect_if_pythons_exists()
        {
            string python_download = $@"C:\Users\{Environment.UserName}\AppData\Local\Programs\Python\Python39\python.exe";

            if (!File.Exists(python_download))
            {
                DialogResult dialogResult = MessageBox.Show("Oops seems like u don't have Python installed or incompatible version\n\nWould u like to download the correct version of Python", "Oops", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Make sure to click the checkbox ADD TO PATH on installation!\n\nAny problems create a ticket in discord server");
                    Process.Start("https://www.python.org/ftp/python/3.9.7/python-3.9.7-amd64.exe");
                }
                if (dialogResult == DialogResult.No)
                {
                    alert.Show("Canceled Downloading Python", alert.AlertType.info);
                }
            }
        }
        #endregion

        #region Form Load
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            download_noti_sound();

            Detect_if_pythons_exists();

            #region Remember Me Check
            if (Properties.Settings.Default.rememberMe == true)
            {
                remembermeCheckbox.Checked = true;
                passwordTxt.Text = Properties.Settings.Default.Password;
            }
            #endregion
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

        #region Show Pass Btn Click
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (password_Visibility == true)
                password_Visibility = false;
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

        #region Username Text Remove On Click
        private void usernameTxt_Enter(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "Enter PC username here")
            {
                usernameTxt.Text = "";
            }
        }

        private void usernameTxt_Leave(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            {
                usernameTxt.Text = "Enter PC username here";
            }
        }
        #endregion

        #region Close & Minimize Buttons
        
        #region Close Btn
        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            string file_sound = $@"{temp}\noti.wav";
            if (File.Exists(file_sound))
            {
                File.Delete(file_sound);
            }
            this.Close();
        }
        private void bunifuCustomLabel2_MouseEnter(object sender, EventArgs e)
        {
            bunifuCustomLabel2.ForeColor = Color.FromArgb(173, 35, 35);
        }
        private void bunifuCustomLabel2_MouseLeave(object sender, EventArgs e)
        {
            bunifuCustomLabel2.ForeColor = Color.White;
        }
        #endregion

        #region Minimize Btn
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void bunifuCustomLabel1_MouseEnter(object sender, EventArgs e)
        {
            bunifuCustomLabel1.ForeColor = Color.FromArgb(173, 35, 35);
        }
        private void bunifuCustomLabel1_MouseLeave(object sender, EventArgs e)
        {
            bunifuCustomLabel1.ForeColor = Color.White;
        }
        #endregion

        #endregion

        #region How To Login Text Color
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
