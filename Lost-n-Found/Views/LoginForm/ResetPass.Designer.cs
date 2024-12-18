namespace Lost_n_Found.Views.LoginForm
{
    partial class ResetPass
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPass));
            this.ResetPassPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.resetTokenCard = new Bunifu.Framework.UI.BunifuCards();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtToken = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.btnReset = new Bunifu.Framework.UI.BunifuThinButton2();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ResetPassPanel.SuspendLayout();
            this.resetTokenCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResetPassPanel
            // 
            this.ResetPassPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetPassPanel.BackgroundImage")));
            this.ResetPassPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetPassPanel.Controls.Add(this.resetTokenCard);
            this.ResetPassPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetPassPanel.GradientBottomLeft = System.Drawing.Color.LightSkyBlue;
            this.ResetPassPanel.GradientBottomRight = System.Drawing.Color.Cyan;
            this.ResetPassPanel.GradientTopLeft = System.Drawing.Color.LightCyan;
            this.ResetPassPanel.GradientTopRight = System.Drawing.Color.CornflowerBlue;
            this.ResetPassPanel.Location = new System.Drawing.Point(0, 0);
            this.ResetPassPanel.Name = "ResetPassPanel";
            this.ResetPassPanel.Quality = 10;
            this.ResetPassPanel.Size = new System.Drawing.Size(1264, 681);
            this.ResetPassPanel.TabIndex = 0;
            // 
            // resetTokenCard
            // 
            this.resetTokenCard.BackColor = System.Drawing.Color.White;
            this.resetTokenCard.BorderRadius = 20;
            this.resetTokenCard.BottomSahddow = true;
            this.resetTokenCard.color = System.Drawing.Color.White;
            this.resetTokenCard.Controls.Add(this.btnCancel);
            this.resetTokenCard.Controls.Add(this.btnReset);
            this.resetTokenCard.Controls.Add(this.txtPassword);
            this.resetTokenCard.Controls.Add(this.txtToken);
            this.resetTokenCard.Controls.Add(this.txtEmail);
            this.resetTokenCard.Controls.Add(this.linkLogin);
            this.resetTokenCard.Controls.Add(this.bunifuCustomLabel16);
            this.resetTokenCard.Controls.Add(this.bunifuCustomLabel12);
            this.resetTokenCard.Controls.Add(this.bunifuCustomLabel10);
            this.resetTokenCard.Controls.Add(this.bunifuCustomLabel9);
            this.resetTokenCard.Controls.Add(this.bunifuCustomLabel1);
            this.resetTokenCard.Controls.Add(this.bunifuCustomLabel2);
            this.resetTokenCard.Controls.Add(this.bunifuCustomLabel3);
            this.resetTokenCard.Controls.Add(this.bunifuCustomLabel5);
            this.resetTokenCard.LeftSahddow = false;
            this.resetTokenCard.Location = new System.Drawing.Point(367, 63);
            this.resetTokenCard.Name = "resetTokenCard";
            this.resetTokenCard.RightSahddow = true;
            this.resetTokenCard.ShadowDepth = 20;
            this.resetTokenCard.Size = new System.Drawing.Size(558, 560);
            this.resetTokenCard.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(41, 310);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Radius = 5;
            this.txtPassword.Size = new System.Drawing.Size(480, 32);
            this.txtPassword.TabIndex = 31;
            // 
            // txtToken
            // 
            this.txtToken.BaseColor = System.Drawing.Color.White;
            this.txtToken.BorderColor = System.Drawing.Color.Black;
            this.txtToken.BorderSize = 1;
            this.txtToken.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtToken.FocusedBaseColor = System.Drawing.Color.White;
            this.txtToken.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtToken.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtToken.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtToken.Location = new System.Drawing.Point(41, 214);
            this.txtToken.Name = "txtToken";
            this.txtToken.PasswordChar = '\0';
            this.txtToken.Radius = 5;
            this.txtToken.Size = new System.Drawing.Size(480, 32);
            this.txtToken.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Black;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(41, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 5;
            this.txtEmail.Size = new System.Drawing.Size(480, 32);
            this.txtEmail.TabIndex = 28;
            // 
            // btnReset
            // 
            this.btnReset.ActiveBorderThickness = 1;
            this.btnReset.ActiveCornerRadius = 20;
            this.btnReset.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnReset.ActiveForecolor = System.Drawing.Color.White;
            this.btnReset.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.ButtonText = "Reset";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.IdleBorderThickness = 1;
            this.btnReset.IdleCornerRadius = 20;
            this.btnReset.IdleFillColor = System.Drawing.Color.White;
            this.btnReset.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnReset.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnReset.Location = new System.Drawing.Point(413, 404);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 48);
            this.btnReset.TabIndex = 27;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.linkLogin.Location = new System.Drawing.Point(182, 358);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(44, 19);
            this.linkLogin.TabIndex = 24;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Login";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(37, 358);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(149, 19);
            this.bunifuCustomLabel16.TabIndex = 25;
            this.bunifuCustomLabel16.Text = "Already have account?";
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(318, 404);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 48);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(152, 279);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(18, 28);
            this.bunifuCustomLabel12.TabIndex = 18;
            this.bunifuCustomLabel12.Text = ":";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(152, 183);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(18, 28);
            this.bunifuCustomLabel10.TabIndex = 16;
            this.bunifuCustomLabel10.Text = ":";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(156, 88);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(18, 28);
            this.bunifuCustomLabel9.TabIndex = 15;
            this.bunifuCustomLabel9.Text = ":";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(150, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(248, 41);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Reset Password";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(40, 88);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(64, 28);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Email";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(36, 183);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(68, 28);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Token";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(36, 279);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(101, 28);
            this.bunifuCustomLabel5.TabIndex = 6;
            this.bunifuCustomLabel5.Text = "Password";
            // 
            // ResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResetPassPanel);
            this.Name = "ResetPass";
            this.Size = new System.Drawing.Size(1264, 681);
            this.Load += new System.EventHandler(this.ResetPass_Load);
            this.ResetPassPanel.ResumeLayout(false);
            this.resetTokenCard.ResumeLayout(false);
            this.resetTokenCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel ResetPassPanel;
        private Bunifu.Framework.UI.BunifuCards resetTokenCard;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtToken;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReset;
        private System.Windows.Forms.LinkLabel linkLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
    }
}
