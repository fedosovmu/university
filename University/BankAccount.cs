using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class BankAccount
    {
        List<Accrual> Accruals;
        public double SumOfMoney;

        public BankAccount()
        {
            Accruals = new List<Accrual>();
            SumOfMoney = 0;
        }
        
        public void ProduceAccrual (Accrual accrual)
        {
            Accruals.Add(accrual);
            SumOfMoney += accrual.Sum;
        }
    }
}
