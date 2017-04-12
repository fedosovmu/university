namespace University
{
	partial class AddNewUserForm
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
			this.NameLabel = new System.Windows.Forms.Label();
			this.SurameLabel = new System.Windows.Forms.Label();
			this.LoginLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.SurameTextBox = new System.Windows.Forms.TextBox();
			this.LoginTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.AddButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(15, 68);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(29, 13);
			this.NameLabel.TabIndex = 0;
			this.NameLabel.Text = "Имя";
			// 
			// SurameLabel
			// 
			this.SurameLabel.AutoSize = true;
			this.SurameLabel.Location = new System.Drawing.Point(15, 95);
			this.SurameLabel.Name = "SurameLabel";
			this.SurameLabel.Size = new System.Drawing.Size(56, 13);
			this.SurameLabel.TabIndex = 1;
			this.SurameLabel.Text = "Фамилия";
			// 
			// LoginLabel
			// 
			this.LoginLabel.AutoSize = true;
			this.LoginLabel.Location = new System.Drawing.Point(15, 15);
			this.LoginLabel.Name = "LoginLabel";
			this.LoginLabel.Size = new System.Drawing.Size(38, 13);
			this.LoginLabel.TabIndex = 2;
			this.LoginLabel.Text = "Логин";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(15, 41);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
			this.PasswordLabel.TabIndex = 3;
			this.PasswordLabel.Text = "Пароль";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(74, 65);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(100, 20);
			this.NameTextBox.TabIndex = 4;
			// 
			// SurameTextBox
			// 
			this.SurameTextBox.Location = new System.Drawing.Point(74, 92);
			this.SurameTextBox.Name = "SurameTextBox";
			this.SurameTextBox.Size = new System.Drawing.Size(100, 20);
			this.SurameTextBox.TabIndex = 5;
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.Location = new System.Drawing.Point(74, 12);
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.Size = new System.Drawing.Size(100, 20);
			this.LoginTextBox.TabIndex = 6;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(74, 38);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
			this.PasswordTextBox.TabIndex = 7;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(74, 118);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(100, 21);
			this.comboBox1.TabIndex = 8;
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(52, 149);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 23);
			this.AddButton.TabIndex = 9;
			this.AddButton.Text = "Добавить";
			this.AddButton.UseVisualStyleBackColor = true;
			// 
			// AddNewUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(191, 184);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.LoginTextBox);
			this.Controls.Add(this.SurameTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.LoginLabel);
			this.Controls.Add(this.SurameLabel);
			this.Controls.Add(this.NameLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AddNewUserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddNewUserForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label SurameLabel;
		private System.Windows.Forms.Label LoginLabel;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox SurameTextBox;
		private System.Windows.Forms.TextBox LoginTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button AddButton;
	}
}