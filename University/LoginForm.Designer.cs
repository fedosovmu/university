namespace University
{
	partial class LoginForm
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
			this.Enter = new System.Windows.Forms.Button();
			this.Login = new System.Windows.Forms.TextBox();
			this.Password = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ErrorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Enter
			// 
			this.Enter.Location = new System.Drawing.Point(35, 96);
			this.Enter.Name = "Enter";
			this.Enter.Size = new System.Drawing.Size(207, 28);
			this.Enter.TabIndex = 0;
			this.Enter.Text = "Enter";
			this.Enter.UseVisualStyleBackColor = true;
			// 
			// Login
			// 
			this.Login.Location = new System.Drawing.Point(98, 29);
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(144, 20);
			this.Login.TabIndex = 1;
			// 
			// Password
			// 
			this.Password.Location = new System.Drawing.Point(98, 55);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(144, 20);
			this.Password.TabIndex = 2;
			this.Password.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Login:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password:";
			// 
			// ErrorLabel
			// 
			this.ErrorLabel.AutoSize = true;
			this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.ErrorLabel.Location = new System.Drawing.Point(51, 9);
			this.ErrorLabel.Name = "ErrorLabel";
			this.ErrorLabel.Size = new System.Drawing.Size(175, 13);
			this.ErrorLabel.TabIndex = 5;
			this.ErrorLabel.Text = "Неправильный логин или пароль";
			this.ErrorLabel.Visible = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 159);
			this.Controls.Add(this.ErrorLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.Login);
			this.Controls.Add(this.Enter);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Button Enter;
		public System.Windows.Forms.TextBox Login;
		public System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label ErrorLabel;
	}
}