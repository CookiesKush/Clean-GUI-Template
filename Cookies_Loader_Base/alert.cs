using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookies_Loader_Base
{
    public partial class alert : Form
    {
        private void NotificationSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(Path.GetTempPath() + "noti.wav");
        }
        string temp = Path.GetTempPath();

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        public static void Show(string message, AlertType type)
        {
            new Cookies_Loader_Base.alert(message, type).Show();
        }

        private void alert_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            fade.Start();
            this.Top = Screen.PrimaryScreen.Bounds.Bottom - 100;
            this.Left = Screen.PrimaryScreen.Bounds.Left + 10;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            close.Start();
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            close.Start();
        }
        public enum AlertType
        {
            success, info, warning, error
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

        private void close_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fade_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
        }
    }
}
