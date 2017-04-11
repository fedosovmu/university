using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class PayrollSystem
    {
        // <---- Система начисления зарплаты
        public List<User> Users;
        public List<Accrual> Accruals;



        public PayrollSystem()
        {
            Users = new List<User> ();
            Accruals = new List<Accrual> ();

			CreateStandartUsers();
		}



		public User FindUser (String login, String password)
		{
			for (int i = 0; i < Users.Count; i++)
			{
				if (Users[i].Login == login && Users[i].CheckPassword(password))
					return Users[i];
			}
			return null;
		}



		private void CreateStandartUsers()
		{
			var admin = new Admin("admin", "123");
			admin.Surname = "Федосов";
			admin.Name = "Максим";
			AddUser(admin);

			var student = new User("student", "123");
			student.Surname = "Еремеев";
			student.Name = "Роман";
			AddUser(student);
		}



        public void PayAccrual (User user, int sum)
        {
            var accrual = new Accrual(user, 1000, "Простое начисление");
            Accruals.Add(accrual);
        }



        public void AddUser(User user)
        {
            Users.Add(user);
        }

    }
}
