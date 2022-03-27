using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Tester
{
    public partial class alert : Form
    {
        // CBA to explain what all this shitz does if your really THAT intrested then contact me CookiesKush420#4152 and i can explain

        #region Notification Sound
        private void NotificationSound()
        {
            SoundPlayer simpleSound = new SoundPlayer($@"{Environment.CurrentDirectory}\noti.wav");
            simpleSound.Play();
        }
        #endregion

        #region Alert Types
        public alert(string _message, AlertType type)
        {
            InitializeComponent();
            label1.Text = _message;
            switch (type)
            {
                case AlertType.success:
                    NotificationSound();
                    this.BackColor = Color.SeaGreen;
                    icon.Image = imageList1.Images[0];
                    break;
                case AlertType.info:
                    NotificationSound();
                    this.BackColor = Color.Gray;
                    icon.Image = imageList1.Images[1];
                    break;
                case AlertType.warning:
                    NotificationSound();
                    this.BackColor = Color.FromArgb(255, 128, 0);
                    icon.Image = imageList1.Images[2];
                    break;
                case AlertType.error:
                    NotificationSound();
                    this.BackColor = Color.Crimson;
                    icon.Image = imageList1.Images[3];
                    break;
            }
        }
        #endregion

        #region Show Alert
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        public static void Show(string message, AlertType type)
        {
            new Tester.alert(message, type).Show();
        }
        #endregion

        #region Form Load
        private void alert_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            fade.Start();
            this.Top = 935;
            this.Left = Screen.PrimaryScreen.Bounds.Height - this.Height + 510;
        }
        #endregion

        #region Create Alert Types
        public enum AlertType
        {
            success, info, warning, error
        }
        #endregion

        #region Timers
        private void fade_Tick_1(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
        }

        private void close_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        int interval = 0;
        private void show_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval; // Drop the alert
                interval += 1;
            }
            else
            {
                show.Stop();
            }
        }

        private void timeout_Tick_1(object sender, EventArgs e)
        {
            close.Start();
        }
        #endregion

        #region Close Button
        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            close.Start();
        }
        #endregion
    }
}
