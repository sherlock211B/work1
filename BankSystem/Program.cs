using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.OpenAccount("2222", "1234", 2000);
            bank.OpenAccount("5555", "5678", 400);
            bank.OpenCreditCard("6666","4563",200,5000);
            ATM atm = new ATM(bank);

            for(int i=0;i<5;i++)
            {
                atm.Transaction();
            }
        }
    }
}
