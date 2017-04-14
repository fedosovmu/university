using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
	class GrapicalUserInterface
	{
		public PayrollSystem PayrollSystem;
		public LoginForm LoginForm;



		public GrapicalUserInterface (PayrollSystem payrollSystem)
		{
			PayrollSystem = payrollSystem;

			LoginForm = new LoginForm();
			OpenLoginForm();
			EventInitialization();

			LoginForm.Login.Text = "admin";
			LoginForm.Password.Text = "123";
		}



		private void EventInitialization()
		{
			LoginForm.Enter.Click += (sender, args) =>
			{
				var user = PayrollSystem.FindUser(LoginForm.Login.Text, LoginForm.Password.Text);
				if (user != null)
				{
					if (user is Admin)
						OpenAdministratorForm();
					else
						OpenUserForm(user, true);	
					LoginForm.Hide();
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
			LoginForm.Focus();
		}



		private void OpenUserForm(User user, bool active = false)
		{
			var userForm = new UserForm();
			userForm.Show();

			userForm.NameTextBox.Text = user.Name;
			userForm.SurnameTextBox.Text = user.Surname;
			userForm.PhoneTextBox.Text = user.Phone;
			userForm.EmailTextBox.Text = user.Email;

			userForm.AccrualListView.Columns.Add("Дата", 120, HorizontalAlignment.Left);
			userForm.AccrualListView.Columns.Add("Сумма", 80, HorizontalAlignment.Left);
			userForm.AccrualListView.Columns.Add("Комментарий", 175, HorizontalAlignment.Left);

			for (int i = 0; i < user.PersonalBankAccount.Accruals.Count; i++)
			{
				var accrual = user.PersonalBankAccount.Accruals[i];
				var item = new ListViewItem(accrual.dateTime.ToString(), 0);
				item.SubItems.Add(accrual.Sum.ToString());
				item.SubItems.Add(accrual.Comment);

				userForm.AccrualListView.Items.Add(item);
			}

			if (active)
				userForm.FormClosed += (sender, args) => OpenLoginForm();
		}



		private void OpenAddNewUserForm()
		{
			var addUserNewUserForm = new AddNewUserForm();
			addUserNewUserForm.Show();

			addUserNewUserForm.UserComboBox.Items.Add("Сотрудник");
			addUserNewUserForm.UserComboBox.Items.Add("Преподаватель");
			addUserNewUserForm.UserComboBox.Items.Add("Студент");
			addUserNewUserForm.UserComboBox.Items.Add("Администратор");

			//addUserNewUserForm.UserComboBox.AccessibleDefaultActionDescription.;
		}



		private void OpenAdministratorForm()
		{
			var adminForm = new AdminForm();
			adminForm.Show();

			adminForm.FormClosed += (sender, args) => OpenLoginForm();

			int index = 0;
			adminForm.UserInfoButton.Click += (sender, args) => OpenUserForm(PayrollSystem.Users[index]);
			adminForm.UserListView.SelectedIndexChanged += (sender, args) =>
			{
				for (int i = 0; i < PayrollSystem.Users.Count; i++)
					if (adminForm.UserListView.SelectedIndices.Contains(i))
						index = i;
			};
			adminForm.AddUserButton.Click += (sender, args) => OpenAddNewUserForm();

			adminForm.UserListView.Columns.Add("Логин", 80, HorizontalAlignment.Left);
			adminForm.UserListView.Columns.Add("Имя", 80, HorizontalAlignment.Left);
			adminForm.UserListView.Columns.Add("Фамилия", 80, HorizontalAlignment.Left);
			adminForm.UserListView.Columns.Add("Статус", 80, HorizontalAlignment.Left);

			for (int i = 0; i < PayrollSystem.Users.Count; i++)
			{
				User user = PayrollSystem.Users[i];

				String status;
				if (user is Admin)
					status = "Админ";
				else if (user is Employee)
					status = "Сотрудник";
				else if (user is Teacher)
					status = "Преподаватель";
				else if (user is Student)
					status = "Студент";
				else
					status = "?";

				var item = new ListViewItem(user.Login, 0);
				item.SubItems.Add(user.Name);
				item.SubItems.Add(user.Surname);
				item.SubItems.Add(status);

				adminForm.UserListView.Items.Add(item);
			}
		}
	}
}
