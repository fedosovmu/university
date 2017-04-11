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

		public GrapicalUserInterface (PayrollSystem payrollSystem)
		{
			PayrollSystem = payrollSystem;

			var loginForm = new LoginForm();
			LoginForm = loginForm;

			EventInitialization();
		}

		private void EventInitialization()
		{
			LoginForm.Enter.Click += (sender, args) =>
			{
				var user = PayrollSystem.FindUser(LoginForm.Login.Text, LoginForm.Password.Text);
				if (user != null)
					LoginForm.Text = "ok " + user.Login; // <----			
				else 
					LoginForm.Text = "WTF"; // <----
			};
		}
	}
}
