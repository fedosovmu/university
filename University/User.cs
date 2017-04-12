using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class User
    {
        public readonly BankAccount PersonalBankAccount;
        public readonly String Login;
        private String Password;
        public String Name;
        public String Surname;
		public String Phone;
		public String Email;

        public User(String login, String password)
        {
			PersonalBankAccount = new BankAccount();
            Login = login;
            Password = password;
            Name = "";
            Surname = "";
        }

		public bool CheckPassword(String password)
        {
            return Password == password;
        }

    }
}
