using System;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Cookies_Loader_Base
{
    public partial class Login : Form
    {
        #region Drop Shadow & Rounded Form Corners

        #region DLL Imports

        #region Rounded Form Corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );
        #endregion

        #region Drop Shadow
        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        #endregion

        #endregion

        #region Other Shit
        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;
        
        }
        #endregion
        
        #endregion

        #region API Config
        public static api KeyAuthApp = new api(
            name: "",
            ownerid: "",
            secret: "",
            version: "1.0"
        );
        #endregion

        #region Exit Button Click
        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("CPR"))
            {
                process.Kill();
            }
            Thread.Sleep(2500);
            Environment.Exit(0);
        }
        #endregion

        #region Minimize Button Click
        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {

        }
        #endregion
       
        #region Notification sound download
        Uri sounds = new Uri("https://cdn.discordapp.com/attachments/937072476498837505/951661533824421928/noti.wav");
        string file_sound = Path.GetTempPath() + "noti.wav";
        #endregion

        #region Form Load
        private void Login_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Opacity = 0;
            LauncherTimer.Start();

            #region Download Notification Sound
            if (File.Exists(file_sound))
            {
                File.Delete(file_sound);
                WebClient wc = new WebClient();
                wc.DownloadFileAsync(sounds, file_sound);
            }
            else
            {
                WebClient wc = new WebClient();
                wc.DownloadFileAsync(sounds, file_sound);
            }
            #endregion

            KeyAuthApp.init();

            #region Invalidver response
            if (KeyAuthApp.response.message == "invalidver")
            {
                if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
                {
                    DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            Process.Start(KeyAuthApp.app_data.downloadLink);
                            Environment.Exit(0);
                            break;
                        case DialogResult.No:
                            WebClient webClient = new WebClient();
                            string destFile = Application.ExecutablePath;

                            string rand = random_string();

                            destFile = destFile.Replace(".exe", $"-{rand}.exe");
                            webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile);

                            Process.Start(destFile);
                            Process.Start(new ProcessStartInfo()
                            {
                                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = "cmd.exe"
                            });
                            Environment.Exit(0);

                            break;
                        default:
                            MessageBox.Show("Invalid option");
                            Environment.Exit(0);
                            break;
                    }
                }
                MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
                Thread.Sleep(2500);
                Environment.Exit(0);
            }

            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }
            // if(KeyAuthApp.checkblack())
            // {
            //     MessageBox.Show("user is blacklisted");
            // }
            // else
            // {
            //     MessageBox.Show("user is not blacklisted");
            // }
            KeyAuthApp.check();
            #endregion
        }

        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;

        }

        #endregion

        #region Login Button Click
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(username.Text, password.Text);
            if (KeyAuthApp.response.success)
            {
                alert.Show("Login Successful", alert.AlertType.success);
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
                status.Text = "Status: " + KeyAuthApp.response.message;
        }
        #endregion

        #region Initialize Form
        public Login()
        {
            InitializeComponent();

            #region Set Rounded Form Corners
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            #endregion
            
            #region Set Form Drop Shadow
            m_aeroEnabled = false;
            #endregion

        }
        #endregion

        #region Clean up input boxes
        
        #region Username
        private void username_Enter_1(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
        private void username_Leave(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        #endregion

        #region Password
        private void password_Enter(object sender, EventArgs e)
        {
            password.isPassword = true;
            label4.Visible = false;
        }
        private void password_Leave(object sender, EventArgs e)
        {
            password.isPassword = true;
            label4.Visible = true;
        }

        #endregion

        #endregion

        #region Launch Timer
        int a = 0;
        private void LauncherTimer_Tick(object sender, EventArgs e)
        {
            a++;
            if (a > 10)
            {
                this.WindowState = FormWindowState.Normal;
                fadeintimer.Start();
                LauncherTimer.Stop();
            }
        }
        #endregion

        #region Dont have an account label
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Register();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.FromArgb(120, 0, 255);
        }
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.FromArgb(125, 137, 149);
        }
        #endregion

        #region Fade in timer
        private void fadeintimer_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.05;
        }
        #endregion
    }
}

