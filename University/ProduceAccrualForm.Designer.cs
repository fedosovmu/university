namespace University
{
    partial class ProduceAccrualForm
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
            this.SumLabel = new System.Windows.Forms.Label();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(12, 12);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(41, 13);
            this.SumLabel.TabIndex = 0;
            this.SumLabel.Text = "Сумма";
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(12, 38);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(77, 13);
            this.CommentLabel.TabIndex = 1;
            this.CommentLabel.Text = "Комментарий";
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(59, 12);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(94, 20);
            this.SumTextBox.TabIndex = 2;
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(15, 54);
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(138, 20);
            this.CommentTextBox.TabIndex = 3;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(26, 84);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(113, 23);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // ProduceAccrualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 119);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.SumLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProduceAccrualForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProduceAccrualForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label SumLabel;
        public System.Windows.Forms.Label CommentLabel;
        public System.Windows.Forms.TextBox SumTextBox;
        public System.Windows.Forms.TextBox CommentTextBox;
        public System.Windows.Forms.Button SendButton;
    }
}