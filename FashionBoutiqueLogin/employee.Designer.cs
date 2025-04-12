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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.backgroundpanel = new System.Windows.Forms.Panel();
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
            this.loadbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.ROLECOMBOBOX = new System.Windows.Forms.ComboBox();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.backgroundpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
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
            this.navigationPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::FashionBoutiqueLogin.Properties.Resources.logo_pbox;
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
            this.backgroundpanel.Controls.Add(this.loadbtn);
            this.backgroundpanel.Controls.Add(this.addbtn);
            this.backgroundpanel.Controls.Add(this.deletebtn);
            this.backgroundpanel.Controls.Add(this.ROLECOMBOBOX);
            this.backgroundpanel.ForeColor = System.Drawing.Color.Black;
            this.backgroundpanel.Location = new System.Drawing.Point(0, 101);
            this.backgroundpanel.Name = "backgroundpanel";
            this.backgroundpanel.Size = new System.Drawing.Size(800, 523);
            this.backgroundpanel.TabIndex = 1;
            // 
            // DGV
            // 
            this.DGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.Location = new System.Drawing.Point(451, 117);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(321, 178);
            this.DGV.TabIndex = 0;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "FIRST NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "LAST NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "USERNAME";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(54, 355);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(53, 18);
            this.roleLabel.TabIndex = 5;
            this.roleLabel.Text = "ROLE";
            // 
            // SSNTXT
            // 
            this.SSNTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SSNTXT.Location = new System.Drawing.Point(163, 96);
            this.SSNTXT.Name = "SSNTXT";
            this.SSNTXT.Size = new System.Drawing.Size(100, 22);
            this.SSNTXT.TabIndex = 6;
            // 
            // USERTXT
            // 
            this.USERTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.USERTXT.Location = new System.Drawing.Point(163, 281);
            this.USERTXT.Name = "USERTXT";
            this.USERTXT.Size = new System.Drawing.Size(100, 22);
            this.USERTXT.TabIndex = 7;
            // 
            // LASTNAMETXT
            // 
            this.LASTNAMETXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LASTNAMETXT.Location = new System.Drawing.Point(163, 223);
            this.LASTNAMETXT.Name = "LASTNAMETXT";
            this.LASTNAMETXT.Size = new System.Drawing.Size(100, 22);
            this.LASTNAMETXT.TabIndex = 8;
            // 
            // FIRSTNAMETXT
            // 
            this.FIRSTNAMETXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FIRSTNAMETXT.Location = new System.Drawing.Point(163, 149);
            this.FIRSTNAMETXT.Name = "FIRSTNAMETXT";
            this.FIRSTNAMETXT.Size = new System.Drawing.Size(100, 22);
            this.FIRSTNAMETXT.TabIndex = 9;
            // 
            // SALARYTXT
            // 
            this.SALARYTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SALARYTXT.Location = new System.Drawing.Point(163, 407);
            this.SALARYTXT.Name = "SALARYTXT";
            this.SALARYTXT.Size = new System.Drawing.Size(100, 22);
            this.SALARYTXT.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "SALARY";
            // 
            // loadbtn
            // 
            this.loadbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadbtn.Location = new System.Drawing.Point(587, 306);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(100, 30);
            this.loadbtn.TabIndex = 12;
            this.loadbtn.Text = "LOAD";
            this.loadbtn.UseVisualStyleBackColor = true;
            loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.Location = new System.Drawing.Point(111, 474);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(100, 30);
            this.addbtn.TabIndex = 13;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.Location = new System.Drawing.Point(240, 473);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(100, 30);
            this.deletebtn.TabIndex = 14;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // ROLECOMBOBOX
            // 
            this.ROLECOMBOBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ROLECOMBOBOX.FormattingEnabled = true;
            this.ROLECOMBOBOX.Location = new System.Drawing.Point(163, 349);
            this.ROLECOMBOBOX.Name = "ROLECOMBOBOX";
            this.ROLECOMBOBOX.Size = new System.Drawing.Size(107, 24);
            this.ROLECOMBOBOX.TabIndex = 15;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.backgroundpanel);
            this.Controls.Add(this.navigationPanel);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.backgroundpanel.ResumeLayout(false);
            this.backgroundpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }


        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        // Fields
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label lblSystemName;
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
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.ComboBox ROLECOMBOBOX;
    }
}