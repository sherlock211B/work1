using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankSystem
{
    class creditCard : Account
    {
        double creditLine;
        public creditCard(string id, string pwd, double money, double creditLine) : base(id, pwd, money)
        {
            this.creditLine = creditLine;
        }

        //得到creditLine
        public double GetLine()
        {
            return creditLine;
        }

     
        public bool AddLine(double creditLine)
        {
            if (creditLine < 0) return false;

            this.creditLine += creditLine;
            return true;
           

        }

        public bool DropLine(double creditLine)
        {
            if (this.creditLine >= creditLine)
            {
                this.creditLine -= creditLine;
                return true;
            }
            return false;
           

        }
    }
   
}
