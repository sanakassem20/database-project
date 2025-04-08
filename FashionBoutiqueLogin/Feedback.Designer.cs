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
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(12, 28);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(200, 24);
            this.ProductComboBox.TabIndex = 0;
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Location = new System.Drawing.Point(12, 70);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(49, 16);
            this.RateLabel.TabIndex = 1;
            this.RateLabel.Text = "Rating:";
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(12, 125);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(74, 16);
            this.CommentLabel.TabIndex = 3;
            this.CommentLabel.Text = "Comments:";
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(12, 144);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(300, 100);
            this.CommentTextBox.TabIndex = 4;
            // 
            // SubmitFeedbackButton
            // 
            this.SubmitFeedbackButton.Location = new System.Drawing.Point(12, 250);
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
            this.FeedbackDataGridView.Location = new System.Drawing.Point(12, 286);
            this.FeedbackDataGridView.Name = "FeedbackDataGridView";
            this.FeedbackDataGridView.RowHeadersWidth = 51;
            this.FeedbackDataGridView.RowTemplate.Height = 24;
            this.FeedbackDataGridView.Size = new System.Drawing.Size(776, 286);
            this.FeedbackDataGridView.TabIndex = 6;
            // 
            // RateBox
            // 
            this.RateBox.FormattingEnabled = true;
            this.RateBox.Location = new System.Drawing.Point(15, 89);
            this.RateBox.Name = "RateBox";
            this.RateBox.Size = new System.Drawing.Size(71, 24);
            this.RateBox.TabIndex = 7;
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.RateBox);
            this.Controls.Add(this.FeedbackDataGridView);
            this.Controls.Add(this.SubmitFeedbackButton);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.RateLabel);
            this.Controls.Add(this.ProductComboBox);
            this.Name = "Feedback";
            this.Text = "Feedback Form";
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
    }
}