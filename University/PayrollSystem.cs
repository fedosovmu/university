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
        List<User> Users;
        List<Accrual> Accruals;

        public PayrollSystem()
        {
            Users = new List<User> ();
            Accruals = new List<Accrual> ();

            var admin = new User("admin", "123");
            AddUser(admin);
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
