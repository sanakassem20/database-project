using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FashionBoutiqueLogin
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.backIconPictureBox = new System.Windows.Forms.PictureBox();
            this.lblSystemName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usernameIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(61, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 23);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(65, 101);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 23);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.Location = new System.Drawing.Point(160, 48);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 27);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(160, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.HotPink;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(134, 157);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 35);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(150, 195);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 5;
            // 
            // usernameIconPictureBox
            // 
            this.usernameIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("usernameIconPictureBox.Image")));
            this.usernameIconPictureBox.Location = new System.Drawing.Point(28, 50);
            this.usernameIconPictureBox.Name = "usernameIconPictureBox";
            this.usernameIconPictureBox.Size = new System.Drawing.Size(25, 25);
            this.usernameIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usernameIconPictureBox.TabIndex = 6;
            this.usernameIconPictureBox.TabStop = false;
            // 
            // passwordIconPictureBox
            // 
            this.passwordIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("passwordIconPictureBox.Image")));
            this.passwordIconPictureBox.Location = new System.Drawing.Point(28, 97);
            this.passwordIconPictureBox.Name = "passwordIconPictureBox";
            this.passwordIconPictureBox.Size = new System.Drawing.Size(25, 25);
            this.passwordIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordIconPictureBox.TabIndex = 7;
            this.passwordIconPictureBox.TabStop = false;
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundPictureBox.BackgroundImage")));
            this.backgroundPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPictureBox.Location = new System.Drawing.Point(0, 0);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(837, 856);
            this.backgroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backgroundPictureBox.TabIndex = 2;
            this.backgroundPictureBox.TabStop = false;
            this.backgroundPictureBox.UseWaitCursor = true;
            this.backgroundPictureBox.Click += new System.EventHandler(this.backgroundPictureBox_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.loginPanel.Controls.Add(this.lblUsername);
            this.loginPanel.Controls.Add(this.lblPassword);
            this.loginPanel.Controls.Add(this.txtUsername);
            this.loginPanel.Controls.Add(this.txtPassword);
            this.loginPanel.Controls.Add(this.chkShowPassword);
            this.loginPanel.Controls.Add(this.btnLogin);
            this.loginPanel.Controls.Add(this.lblMessage);
            this.loginPanel.Controls.Add(this.usernameIconPictureBox);
            this.loginPanel.Controls.Add(this.passwordIconPictureBox);
            this.loginPanel.Location = new System.Drawing.Point(232, 324);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(387, 227);
            this.loginPanel.TabIndex = 1;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowPassword.Location = new System.Drawing.Point(160, 130);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(132, 24);
            this.chkShowPassword.TabIndex = 8;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.logoPictureBox);
            this.panel1.Controls.Add(this.backIconPictureBox);
            this.panel1.Controls.Add(this.lblSystemName);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 130);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(12, 21);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(129, 101);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 3;
            this.logoPictureBox.TabStop = false;
            // 
            // backIconPictureBox
            // 
            this.backIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("backIconPictureBox.Image")));
            this.backIconPictureBox.Location = new System.Drawing.Point(760, 30);
            this.backIconPictureBox.Name = "backIconPictureBox";
            this.backIconPictureBox.Size = new System.Drawing.Size(40, 40);
            this.backIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backIconPictureBox.TabIndex = 2;
            this.backIconPictureBox.TabStop = false;
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Castellar", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSystemName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSystemName.Location = new System.Drawing.Point(157, 48);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(288, 36);
            this.lblSystemName.TabIndex = 1;
            this.lblSystemName.Text = "GLAMVENTORY";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 856);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.backgroundPictureBox);
            this.Name = "Login";
            this.Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.usernameIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backIconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel panel1;
        private PictureBox backIconPictureBox;
        private Label lblSystemName;
        private PictureBox logoPictureBox;
    }
}