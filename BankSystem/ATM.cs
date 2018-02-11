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
                Show("account invalid and password not correct");
                return;
            }
          
            
            while(true)
            {
                Show("1: display; 2: Save; 3: withdraw; 4: creditCard; 5: Exit");
                string op = GetInput();
                if (op == "1")
                {
                    Show("balance: " + account.Getmoney());
                }
                if (op == "2")
                {
                    Show("save money");
                    string srmoney = GetInput();
                    double money = double.Parse(srmoney);
                    bool bm = account.SaveMoney(money);
                    if (bm) Show("OK!");
                    else Show("error");

                    Show("balance: " + account.Getmoney());

                }
                if (op == "3")
                {
                    Show("withdraw money");
                    string srmoney = GetInput();
                    double money = double.Parse(srmoney);
                    bool bm = account.WithdrawMoney(money);
                    if (bm) Show("OK!");
                    else Show("error");

                    Show("balance: " + account.Getmoney());
                }
                if (op == "4")
                {
                    Show("Please insert your creditCardaccount");
                    string creditid = GetInput();
                    Show("Please insert your creditCardPassword");
                    string creditpwd = GetInput();
                    creditCard creditCard = bank.FindCreditCard(creditid, creditpwd);
                    if (creditCard == null)
                    {
                        Show("Card invalid and password not correct");
                        return;
                    }
                    if (creditCard != null)
                    {
                        while (true)
                        {
                            Show("1: displayCardLine; 2: addCreditCardLine; 3: dropCreditCardLine;4: Exit");
                            string option = GetInput();
                            if (option == "1")
                            {
                                Show("creditCardLine: " + creditCard.GetLine());
                            }
                            if (option == "2")
                            {
                                Show("add creditCardLine");
                                string srcreditCardLine = GetInput();
                                double creditCardLine = double.Parse(srcreditCardLine);
                                bool bm = creditCard.AddLine(creditCardLine);
                                if (bm) Show("OK!");
                                else Show("error");

                                Show("creditCardLine: " + creditCard.GetLine());
                            }
                            if (option == "3")
                            {
                                Show("drop creditCardLine");
                                string srcreditCardLine = GetInput();
                                double creditCardLine = double.Parse(srcreditCardLine);
                                bool bm = creditCard.DropLine(creditCardLine);
                                if (bm) Show("OK!");
                                else Show("error");

                                Show("creditCardLine: " + creditCard.GetLine());
                            }
                            if (option == "4")
                            {
                                break;
                            }
                        }
                    }
                     
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
