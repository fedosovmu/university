namespace University
{
	partial class AdminForm
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
			this.UsersList = new System.Windows.Forms.ListBox();
			this.UserListLable = new System.Windows.Forms.Label();
			this.UserInfoButton = new System.Windows.Forms.Button();
			this.AddUserButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UsersList
			// 
			this.UsersList.FormattingEnabled = true;
			this.UsersList.Location = new System.Drawing.Point(12, 21);
			this.UsersList.Name = "UsersList";
			this.UsersList.Size = new System.Drawing.Size(287, 277);
			this.UsersList.TabIndex = 0;
			// 
			// UserListLable
			// 
			this.UserListLable.AutoSize = true;
			this.UserListLable.Location = new System.Drawing.Point(12, 5);
			this.UserListLable.Name = "UserListLable";
			this.UserListLable.Size = new System.Drawing.Size(80, 13);
			this.UserListLable.TabIndex = 1;
			this.UserListLable.Text = "Пользователи";
			// 
			// UserInfoButton
			// 
			this.UserInfoButton.Location = new System.Drawing.Point(305, 21);
			this.UserInfoButton.Name = "UserInfoButton";
			this.UserInfoButton.Size = new System.Drawing.Size(95, 23);
			this.UserInfoButton.TabIndex = 2;
			this.UserInfoButton.Text = "Информация";
			this.UserInfoButton.UseVisualStyleBackColor = true;
			// 
			// AddUserButton
			// 
			this.AddUserButton.Location = new System.Drawing.Point(305, 50);
			this.AddUserButton.Name = "AddUserButton";
			this.AddUserButton.Size = new System.Drawing.Size(95, 23);
			this.AddUserButton.TabIndex = 3;
			this.AddUserButton.Text = "Добавить";
			this.AddUserButton.UseVisualStyleBackColor = true;
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 310);
			this.Controls.Add(this.AddUserButton);
			this.Controls.Add(this.UserInfoButton);
			this.Controls.Add(this.UserListLable);
			this.Controls.Add(this.UsersList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AdminForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.ListBox UsersList;
		private System.Windows.Forms.Label UserListLable;
		public System.Windows.Forms.Button UserInfoButton;
		public System.Windows.Forms.Button AddUserButton;
	}
}