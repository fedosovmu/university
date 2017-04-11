using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
	class GrapicalUserInterface
	{
		public PayrollSystem PayrollSystem;
		public LoginForm LoginForm;
		public AdminForm AdminForm;


		public GrapicalUserInterface (PayrollSystem payrollSystem)
		{
			PayrollSystem = payrollSystem;

			LoginForm = new LoginForm();
			LoginForm.Login.Text = "admin";
			LoginForm.Password.Text = "123";

			EventInitialization();
		}



		private void EventInitialization()
		{
			LoginForm.Enter.Click += (sender, args) =>
			{
				var user = PayrollSystem.FindUser(LoginForm.Login.Text, LoginForm.Password.Text);
				if (user != null)
				{
					OpenAdministratorForm();
				}		
				else
					LoginForm.ErrorLabel.Visible = true;
			};
		}



		private void OpenLoginForm()
		{
			LoginForm.Show();
			LoginForm.Password.Text = "";
			LoginForm.ErrorLabel.Visible = false;
		}



		private void OpenAdministratorForm()
		{
			LoginForm.Hide();
			AdminForm = new AdminForm();
			AdminForm.Show();

			AdminForm.FormClosed += (sender, args) => { OpenLoginForm(); };

			for (int i = 0; i < PayrollSystem.Users.Count; i++)
			{
				User user = PayrollSystem.Users[i];
				String information = user.Login + " " + user.Name + " " + user.Surname;
				AdminForm.UsersList.Items.Add(information);
			}
		}
	}
}
