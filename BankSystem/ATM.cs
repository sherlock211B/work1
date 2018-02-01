using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class ATM
    {
        Bank bank;
        public ATM(Bank bank)
        {
            this.bank = bank;
        }

        //交易流程
        public void Transaction()
        {
            Show("Please insert your account");
            string id = GetInput();

            Show("Please insert your Password");
            string pwd = GetInput();
            Account account = bank.FindAccount(id, pwd);
            if(account==null)
            {
                Show("Card invalid and password not correct");
                return;
            }
          
            
            while(true)
            {
                Show("1: display; 2: Save; 3: withdraw; 4:open creditCard; 5: Exit");
                string op = GetInput();
                if (op == "1")
                {
                    Show("balance: " + account.getmoney());
                }
                if (op == "2")
                {
                    Show("save money");
                    string srmoney = GetInput();
                    double money = double.Parse(srmoney);
                    bool bm = account.saveMoney(money);
                    if (bm) Show("OK!");
                    else Show("error");

                    Show("balance: " + account.getmoney());

                }
                if (op == "3")
                {
                    Show("withdraw money");
                    string srmoney = GetInput();
                    double money = double.Parse(srmoney);
                    bool bm = account.withdrawMoney(money);
                    if (bm) Show("OK!");
                    else Show("error");

                    Show("balance: " + account.getmoney());
                }
                if (op == "4")
                {
                    Show("open creditCard");
                    Show("Please insert your creditCardaccount");
                    string creditid = GetInput();
                    Show("Please insert your creditCardPassword");
                    string creditpwd = GetInput();
                    Show("Please insert your wish creditLimit");
                    string ncreditLimit= GetInput();
                    double creditLimit= double.Parse(ncreditLimit);
                    creditCard creditCard = new creditCard(creditid, creditpwd, 0, creditLimit);
                    Show("creditLimit: " + creditCard.getLimit());

                    Show("save creditCardmoney");
                    string srmoney = GetInput();
                    double money = double.Parse(srmoney);
                    bool bm = creditCard.saveMoney(money);
                    if (bm) Show("OK!");
                    else Show("error");
                    Show("balance: " + creditCard.getmoney());
                }
                if (op == "5")
                {
                    break;
                }
            }
            
        }



        //显示
        public void  Show(string msg)
        {
            Console.WriteLine(msg);
        }
        //输入
        public string  GetInput()
        {
           return Console.ReadLine();
        }
    }
}
