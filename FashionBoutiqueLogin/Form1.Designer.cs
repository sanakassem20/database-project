using System.Windows.Forms;

namespace FashionBoutiqueLogin
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox backgroundPictureBox;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.PictureBox usernameIconPictureBox;
        private System.Windows.Forms.PictureBox passwordIconPictureBox;
        private System.Windows.Forms.CheckBox chkShowPassword;




        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.usernameIconPictureBox = new System.Windows.Forms.PictureBox();
            this.passwordIconPictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblSystemName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usernameIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(62, 53);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 19);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(63, 103);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 19);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(160, 53);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 22);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(160, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.HotPink;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(134, 157);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(150, 190);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 5;
            // 
            // usernameIconPictureBox
            // 
            this.usernameIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("usernameIconPictureBox.Image")));
            this.usernameIconPictureBox.Location = new System.Drawing.Point(40, 50);
            this.usernameIconPictureBox.Name = "usernameIconPictureBox";
            this.usernameIconPictureBox.Size = new System.Drawing.Size(25, 22);
            this.usernameIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usernameIconPictureBox.TabIndex = 6;
            this.usernameIconPictureBox.TabStop = false;
            // 
            // passwordIconPictureBox
            // 
            this.passwordIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("passwordIconPictureBox.Image")));
            this.passwordIconPictureBox.Location = new System.Drawing.Point(40, 97);
            this.passwordIconPictureBox.Name = "passwordIconPictureBox";
            this.passwordIconPictureBox.Size = new System.Drawing.Size(25, 25);
            this.passwordIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordIconPictureBox.TabIndex = 7;
            this.passwordIconPictureBox.TabStop = false;
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("backgroundPictureBox.Image")));
            this.backgroundPictureBox.Location = new System.Drawing.Point(0, 0);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(838, 856);
            this.backgroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundPictureBox.TabIndex = 2;
            this.backgroundPictureBox.TabStop = false;
            this.backgroundPictureBox.Click += new System.EventHandler(this.backgroundPictureBox_Click_1);
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginPanel.Controls.Add(this.lblUsername);
            this.loginPanel.Controls.Add(this.lblPassword);
            this.loginPanel.Controls.Add(this.txtUsername);
            this.loginPanel.Controls.Add(this.txtPassword);
            this.loginPanel.Controls.Add(this.chkShowPassword);
            this.loginPanel.Controls.Add(this.btnLogin);
            this.loginPanel.Controls.Add(this.lblMessage);
            this.loginPanel.Controls.Add(this.usernameIconPictureBox);
            this.loginPanel.Controls.Add(this.passwordIconPictureBox);
            this.loginPanel.Location = new System.Drawing.Point(225, 324);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(398, 211);
            this.loginPanel.TabIndex = 1;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Arial", 9F);
            this.chkShowPassword.Location = new System.Drawing.Point(223, 130);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(137, 21);
            this.chkShowPassword.TabIndex = 8;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.navigationPanel.Controls.Add(this.logoPictureBox);
            this.navigationPanel.Controls.Add(this.lblSystemName);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(838, 95);
            this.navigationPanel.TabIndex = 0;
            this.navigationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.navigationPanel_Paint);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(12, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(129, 101);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click);
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Castellar", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Location = new System.Drawing.Point(190, 30);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(288, 36);
            this.lblSystemName.TabIndex = 1;
            this.lblSystemName.Text = "GLAMVENTORY";
            this.lblSystemName.Click += new System.EventHandler(this.lblSystemName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 856);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.backgroundPictureBox);
            this.Name = "Form1";
            this.Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.usernameIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

    }
}
