
namespace Cookies_Loader_Base
{
    partial class alert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alert));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.icon = new System.Windows.Forms.PictureBox();
            this.timeout = new System.Windows.Forms.Timer(this.components);
            this.show = new System.Windows.Forms.Timer(this.components);
            this.close = new System.Windows.Forms.Timer(this.components);
            this.fade = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "check-mark.png");
            this.imageList1.Images.SetKeyName(1, "info.png");
            this.imageList1.Images.SetKeyName(2, "warn.png");
            this.imageList1.Images.SetKeyName(3, "error.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Success Message";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = global::Cookies_Loader_Base.Properties.Resources.close_button;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(389, 6);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(15, 15);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(12, 12);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(54, 70);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // timeout
            // 
            this.timeout.Enabled = true;
            this.timeout.Interval = 5000;
            this.timeout.Tick += new System.EventHandler(this.timeout_Tick);
            // 
            // show
            // 
            this.show.Tick += new System.EventHandler(this.show_Tick);
            // 
            // close
            // 
            this.close.Interval = 10;
            this.close.Tick += new System.EventHandler(this.close_Tick);
            // 
            // fade
            // 
            this.fade.Interval = 10;
            this.fade.Tick += new System.EventHandler(this.fade_Tick);
            // 
            // alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(411, 94);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.icon);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "alert";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGINAlert";
            this.Load += new System.EventHandler(this.alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Timer timeout;
        private System.Windows.Forms.Timer show;
        private System.Windows.Forms.Timer close;
        private System.Windows.Forms.Timer fade;
    }
}