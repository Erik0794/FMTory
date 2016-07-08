namespace FMTory
{
    partial class LoginSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSplash));
            this.ID = new System.Windows.Forms.Label();
            this.userinputid = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.userinputpwd = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.helpbutton = new System.Windows.Forms.Button();
            this.logobox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(47, 12);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            // 
            // userinputid
            // 
            this.userinputid.Location = new System.Drawing.Point(64, 9);
            this.userinputid.MaxLength = 64;
            this.userinputid.Name = "userinputid";
            this.userinputid.Size = new System.Drawing.Size(200, 20);
            this.userinputid.TabIndex = 2;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(12, 45);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            // 
            // userinputpwd
            // 
            this.userinputpwd.Location = new System.Drawing.Point(64, 42);
            this.userinputpwd.MaxLength = 64;
            this.userinputpwd.Name = "userinputpwd";
            this.userinputpwd.PasswordChar = 'x';
            this.userinputpwd.Size = new System.Drawing.Size(200, 20);
            this.userinputpwd.TabIndex = 4;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(285, 9);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 23);
            this.loginbutton.TabIndex = 5;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(285, 40);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 6;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            // 
            // helpbutton
            // 
            this.helpbutton.Location = new System.Drawing.Point(337, 88);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.Size = new System.Drawing.Size(23, 23);
            this.helpbutton.TabIndex = 7;
            this.helpbutton.Text = "?";
            this.helpbutton.UseVisualStyleBackColor = true;
            // 
            // logobox
            // 
            this.logobox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logobox.ErrorImage = global::FMTory.Properties.Resources.FMTory_Cut;
            this.logobox.Image = global::FMTory.Properties.Resources.FMTory_Gradient;
            this.logobox.InitialImage = global::FMTory.Properties.Resources.FMTory_Cut;
            this.logobox.Location = new System.Drawing.Point(0, 80);
            this.logobox.Name = "logobox";
            this.logobox.Size = new System.Drawing.Size(300, 40);
            this.logobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logobox.TabIndex = 0;
            this.logobox.TabStop = false;
            // 
            // LoginSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 123);
            this.Controls.Add(this.helpbutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.userinputpwd);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userinputid);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.logobox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginSplash";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FMTory Login Screen";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logobox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox userinputid;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox userinputpwd;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button helpbutton;
    }
}

