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
            #region  HWIDGRAB
            var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorId"].ToString();
                break;
            }
            #endregion

            #region Login Function
            WebClient wc = new WebClient();
            string HWIDLIST = wc.DownloadString("https://pastebin.com/raw/"); // Enter your pastebin RAW URL here

            #region  Check if password not set & hwid in database & usernameTxt input is their pc username
            if (Properties.Settings.Default.Password == "" && HWIDLIST.Contains(id) && pc_username == usernameTxt.Text)
            {
                #region Set Password
                Properties.Settings.Default.Password = passwordTxt.Text;
                Properties.Settings.Default.Save(); // Saves the change
                #endregion

                alert.Show("Account Created Relogin!", alert.AlertType.success);
            }
            #endregion

            #region Check if hwid in database & usernameTxt input is their pc username & passwordTxt input is = to there saved password
            else if (HWIDLIST.Contains(id) && pc_username == usernameTxt.Text && Properties.Settings.Default.Password == passwordTxt.Text)
            {
                alert.Show("Logged In", alert.AlertType.success);

                #region Remember me Checkbox
                if (remembermeCheckbox.Checked == true)
                {
                    Properties.Settings.Default.rememberMe = true;
                    Properties.Settings.Default.Save(); // Saves the change
                }
                #endregion

                this.Hide();
                var main_form = new Form1();
                main_form.Closed += (s, args) => this.Close();
                main_form.Show();
            }
            #endregion

            #region Else Invalid Inputs
            else
            {
                clear_inputfields(); // Sets bot input fields to empty
                alert.Show("Invalid Credentials", alert.AlertType.error);
            }
            #endregion
            
            wc.Dispose();
            #endregion
        }
        #endregion

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
            // If remember me check box has ever been check then we auto fill password
            if (Properties.Settings.Default.rememberMe == true)
            {
                remembermeCheckbox.Checked = true;
                passwordTxt.Text = Properties.Settings.Default.Password;
            }
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
