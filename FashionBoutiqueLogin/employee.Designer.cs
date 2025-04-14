using System;
using System.Windows.Forms;

namespace FashionBoutiqueLogin
{
    partial class Employee
    {
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.backgroundpanel = new System.Windows.Forms.Panel();
            this.updatebtn = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.SSNTXT = new System.Windows.Forms.TextBox();
            this.USERTXT = new System.Windows.Forms.TextBox();
            this.LASTNAMETXT = new System.Windows.Forms.TextBox();
            this.FIRSTNAMETXT = new System.Windows.Forms.TextBox();
            this.SALARYTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.ROLECOMBOBOX = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backIconPictureBox = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PASSTXT = new System.Windows.Forms.TextBox();
            this.backgroundpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundpanel
            // 
            this.backgroundpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.backgroundpanel.Controls.Add(this.label5);
            this.backgroundpanel.Controls.Add(this.PASSTXT);
            this.backgroundpanel.Controls.Add(this.updatebtn);
            this.backgroundpanel.Controls.Add(this.DGV);
            this.backgroundpanel.Controls.Add(this.label1);
            this.backgroundpanel.Controls.Add(this.label2);
            this.backgroundpanel.Controls.Add(this.label3);
            this.backgroundpanel.Controls.Add(this.label4);
            this.backgroundpanel.Controls.Add(this.roleLabel);
            this.backgroundpanel.Controls.Add(this.SSNTXT);
            this.backgroundpanel.Controls.Add(this.USERTXT);
            this.backgroundpanel.Controls.Add(this.LASTNAMETXT);
            this.backgroundpanel.Controls.Add(this.FIRSTNAMETXT);
            this.backgroundpanel.Controls.Add(this.SALARYTXT);
            this.backgroundpanel.Controls.Add(this.label6);
            this.backgroundpanel.Controls.Add(this.addbtn);
            this.backgroundpanel.Controls.Add(this.deletebtn);
            this.backgroundpanel.Controls.Add(this.ROLECOMBOBOX);
            this.backgroundpanel.ForeColor = System.Drawing.Color.Black;
            this.backgroundpanel.Location = new System.Drawing.Point(0, 101);
            this.backgroundpanel.Name = "backgroundpanel";
            this.backgroundpanel.Size = new System.Drawing.Size(800, 523);
            this.backgroundpanel.TabIndex = 1;
            this.backgroundpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.backgroundpanel_Paint);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.updatebtn.Location = new System.Drawing.Point(378, 473);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(100, 30);
            this.updatebtn.TabIndex = 16;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // DGV
            // 
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.GridColor = System.Drawing.Color.LightGray;
            this.DGV.Location = new System.Drawing.Point(451, 96);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(321, 338);
            this.DGV.TabIndex = 0;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(54, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(26, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "FIRST NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(33, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "LAST NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(27, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "USERNAME";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.roleLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.roleLabel.Location = new System.Drawing.Point(54, 355);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(51, 23);
            this.roleLabel.TabIndex = 5;
            this.roleLabel.Text = "ROLE";
            // 
            // SSNTXT
            // 
            this.SSNTXT.BackColor = System.Drawing.Color.White;
            this.SSNTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SSNTXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SSNTXT.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.SSNTXT.Location = new System.Drawing.Point(163, 96);
            this.SSNTXT.Name = "SSNTXT";
            this.SSNTXT.Size = new System.Drawing.Size(100, 27);
            this.SSNTXT.TabIndex = 6;
            // 
            // USERTXT
            // 
            this.USERTXT.BackColor = System.Drawing.Color.White;
            this.USERTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.USERTXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.USERTXT.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.USERTXT.Location = new System.Drawing.Point(163, 266);
            this.USERTXT.Name = "USERTXT";
            this.USERTXT.Size = new System.Drawing.Size(100, 27);
            this.USERTXT.TabIndex = 7;
            // 
            // LASTNAMETXT
            // 
            this.LASTNAMETXT.BackColor = System.Drawing.Color.White;
            this.LASTNAMETXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LASTNAMETXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LASTNAMETXT.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LASTNAMETXT.Location = new System.Drawing.Point(163, 223);
            this.LASTNAMETXT.Name = "LASTNAMETXT";
            this.LASTNAMETXT.Size = new System.Drawing.Size(100, 27);
            this.LASTNAMETXT.TabIndex = 8;
            // 
            // FIRSTNAMETXT
            // 
            this.FIRSTNAMETXT.BackColor = System.Drawing.Color.White;
            this.FIRSTNAMETXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FIRSTNAMETXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FIRSTNAMETXT.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FIRSTNAMETXT.Location = new System.Drawing.Point(163, 149);
            this.FIRSTNAMETXT.Name = "FIRSTNAMETXT";
            this.FIRSTNAMETXT.Size = new System.Drawing.Size(100, 27);
            this.FIRSTNAMETXT.TabIndex = 9;
            // 
            // SALARYTXT
            // 
            this.SALARYTXT.BackColor = System.Drawing.Color.White;
            this.SALARYTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SALARYTXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SALARYTXT.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.SALARYTXT.Location = new System.Drawing.Point(163, 407);
            this.SALARYTXT.Name = "SALARYTXT";
            this.SALARYTXT.Size = new System.Drawing.Size(100, 27);
            this.SALARYTXT.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(57, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "SALARY";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addbtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.addbtn.Location = new System.Drawing.Point(111, 474);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(100, 30);
            this.addbtn.TabIndex = 13;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deletebtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.deletebtn.Location = new System.Drawing.Point(240, 473);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(100, 30);
            this.deletebtn.TabIndex = 14;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // ROLECOMBOBOX
            // 
            this.ROLECOMBOBOX.BackColor = System.Drawing.Color.White;
            this.ROLECOMBOBOX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ROLECOMBOBOX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ROLECOMBOBOX.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ROLECOMBOBOX.FormattingEnabled = true;
            this.ROLECOMBOBOX.Location = new System.Drawing.Point(163, 349);
            this.ROLECOMBOBOX.Name = "ROLECOMBOBOX";
            this.ROLECOMBOBOX.Size = new System.Drawing.Size(107, 28);
            this.ROLECOMBOBOX.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.backIconPictureBox);
            this.panel1.Controls.Add(this.logoPictureBox);
            this.panel1.Controls.Add(this.lblSystemName);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 95);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // backIconPictureBox
            // 
            this.backIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("backIconPictureBox.Image")));
            this.backIconPictureBox.Location = new System.Drawing.Point(740, 30);
            this.backIconPictureBox.Name = "backIconPictureBox";
            this.backIconPictureBox.Size = new System.Drawing.Size(40, 40);
            this.backIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backIconPictureBox.TabIndex = 2;
            this.backIconPictureBox.TabStop = false;
            this.backIconPictureBox.Click += new System.EventHandler(this.backIconPictureBox_Click_1);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(115, 89);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Castellar", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSystemName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSystemName.Location = new System.Drawing.Point(120, 30);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(261, 33);
            this.lblSystemName.TabIndex = 1;
            this.lblSystemName.Text = "GLAMVENTORY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(34, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "PASSWORD";
            // 
            // PASSTXT
            // 
            this.PASSTXT.BackColor = System.Drawing.Color.White;
            this.PASSTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PASSTXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PASSTXT.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PASSTXT.Location = new System.Drawing.Point(163, 310);
            this.PASSTXT.Name = "PASSTXT";
            this.PASSTXT.Size = new System.Drawing.Size(100, 27);
            this.PASSTXT.TabIndex = 18;
            this.PASSTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backgroundpanel);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.backgroundpanel.ResumeLayout(false);
            this.backgroundpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.Panel backgroundpanel;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.TextBox SSNTXT;
        private System.Windows.Forms.TextBox USERTXT;
        private System.Windows.Forms.TextBox LASTNAMETXT;
        private System.Windows.Forms.TextBox FIRSTNAMETXT;
        private System.Windows.Forms.TextBox SALARYTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.ComboBox ROLECOMBOBOX;
        private Button updatebtn;
        private Panel panel1;
        private PictureBox backIconPictureBox;
        private PictureBox logoPictureBox;
        private Label lblSystemName;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox PASSTXT;
    }
}