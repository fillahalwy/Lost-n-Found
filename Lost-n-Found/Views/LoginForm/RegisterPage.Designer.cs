namespace Lost_n_Found.Views.LoginForm
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.registerPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.registerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerPanel
            // 
            this.registerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registerPanel.BackgroundImage")));
            this.registerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registerPanel.Controls.Add(this.bunifuTextbox1);
            this.registerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerPanel.GradientBottomLeft = System.Drawing.Color.LightSkyBlue;
            this.registerPanel.GradientBottomRight = System.Drawing.Color.Cyan;
            this.registerPanel.GradientTopLeft = System.Drawing.Color.LightCyan;
            this.registerPanel.GradientTopRight = System.Drawing.Color.CornflowerBlue;
            this.registerPanel.Location = new System.Drawing.Point(0, 0);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Quality = 10;
            this.registerPanel.Size = new System.Drawing.Size(1264, 681);
            this.registerPanel.TabIndex = 0;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(330, 129);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(500, 42);
            this.bunifuTextbox1.TabIndex = 0;
            this.bunifuTextbox1.text = "Bunifu TextBox";
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.registerPanel);
            this.Name = "RegisterPage";
            this.Size = new System.Drawing.Size(1264, 681);
            this.registerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel registerPanel;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
    }
}
