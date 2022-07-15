using System.Drawing;

namespace Cookies_Loader_Base
{
    // Token: 0x02000002 RID: 2
    public partial class Register : global::System.Windows.Forms.Form
    {
        // Token: 0x06000011 RID: 17 RVA: 0x0000215C File Offset: 0x0000035C
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002194 File Offset: 0x00000394
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation3 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneTransition1 = new Siticone.UI.WinForms.SiticoneTransition();
            this.label1 = new System.Windows.Forms.Label();
            this.RgstrBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.status = new Siticone.UI.WinForms.SiticoneLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.key = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.LauncherTimer = new System.Windows.Forms.Timer(this.components);
            this.fadeintimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.panel3;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(318, 4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 1;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(272, 4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 2;
            this.siticoneControlBox2.Click += new System.EventHandler(this.siticoneControlBox2_Click);
            // 
            // siticoneTransition1
            // 
            this.siticoneTransition1.AnimationType = Siticone.UI.AnimatorNS.AnimationType.Rotate;
            this.siticoneTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(50);
            animation3.RotateCoeff = 1F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.siticoneTransition1.DefaultAnimation = animation3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // RgstrBtn
            // 
            this.RgstrBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.RgstrBtn.BorderThickness = 1;
            this.RgstrBtn.CheckedState.Parent = this.RgstrBtn;
            this.RgstrBtn.CustomImages.Parent = this.RgstrBtn;
            this.siticoneTransition1.SetDecoration(this.RgstrBtn, Siticone.UI.AnimatorNS.DecorationType.None);
            this.RgstrBtn.FillColor = System.Drawing.Color.Transparent;
            this.RgstrBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RgstrBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RgstrBtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.RgstrBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.RgstrBtn.HoveredState.Parent = this.RgstrBtn;
            this.RgstrBtn.Location = new System.Drawing.Point(67, 334);
            this.RgstrBtn.Name = "RgstrBtn";
            this.RgstrBtn.ShadowDecoration.Parent = this.RgstrBtn;
            this.RgstrBtn.Size = new System.Drawing.Size(236, 40);
            this.RgstrBtn.TabIndex = 35;
            this.RgstrBtn.Text = "Register";
            this.RgstrBtn.Click += new System.EventHandler(this.RgstrBtn_Click);
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.status, Siticone.UI.AnimatorNS.DecorationType.None);
            this.status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.status.Location = new System.Drawing.Point(0, 439);
            this.status.Margin = new System.Windows.Forms.Padding(2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(367, 47);
            this.status.TabIndex = 38;
            this.status.Text = "Status: Awaiting login";
            this.status.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(69, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label3.Location = new System.Drawing.Point(69, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label4.Location = new System.Drawing.Point(69, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Password";
            // 
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.username, Siticone.UI.AnimatorNS.DecorationType.None);
            this.username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Silver;
            this.username.HintForeColor = System.Drawing.Color.Silver;
            this.username.HintText = "";
            this.username.isPassword = false;
            this.username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.username.LineIdleColor = System.Drawing.Color.Gray;
            this.username.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.username.LineThickness = 2;
            this.username.Location = new System.Drawing.Point(69, 138);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(234, 30);
            this.username.TabIndex = 49;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.Enter += new System.EventHandler(this.username_Enter_1);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.password, Siticone.UI.AnimatorNS.DecorationType.None);
            this.password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Silver;
            this.password.HintForeColor = System.Drawing.Color.Silver;
            this.password.HintText = "";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.password.LineIdleColor = System.Drawing.Color.Gray;
            this.password.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.password.LineThickness = 2;
            this.password.Location = new System.Drawing.Point(69, 199);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(234, 30);
            this.password.TabIndex = 50;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // key
            // 
            this.key.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.key, Siticone.UI.AnimatorNS.DecorationType.None);
            this.key.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key.ForeColor = System.Drawing.Color.Silver;
            this.key.HintForeColor = System.Drawing.Color.Silver;
            this.key.HintText = "";
            this.key.isPassword = false;
            this.key.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.key.LineIdleColor = System.Drawing.Color.Gray;
            this.key.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.key.LineThickness = 2;
            this.key.Location = new System.Drawing.Point(69, 259);
            this.key.Margin = new System.Windows.Forms.Padding(4);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(234, 30);
            this.key.TabIndex = 51;
            this.key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key.Enter += new System.EventHandler(this.key_Enter);
            this.key.Leave += new System.EventHandler(this.key_Leave);
            // 
            // label5
            // 
            this.siticoneTransition1.SetDecoration(this.label5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label5.Location = new System.Drawing.Point(110, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Already have an account?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // LauncherTimer
            // 
            this.LauncherTimer.Tick += new System.EventHandler(this.LauncherTimer_Tick);
            // 
            // fadeintimer
            // 
            this.fadeintimer.Interval = 10;
            this.fadeintimer.Tick += new System.EventHandler(this.fadeintimer_Tick);
            // 
            // pictureBox11
            // 
            this.siticoneTransition1.SetDecoration(this.pictureBox11, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox11.Image = global::Cookies_Loader_Base.Properties.Resources.giphy__1_;
            this.pictureBox11.Location = new System.Drawing.Point(51, 4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(276, 151);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 57;
            this.pictureBox11.TabStop = false;
            // 
            // panel3
            // 
            this.siticoneTransition1.SetDecoration(this.panel3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(0, -5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 46);
            this.panel3.TabIndex = 60;
            // 
            // panel2
            // 
            this.siticoneTransition1.SetDecoration(this.panel2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(33, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(37, 100);
            this.panel2.TabIndex = 61;
            // 
            // panel1
            // 
            this.siticoneTransition1.SetDecoration(this.panel1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(302, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 100);
            this.panel1.TabIndex = 62;
            // 
            // Register
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(367, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.status);
            this.Controls.Add(this.RgstrBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.key);
            this.Controls.Add(this.pictureBox11);
            this.siticoneTransition1.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000004 RID: 4
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

        // Token: 0x04000005 RID: 5
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

        // Token: 0x04000009 RID: 9
        private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneRoundedButton RgstrBtn;
        private Siticone.UI.WinForms.SiticoneLabel status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox key;
        private System.Windows.Forms.Timer LauncherTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer fadeintimer;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
