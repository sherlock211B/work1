using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankSystem
{
    class creditCard : Account
    {
        double creditLimit;
        public creditCard(string id, string pwd, double money, double creditLimit) : base(id, pwd, money)
        {
            this.creditLimit = creditLimit;
        }

        //得到creditLimit
        public double getLimit()
        {
            return creditLimit;
        }
        //设置creditLimit
        public void setLimit(double creditLimit)
        {
            this.creditLimit = creditLimit;

        }

      
        //取钱
        public override bool withdrawMoney(double money)
        {
            if (money >= money)
            {
                money -= money;
                return true;
            }
            return false;

        }
    }
   
}
