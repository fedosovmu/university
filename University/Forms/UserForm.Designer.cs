namespace University
{
	partial class UserForm
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
			this.NameLable = new System.Windows.Forms.Label();
			this.SurameLable = new System.Windows.Forms.Label();
			this.PhoneLable = new System.Windows.Forms.Label();
			this.EmailLable = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.SurnameTextBox = new System.Windows.Forms.TextBox();
			this.PhoneTextBox = new System.Windows.Forms.TextBox();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.AccrualListView = new System.Windows.Forms.ListView();
			this.AccrualLabel = new System.Windows.Forms.Label();
			this.MoreInfoButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// NameLable
			// 
			this.NameLable.AutoSize = true;
			this.NameLable.Location = new System.Drawing.Point(30, 25);
			this.NameLable.Name = "NameLable";
			this.NameLable.Size = new System.Drawing.Size(29, 13);
			this.NameLable.TabIndex = 0;
			this.NameLable.Text = "Имя";
			// 
			// SurameLable
			// 
			this.SurameLable.AutoSize = true;
			this.SurameLable.Location = new System.Drawing.Point(30, 48);
			this.SurameLable.Name = "SurameLable";
			this.SurameLable.Size = new System.Drawing.Size(56, 13);
			this.SurameLable.TabIndex = 1;
			this.SurameLable.Text = "Фамилия";
			// 
			// PhoneLable
			// 
			this.PhoneLable.AutoSize = true;
			this.PhoneLable.Location = new System.Drawing.Point(30, 77);
			this.PhoneLable.Name = "PhoneLable";
			this.PhoneLable.Size = new System.Drawing.Size(52, 13);
			this.PhoneLable.TabIndex = 2;
			this.PhoneLable.Text = "Телефон";
			// 
			// EmailLable
			// 
			this.EmailLable.AutoSize = true;
			this.EmailLable.Location = new System.Drawing.Point(30, 103);
			this.EmailLable.Name = "EmailLable";
			this.EmailLable.Size = new System.Drawing.Size(34, 13);
			this.EmailLable.TabIndex = 3;
			this.EmailLable.Text = "e-mail";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(88, 22);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.ReadOnly = true;
			this.NameTextBox.Size = new System.Drawing.Size(121, 20);
			this.NameTextBox.TabIndex = 4;
			// 
			// SurnameTextBox
			// 
			this.SurnameTextBox.Location = new System.Drawing.Point(88, 48);
			this.SurnameTextBox.Name = "SurnameTextBox";
			this.SurnameTextBox.ReadOnly = true;
			this.SurnameTextBox.Size = new System.Drawing.Size(121, 20);
			this.SurnameTextBox.TabIndex = 5;
			// 
			// PhoneTextBox
			// 
			this.PhoneTextBox.Location = new System.Drawing.Point(88, 74);
			this.PhoneTextBox.Name = "PhoneTextBox";
			this.PhoneTextBox.Size = new System.Drawing.Size(121, 20);
			this.PhoneTextBox.TabIndex = 6;
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(88, 100);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(121, 20);
			this.EmailTextBox.TabIndex = 7;
			// 
			// AccrualListView
			// 
			this.AccrualListView.Location = new System.Drawing.Point(30, 154);
			this.AccrualListView.Name = "AccrualListView";
			this.AccrualListView.Size = new System.Drawing.Size(383, 177);
			this.AccrualListView.TabIndex = 8;
			this.AccrualListView.UseCompatibleStateImageBehavior = false;
			this.AccrualListView.View = System.Windows.Forms.View.Details;
			// 
			// AccrualLabel
			// 
			this.AccrualLabel.AutoSize = true;
			this.AccrualLabel.Location = new System.Drawing.Point(30, 138);
			this.AccrualLabel.Name = "AccrualLabel";
			this.AccrualLabel.Size = new System.Drawing.Size(68, 13);
			this.AccrualLabel.TabIndex = 9;
			this.AccrualLabel.Text = "Начисления";
			// 
			// MoreInfoButton
			// 
			this.MoreInfoButton.Location = new System.Drawing.Point(332, 93);
			this.MoreInfoButton.Name = "MoreInfoButton";
			this.MoreInfoButton.Size = new System.Drawing.Size(81, 23);
			this.MoreInfoButton.TabIndex = 10;
			this.MoreInfoButton.Text = "Информация";
			this.MoreInfoButton.UseVisualStyleBackColor = true;
			// 
			// UserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 343);
			this.Controls.Add(this.MoreInfoButton);
			this.Controls.Add(this.AccrualLabel);
			this.Controls.Add(this.AccrualListView);
			this.Controls.Add(this.EmailTextBox);
			this.Controls.Add(this.PhoneTextBox);
			this.Controls.Add(this.SurnameTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.EmailLable);
			this.Controls.Add(this.PhoneLable);
			this.Controls.Add(this.SurameLable);
			this.Controls.Add(this.NameLable);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "UserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UserForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label NameLable;
		private System.Windows.Forms.Label SurameLable;
		private System.Windows.Forms.Label PhoneLable;
		private System.Windows.Forms.Label EmailLable;
		public System.Windows.Forms.TextBox NameTextBox;
		public System.Windows.Forms.TextBox SurnameTextBox;
		public System.Windows.Forms.TextBox PhoneTextBox;
		public System.Windows.Forms.TextBox EmailTextBox;
		public System.Windows.Forms.ListView AccrualListView;
		private System.Windows.Forms.Label AccrualLabel;
		private System.Windows.Forms.Button MoreInfoButton;
	}
}