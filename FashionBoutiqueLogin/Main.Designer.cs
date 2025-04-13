namespace FashionBoutiqueLogin
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.backIconPictureBox = new System.Windows.Forms.PictureBox();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.backgroundpanel = new System.Windows.Forms.Panel();
            this.feedbackpanel = new System.Windows.Forms.Panel();
            this.feedbackbtn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.purchasepanel = new System.Windows.Forms.Panel();
            this.purchasebtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.productpanel = new System.Windows.Forms.Panel();
            this.ProductBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.employeepanel = new System.Windows.Forms.Panel();
            this.employeebtn = new System.Windows.Forms.Button();
            this.employeeicon = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backIconPictureBox)).BeginInit();
            this.backgroundpanel.SuspendLayout();
            this.feedbackpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.purchasepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.productpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.employeepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.navigationPanel.Controls.Add(this.logoPictureBox);
            this.navigationPanel.Controls.Add(this.pictureBox3);
            this.navigationPanel.Controls.Add(this.backIconPictureBox);
            this.navigationPanel.Controls.Add(this.lblSystemName);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(689, 100);
            this.navigationPanel.TabIndex = 1;
            // 
            // backIconPictureBox
            // 
            this.backIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("backIconPictureBox.Image")));
            this.backIconPictureBox.Location = new System.Drawing.Point(740, 30);
            this.backIconPictureBox.Name = "backIconPictureBox";
            this.backIconPictureBox.Size = new System.Drawing.Size(40, 40);
            this.backIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backIconPictureBox.TabIndex = 3;
            this.backIconPictureBox.TabStop = false;
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Castellar", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSystemName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSystemName.Location = new System.Drawing.Point(138, 29);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(261, 33);
            this.lblSystemName.TabIndex = 1;
            this.lblSystemName.Text = "GLAMVENTORY";
            // 
            // backgroundpanel
            // 
            this.backgroundpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.backgroundpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backgroundpanel.Controls.Add(this.feedbackpanel);
            this.backgroundpanel.Controls.Add(this.purchasepanel);
            this.backgroundpanel.Controls.Add(this.productpanel);
            this.backgroundpanel.Controls.Add(this.employeepanel);
            this.backgroundpanel.Location = new System.Drawing.Point(0, 101);
            this.backgroundpanel.Name = "backgroundpanel";
            this.backgroundpanel.Size = new System.Drawing.Size(800, 523);
            this.backgroundpanel.TabIndex = 2;
            // 
            // feedbackpanel
            // 
            this.feedbackpanel.BackColor = System.Drawing.Color.White;
            this.feedbackpanel.Controls.Add(this.feedbackbtn);
            this.feedbackpanel.Controls.Add(this.pictureBox4);
            this.feedbackpanel.Location = new System.Drawing.Point(50, 370);
            this.feedbackpanel.Name = "feedbackpanel";
            this.feedbackpanel.Size = new System.Drawing.Size(700, 90);
            this.feedbackpanel.TabIndex = 3;
            // 
            // feedbackbtn
            // 
            this.feedbackbtn.BackColor = System.Drawing.Color.White;
            this.feedbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedbackbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.feedbackbtn.ForeColor = System.Drawing.Color.Black;
            this.feedbackbtn.Location = new System.Drawing.Point(150, 25);
            this.feedbackbtn.Name = "feedbackbtn";
            this.feedbackbtn.Size = new System.Drawing.Size(150, 40);
            this.feedbackbtn.TabIndex = 0;
            this.feedbackbtn.Text = "Feedback";
            this.feedbackbtn.UseVisualStyleBackColor = true;
            this.feedbackbtn.Click += new System.EventHandler(this.feedbackbtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(25, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // purchasepanel
            // 
            this.purchasepanel.BackColor = System.Drawing.Color.White;
            this.purchasepanel.Controls.Add(this.purchasebtn);
            this.purchasepanel.Controls.Add(this.pictureBox2);
            this.purchasepanel.Location = new System.Drawing.Point(50, 255);
            this.purchasepanel.Name = "purchasepanel";
            this.purchasepanel.Size = new System.Drawing.Size(700, 90);
            this.purchasepanel.TabIndex = 2;
            // 
            // purchasebtn
            // 
            this.purchasebtn.BackColor = System.Drawing.Color.White;
            this.purchasebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchasebtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.purchasebtn.ForeColor = System.Drawing.Color.Black;
            this.purchasebtn.Location = new System.Drawing.Point(150, 25);
            this.purchasebtn.Name = "purchasebtn";
            this.purchasebtn.Size = new System.Drawing.Size(150, 40);
            this.purchasebtn.TabIndex = 0;
            this.purchasebtn.Text = "Purchase";
            this.purchasebtn.UseVisualStyleBackColor = true;
            this.purchasebtn.Click += new System.EventHandler(this.purchasebtn_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // productpanel
            // 
            this.productpanel.BackColor = System.Drawing.Color.White;
            this.productpanel.Controls.Add(this.ProductBtn);
            this.productpanel.Controls.Add(this.pictureBox1);
            this.productpanel.Location = new System.Drawing.Point(50, 140);
            this.productpanel.Name = "productpanel";
            this.productpanel.Size = new System.Drawing.Size(700, 90);
            this.productpanel.TabIndex = 1;
            // 
            // ProductBtn
            // 
            this.ProductBtn.BackColor = System.Drawing.Color.White;
            this.ProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProductBtn.ForeColor = System.Drawing.Color.Black;
            this.ProductBtn.Location = new System.Drawing.Point(150, 25);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(150, 40);
            this.ProductBtn.TabIndex = 0;
            this.ProductBtn.Text = "Product";
            this.ProductBtn.UseVisualStyleBackColor = true;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // employeepanel
            // 
            this.employeepanel.BackColor = System.Drawing.Color.White;
            this.employeepanel.Controls.Add(this.employeebtn);
            this.employeepanel.Controls.Add(this.employeeicon);
            this.employeepanel.Location = new System.Drawing.Point(50, 25);
            this.employeepanel.Name = "employeepanel";
            this.employeepanel.Size = new System.Drawing.Size(700, 90);
            this.employeepanel.TabIndex = 0;
            // 
            // employeebtn
            // 
            this.employeebtn.BackColor = System.Drawing.Color.White;
            this.employeebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeebtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.employeebtn.ForeColor = System.Drawing.Color.Black;
            this.employeebtn.Location = new System.Drawing.Point(150, 25);
            this.employeebtn.Name = "employeebtn";
            this.employeebtn.Size = new System.Drawing.Size(150, 40);
            this.employeebtn.TabIndex = 0;
            this.employeebtn.Text = "Employee";
            this.employeebtn.UseVisualStyleBackColor = true;
            this.employeebtn.Click += new System.EventHandler(this.employeebtn_Click_1);
            // 
            // employeeicon
            // 
            this.employeeicon.Image = ((System.Drawing.Image)(resources.GetObject("employeeicon.Image")));
            this.employeeicon.Location = new System.Drawing.Point(25, 10);
            this.employeeicon.Name = "employeeicon";
            this.employeeicon.Size = new System.Drawing.Size(70, 70);
            this.employeeicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeeicon.TabIndex = 0;
            this.employeeicon.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(630, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, -4);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(129, 101);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 5;
            this.logoPictureBox.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 894);
            this.Controls.Add(this.backgroundpanel);
            this.Controls.Add(this.navigationPanel);
            this.Name = "Main";
            this.Text = "GLAMVENTORY - Main Menu";
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backIconPictureBox)).EndInit();
            this.backgroundpanel.ResumeLayout(false);
            this.feedbackpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.purchasepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.productpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.employeepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        private void newSystem(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Panel backgroundpanel;
        private System.Windows.Forms.Panel employeepanel;
        private System.Windows.Forms.Button employeebtn;
        private System.Windows.Forms.PictureBox employeeicon;
        private System.Windows.Forms.Panel productpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel purchasepanel;
        private System.Windows.Forms.Button purchasebtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel feedbackpanel;
        private System.Windows.Forms.Button feedbackbtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button ProductBtn;
        private System.Windows.Forms.PictureBox backIconPictureBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}