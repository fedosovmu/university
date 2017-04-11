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
			this.SuspendLayout();
			// 
			// UsersList
			// 
			this.UsersList.FormattingEnabled = true;
			this.UsersList.Location = new System.Drawing.Point(12, 8);
			this.UsersList.Name = "UsersList";
			this.UsersList.Size = new System.Drawing.Size(199, 290);
			this.UsersList.TabIndex = 0;
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 310);
			this.Controls.Add(this.UsersList);
			this.Name = "AdminForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminForm";
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.ListBox UsersList;
	}
}