
namespace Tester
{
    partial class FrmHowToLogin
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1, 3);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(541, 29);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "How to login?";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 90);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(518, 226);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "(1). \r\n\r\n(2). \r\n\r\n(3). \r\n\r\n(4). ";
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(191, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 26);
            this.label3.TabIndex = 21;
            this.label3.Tag = "label";
            this.label3.Text = "Return to login page";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Tester.Properties.Resources.rainbow_bar;
            this.pictureBox5.Location = new System.Drawing.Point(-17, 25);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(497, 10);
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tester.Properties.Resources.rainbow_bar;
            this.pictureBox1.Location = new System.Drawing.Point(144, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 10);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHowToLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(542, 365);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHowToLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHowToLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}