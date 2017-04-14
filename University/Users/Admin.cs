using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Admin : User
    {
		public Admin(String login, String password) : base(login, password) { }
	}
}
