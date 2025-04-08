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
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.backgroundpanel = new System.Windows.Forms.Panel();
            this.employeepanel = new System.Windows.Forms.Panel();
            this.employeeicon = new System.Windows.Forms.PictureBox();
            this.employeebtn = new System.Windows.Forms.Button();
            this.productpanel = new System.Windows.Forms.Panel();
            this.productbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.purchasepanel = new System.Windows.Forms.Panel();
            this.purchasebtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.salepanel = new System.Windows.Forms.Panel();
            this.salebtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.feedbackpanel = new System.Windows.Forms.Panel();
            this.feedbackbtn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.backgroundpanel.SuspendLayout();
            this.employeepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeicon)).BeginInit();
            this.productpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.purchasepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.salepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.feedbackpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.navigationPanel.Controls.Add(this.logoPictureBox);
            this.navigationPanel.Controls.Add(this.lblSystemName);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(800, 95);
            this.navigationPanel.TabIndex = 1;
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
            // 
            // backgroundpanel
            // 
            this.backgroundpanel.BackColor = System.Drawing.Color.DarkGray;
            this.backgroundpanel.Controls.Add(this.feedbackpanel);
            this.backgroundpanel.Controls.Add(this.salepanel);
            this.backgroundpanel.Controls.Add(this.purchasepanel);
            this.backgroundpanel.Controls.Add(this.productpanel);
            this.backgroundpanel.Controls.Add(this.employeepanel);
            this.backgroundpanel.ForeColor = System.Drawing.Color.Gainsboro;
            this.backgroundpanel.Location = new System.Drawing.Point(0, 101);
            this.backgroundpanel.Name = "backgroundpanel";
            this.backgroundpanel.Size = new System.Drawing.Size(800, 563);
            this.backgroundpanel.TabIndex = 2;
            this.backgroundpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // employeepanel
            // 
            this.employeepanel.BackColor = System.Drawing.Color.Gainsboro;
            this.employeepanel.Controls.Add(this.employeebtn);
            this.employeepanel.Controls.Add(this.employeeicon);
            this.employeepanel.Location = new System.Drawing.Point(27, 24);
            this.employeepanel.Name = "employeepanel";
            this.employeepanel.Size = new System.Drawing.Size(627, 90);
            this.employeepanel.TabIndex = 0;
            // 
            // employeeicon
            // 
            this.employeeicon.BackColor = System.Drawing.Color.Gainsboro;
            this.employeeicon.Image = ((System.Drawing.Image)(resources.GetObject("employeeicon.Image")));
            this.employeeicon.Location = new System.Drawing.Point(27, 3);
            this.employeeicon.Name = "employeeicon";
            this.employeeicon.Size = new System.Drawing.Size(87, 77);
            this.employeeicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeeicon.TabIndex = 0;
            this.employeeicon.TabStop = false;
            // 
            // employeebtn
            // 
            this.employeebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.employeebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.employeebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeebtn.ForeColor = System.Drawing.Color.Black;
            this.employeebtn.Location = new System.Drawing.Point(159, 29);
            this.employeebtn.Name = "employeebtn";
            this.employeebtn.Size = new System.Drawing.Size(143, 40);
            this.employeebtn.TabIndex = 1;
            this.employeebtn.Text = "Employee";
            this.employeebtn.UseVisualStyleBackColor = true;
            this.employeebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // productpanel
            // 
            this.productpanel.BackColor = System.Drawing.Color.Gainsboro;
            this.productpanel.Controls.Add(this.productbtn);
            this.productpanel.Controls.Add(this.pictureBox1);
            this.productpanel.Location = new System.Drawing.Point(27, 120);
            this.productpanel.Name = "productpanel";
            this.productpanel.Size = new System.Drawing.Size(627, 90);
            this.productpanel.TabIndex = 1;
            // 
            // productbtn
            // 
            this.productbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.productbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productbtn.ForeColor = System.Drawing.Color.Black;
            this.productbtn.Location = new System.Drawing.Point(159, 29);
            this.productbtn.Name = "productbtn";
            this.productbtn.Size = new System.Drawing.Size(143, 36);
            this.productbtn.TabIndex = 1;
            this.productbtn.Text = "Product";
            this.productbtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // purchasepanel
            // 
            this.purchasepanel.BackColor = System.Drawing.Color.Gainsboro;
            this.purchasepanel.Controls.Add(this.purchasebtn);
            this.purchasepanel.Controls.Add(this.pictureBox2);
            this.purchasepanel.Location = new System.Drawing.Point(27, 216);
            this.purchasepanel.Name = "purchasepanel";
            this.purchasepanel.Size = new System.Drawing.Size(627, 90);
            this.purchasepanel.TabIndex = 2;
            this.purchasepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // purchasebtn
            // 
            this.purchasebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.purchasebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasebtn.ForeColor = System.Drawing.Color.Black;
            this.purchasebtn.Location = new System.Drawing.Point(159, 29);
            this.purchasebtn.Name = "purchasebtn";
            this.purchasebtn.Size = new System.Drawing.Size(143, 30);
            this.purchasebtn.TabIndex = 1;
            this.purchasebtn.Text = "Purchase";
            this.purchasebtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // salepanel
            // 
            this.salepanel.BackColor = System.Drawing.Color.Gainsboro;
            this.salepanel.Controls.Add(this.salebtn);
            this.salepanel.Controls.Add(this.pictureBox3);
            this.salepanel.Location = new System.Drawing.Point(27, 312);
            this.salepanel.Name = "salepanel";
            this.salepanel.Size = new System.Drawing.Size(627, 100);
            this.salepanel.TabIndex = 3;
            // 
            // salebtn
            // 
            this.salebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salebtn.ForeColor = System.Drawing.Color.Black;
            this.salebtn.Location = new System.Drawing.Point(159, 31);
            this.salebtn.Name = "salebtn";
            this.salebtn.Size = new System.Drawing.Size(143, 30);
            this.salebtn.TabIndex = 1;
            this.salebtn.Text = "Sale";
            this.salebtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(27, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // feedbackpanel
            // 
            this.feedbackpanel.BackColor = System.Drawing.Color.Gainsboro;
            this.feedbackpanel.Controls.Add(this.feedbackbtn);
            this.feedbackpanel.Controls.Add(this.pictureBox4);
            this.feedbackpanel.Location = new System.Drawing.Point(27, 418);
            this.feedbackpanel.Name = "feedbackpanel";
            this.feedbackpanel.Size = new System.Drawing.Size(627, 90);
            this.feedbackpanel.TabIndex = 4;
            // 
            // feedbackbtn
            // 
            this.feedbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feedbackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackbtn.ForeColor = System.Drawing.Color.Black;
            this.feedbackbtn.Location = new System.Drawing.Point(159, 29);
            this.feedbackbtn.Name = "feedbackbtn";
            this.feedbackbtn.Size = new System.Drawing.Size(148, 29);
            this.feedbackbtn.TabIndex = 1;
            this.feedbackbtn.Text = "Feedback";
            this.feedbackbtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(27, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(87, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.backgroundpanel);
            this.Controls.Add(this.navigationPanel);
            this.Name = "Main";
            this.Text = "Form3";
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.backgroundpanel.ResumeLayout(false);
            this.employeepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeicon)).EndInit();
            this.productpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.purchasepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.salepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.feedbackpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Panel backgroundpanel;
        private System.Windows.Forms.Panel employeepanel;
        private System.Windows.Forms.Button employeebtn;
        private System.Windows.Forms.PictureBox employeeicon;
        private System.Windows.Forms.Panel productpanel;
        private System.Windows.Forms.Button productbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel purchasepanel;
        private System.Windows.Forms.Button purchasebtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel feedbackpanel;
        private System.Windows.Forms.Button feedbackbtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel salepanel;
        private System.Windows.Forms.Button salebtn;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}