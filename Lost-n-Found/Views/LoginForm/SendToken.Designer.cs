namespace Lost_n_Found.Views.LoginForm
{
    partial class SendToken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendToken));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnLogin);
            this.bunifuGradientPanel1.Controls.Add(this.txtEmail);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.LightSkyBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(427, 240);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 25);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(285, 28);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "Send token to Your Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtEmail.BorderThickness = 1;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(7, 94);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(406, 38);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.Tomato;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.Tomato;
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.ButtonText = "SEND";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnLogin.IdleForecolor = System.Drawing.Color.Tomato;
            this.btnLogin.IdleLineColor = System.Drawing.Color.Tomato;
            this.btnLogin.Location = new System.Drawing.Point(300, 168);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 46);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendToken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 240);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(443, 279);
            this.MinimumSize = new System.Drawing.Size(443, 279);
            this.Name = "SendToken";
            this.Text = "Reset your Password";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
    }
}