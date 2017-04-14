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

			DataInitialization();
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



		private void DataInitialization()
		{
			var admin = new Admin("admin", "123");
			admin.Surname = "Федосов";
			admin.Name = "Максим";
			AddUser(admin);

			var student = new Student("student", "123");
			student.Surname = "Еремеев";
			student.Name = "Роман";
			AddUser(student);

			var student2 = new Student("student2", "123");
			student2.Surname = "Кронберг";
			student2.Name = "Георгий";
			AddUser(student2);

			var student3 = new Student("student3", "123");
			student3.Surname = "Медведев";
			student3.Name = "Никита";
			AddUser(student3);

			ProduceAccrual(admin, 7000, "Зарплата");
			ProduceAccrual(admin, 7200, "Зарплата");
			ProduceAccrual(student, 2500, "Стипендия");
			ProduceAccrual(student, 2600, "Социальная стипендия");
			ProduceAccrual(student, 2700, "Стипендия");
			ProduceAccrual(student2, 3000, "Стипендия");
			ProduceAccrual(student2, 2000, "Стипендия");
			ProduceAccrual(student2, 4000, "Стипендия");
			ProduceAccrual(student3, 6000, "Призедентская стипендия");
		} 



		public void ProduceAccrual(User user ,double sum, String comment)
		{
			var accrual = new Accrual(user, sum, comment);
			user.PersonalBankAccount.ProduceAccrual(accrual);
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
