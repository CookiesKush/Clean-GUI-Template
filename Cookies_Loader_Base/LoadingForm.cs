using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;

namespace Cookies_Loader_Base
{
    public partial class LoadingForm : Form
    {
        // Rain
        int[] rainSpeeds = { 4, 6, 8, 3, 5, 6, 7, 4 };
        int loadingSpeed = 5;
        float initialPercentage = 0;

        // Animated Text
        int counter = 0;
        int len = 0;
        string text;

        #region dll Imports
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                int left,
                int top,
                int right,
                int bottom,
                int width,
                int height
            );
        #endregion

        public LoadingForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7)); // Rounds form
        }

        #region Form Load
        private void LoadingForm_Load(object sender, EventArgs e)
        {
            #region Start Fade In
            this.Opacity = 0;
            fadeintimer.Start();
            #endregion

            #region Start Animations
            //Start rain
            timer1.Start();
            timer2.Start();

            // Start text
            text = label2.Text;
            len = text.Length;
            label2.Text = "";
            timer3.Start();
            #endregion
        }
        #endregion

        #region Single Rain Animation
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        //animation for rain 1
                        pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + rainSpeeds[i]);
                        if (pictureBox3.Location.Y > panel1.Size.Height + pictureBox3.Size.Height)
                        {
                            pictureBox3.Location = new Point(pictureBox3.Location.X, 0 - pictureBox3.Size.Height);
                        }
                        break;
                    case 1:
                        //animation for rain 2
                        pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + rainSpeeds[i]);
                        if (pictureBox4.Location.Y > panel1.Size.Height + pictureBox4.Size.Height)
                        {
                            pictureBox4.Location = new Point(pictureBox4.Location.X, 0 - pictureBox4.Size.Height);
                        }
                        break;
                    case 2:
                        //animation for rain 3
                        pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + rainSpeeds[i]);
                        if (pictureBox5.Location.Y > panel1.Size.Height + pictureBox5.Size.Height)
                        {
                            pictureBox5.Location = new Point(pictureBox5.Location.X, 0 - pictureBox5.Size.Height);
                        }
                        break;
                    case 3:
                        //animation for rain 4
                        pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + rainSpeeds[i]);
                        if (pictureBox6.Location.Y > panel1.Size.Height + pictureBox6.Size.Height)
                        {
                            pictureBox6.Location = new Point(pictureBox6.Location.X, 0 - pictureBox6.Size.Height);
                        }
                        break;
                    case 4:
                        //animation for rain 5
                        pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y + rainSpeeds[i]);
                        if (pictureBox7.Location.Y > panel1.Size.Height + pictureBox7.Size.Height)
                        {
                            pictureBox7.Location = new Point(pictureBox7.Location.X, 0 - pictureBox7.Size.Height);
                        }
                        break;
                    case 5:
                        //animation for rain 6
                        pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y + rainSpeeds[i]);
                        if (pictureBox8.Location.Y > panel1.Size.Height + pictureBox8.Size.Height)
                        {
                            pictureBox8.Location = new Point(pictureBox8.Location.X, 0 - pictureBox8.Size.Height);
                        }
                        break;
                    case 6:
                        //animation for rain 7
                        pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y + rainSpeeds[i]);
                        if (pictureBox9.Location.Y > panel1.Size.Height + pictureBox9.Size.Height)
                        {
                            pictureBox9.Location = new Point(pictureBox9.Location.X, 0 - pictureBox9.Size.Height);
                        }
                        break;
                    case 7:
                        //animation for rain 8
                        pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y + rainSpeeds[i]);
                        if (pictureBox10.Location.Y > panel1.Size.Height + pictureBox10.Size.Height)
                        {
                            pictureBox10.Location = new Point(pictureBox10.Location.X, 0 - pictureBox10.Size.Height);
                        }
                        break;
                }
            }
            
        }
        #endregion
         
        #region Rain Puddle Animation
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            initialPercentage += loadingSpeed;
            float percentage = initialPercentage / pictureBox2.Height * 100;

            label1.Text = (int)percentage + " %";

            panel2.Location = new Point(panel2.Location.X, panel2.Location.Y + loadingSpeed);
            if (panel2.Location.Y > pictureBox2.Location.Y + pictureBox2.Height)
            {
                label1.Text = "100 %";
                this.timer2.Stop();

                if (Properties.Settings.Default.Account_Created == true)
                {
                    this.Hide();
                    var form1 = new Login();
                    form1.Closed += (s, args) => this.Close();
                    form1.Show();
                }
                else
                {
                    this.Hide();
                    var form1 = new Register();
                    form1.Closed += (s, args) => this.Close();
                    form1.Show();
                }
            }
        }
        #endregion

        #region Animated Text
        void resetTimer1()
        {
            counter = 0;
            len = 0;
            label2.Text = "Hooking. . .";
            text = label2.Text;
            len = text.Length;
            label2.Text = "";
            timer4.Start();
        }

        void resetTimer2()
        {
            counter = 0;
            len = 0;
            label2.Text = "Installing Modules. . .";
            text = label2.Text;
            len = text.Length;
            label2.Text = "";
            timer5.Start();
        }

        void resetTimer3()
        {
            counter = 0;
            len = 0;
            label2.Text = "Seaching for funny. . .";
            text = label2.Text;
            len = text.Length;
            label2.Text = "";
            timer6.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label2.Text = text.Substring(0, counter);
            ++counter;
            if (counter > len)
            {
                timer3.Stop();
                resetTimer1();

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label2.Text = text.Substring(0, counter);
            ++counter;
            if (counter > len)
            {
                timer4.Stop();
                resetTimer2();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label2.Text = text.Substring(0, counter);
            ++counter;
            if (counter > len)
            {
                timer5.Stop();
                resetTimer3();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            label2.Text = text.Substring(0, counter);
            ++counter;
            if (counter > len)
            {
                timer6.Stop();
            }
        }
        #endregion

        private void fadeintimer_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.05;
        }
    }
}
