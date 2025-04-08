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
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.SubmitFeedbackButton = new System.Windows.Forms.Button();
            this.FeedbackDataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSSNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.RateLabel.Size = new System.Drawing.Size(41, 16);
            this.RateLabel.TabIndex = 1;
            this.RateLabel.Text = "Rating:";
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(12, 93);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(100, 22);
            this.RateTextBox.TabIndex = 2;
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(12, 125);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(64, 16);
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
            //this.SubmitFeedbackButton.Click += new System.EventHandler(this.SubmitFeedbackButton_Click);
            // 
            // FeedbackDataGridView
            // 
            this.FeedbackDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeedbackDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.IDColumn,
                this.PIDColumn,
                this.EmployeeSSNColumn,
                this.RateColumn,
                this.CommentColumn,
                this.DateColumn});
            this.FeedbackDataGridView.Location = new System.Drawing.Point(12, 286);
            this.FeedbackDataGridView.Name = "FeedbackDataGridView";
            this.FeedbackDataGridView.RowHeadersWidth = 51;
            this.FeedbackDataGridView.RowTemplate.Height = 24;
            this.FeedbackDataGridView.Size = new System.Drawing.Size(776, 286);
            this.FeedbackDataGridView.TabIndex = 6;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.MinimumWidth = 6;
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.Width = 125;
            // 
            // PIDColumn
            // 
            this.PIDColumn.HeaderText = "PID";
            this.PIDColumn.MinimumWidth = 6;
            this.PIDColumn.Name = "PIDColumn";
            this.PIDColumn.Width = 125;
            // 
            // EmployeeSSNColumn
            // 
            this.EmployeeSSNColumn.HeaderText = "Employee SSN";
            this.EmployeeSSNColumn.MinimumWidth = 6;
            this.EmployeeSSNColumn.Name = "EmployeeSSNColumn";
            this.EmployeeSSNColumn.Width = 125;
            // 
            // RateColumn
            // 
            this.RateColumn.HeaderText = "Rate";
            this.RateColumn.MinimumWidth = 6;
            this.RateColumn.Name = "RateColumn";
            this.RateColumn.Width = 125;
            // 
            // CommentColumn
            // 
            this.CommentColumn.HeaderText = "Comment";
            this.CommentColumn.MinimumWidth = 6;
            this.CommentColumn.Name = "CommentColumn";
            this.CommentColumn.Width = 125;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Width = 125;
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.FeedbackDataGridView);
            this.Controls.Add(this.SubmitFeedbackButton);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.RateTextBox);
            this.Controls.Add(this.RateLabel);
            this.Controls.Add(this.ProductComboBox);
            this.Name = "FeedbackForm";
            this.Text = "Feedback Form";
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.Button SubmitFeedbackButton;
        private System.Windows.Forms.DataGridView FeedbackDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSSNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
    }
}