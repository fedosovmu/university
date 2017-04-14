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
			this.UserListLable = new System.Windows.Forms.Label();
			this.UserInfoButton = new System.Windows.Forms.Button();
			this.AddUserButton = new System.Windows.Forms.Button();
			this.UserListView = new System.Windows.Forms.ListView();
			this.SuspendLayout();
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
			this.UserInfoButton.Location = new System.Drawing.Point(343, 21);
			this.UserInfoButton.Name = "UserInfoButton";
			this.UserInfoButton.Size = new System.Drawing.Size(95, 23);
			this.UserInfoButton.TabIndex = 2;
			this.UserInfoButton.Text = "Информация";
			this.UserInfoButton.UseVisualStyleBackColor = true;
			// 
			// AddUserButton
			// 
			this.AddUserButton.Location = new System.Drawing.Point(343, 50);
			this.AddUserButton.Name = "AddUserButton";
			this.AddUserButton.Size = new System.Drawing.Size(95, 23);
			this.AddUserButton.TabIndex = 3;
			this.AddUserButton.Text = "Добавить";
			this.AddUserButton.UseVisualStyleBackColor = true;
			// 
			// UserListView
			// 
			this.UserListView.Location = new System.Drawing.Point(12, 21);
			this.UserListView.Name = "UserListView";
			this.UserListView.Size = new System.Drawing.Size(325, 277);
			this.UserListView.TabIndex = 4;
			this.UserListView.UseCompatibleStateImageBehavior = false;
			this.UserListView.View = System.Windows.Forms.View.Details;
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 310);
			this.Controls.Add(this.UserListView);
			this.Controls.Add(this.AddUserButton);
			this.Controls.Add(this.UserInfoButton);
			this.Controls.Add(this.UserListLable);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AdminForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.Button UserInfoButton;
		public System.Windows.Forms.Button AddUserButton;
		public System.Windows.Forms.ListView UserListView;
		public System.Windows.Forms.Label UserListLable;
	}
}