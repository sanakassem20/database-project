namespace FashionBoutiqueLogin
{
    partial class Feedback
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
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.RateLabel = new System.Windows.Forms.Label();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.SubmitFeedbackButton = new System.Windows.Forms.Button();
            this.FeedbackDataGridView = new System.Windows.Forms.DataGridView();
            this.RateBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(21, 190);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(200, 24);
            this.ProductComboBox.TabIndex = 0;
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RateLabel.Location = new System.Drawing.Point(21, 232);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(49, 16);
            this.RateLabel.TabIndex = 1;
            this.RateLabel.Text = "Rating:";
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CommentLabel.Location = new System.Drawing.Point(21, 287);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(74, 16);
            this.CommentLabel.TabIndex = 3;
            this.CommentLabel.Text = "Comments:";
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(21, 306);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(300, 100);
            this.CommentTextBox.TabIndex = 4;
            // 
            // SubmitFeedbackButton
            // 
            this.SubmitFeedbackButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SubmitFeedbackButton.Location = new System.Drawing.Point(21, 412);
            this.SubmitFeedbackButton.Name = "SubmitFeedbackButton";
            this.SubmitFeedbackButton.Size = new System.Drawing.Size(150, 30);
            this.SubmitFeedbackButton.TabIndex = 5;
            this.SubmitFeedbackButton.Text = "Submit Feedback";
            this.SubmitFeedbackButton.UseVisualStyleBackColor = true;
            this.SubmitFeedbackButton.Click += new System.EventHandler(this.SubmitFeedbackButton_Click);
            // 
            // FeedbackDataGridView
            // 
            this.FeedbackDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeedbackDataGridView.Location = new System.Drawing.Point(350, 26);
            this.FeedbackDataGridView.Name = "FeedbackDataGridView";
            this.FeedbackDataGridView.RowHeadersWidth = 51;
            this.FeedbackDataGridView.RowTemplate.Height = 24;
            this.FeedbackDataGridView.Size = new System.Drawing.Size(441, 586);
            this.FeedbackDataGridView.TabIndex = 6;
            // 
            // RateBox
            // 
            this.RateBox.FormattingEnabled = true;
            this.RateBox.Location = new System.Drawing.Point(24, 251);
            this.RateBox.Name = "RateBox";
            this.RateBox.Size = new System.Drawing.Size(71, 24);
            this.RateBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(21, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backbtn.Location = new System.Drawing.Point(12, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(102, 42);
            this.backbtn.TabIndex = 9;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RateBox);
            this.Controls.Add(this.FeedbackDataGridView);
            this.Controls.Add(this.SubmitFeedbackButton);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.RateLabel);
            this.Controls.Add(this.ProductComboBox);
            this.Name = "Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.Button SubmitFeedbackButton;
        private System.Windows.Forms.DataGridView FeedbackDataGridView;
        private System.Windows.Forms.ComboBox RateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbtn;
    }
}