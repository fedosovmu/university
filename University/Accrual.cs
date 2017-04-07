using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Accrual
    {
        public readonly User TargetUser;
        public readonly DateTime dataTime;
        public readonly double Sum;
        public readonly String Comment;

        public Accrual(User user, double sum, String comment)
        {
            dataTime = System.DateTime.Now;
            Sum = sum;
            Comment = comment;
            TargetUser = user;
            user.PersonalBankAccount.ProduceAccrual(this);
        }
    }
}
