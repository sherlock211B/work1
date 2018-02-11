using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class Bank
    {
        List<Account> accounts = new List<Account>() ;

        //开户
        public Account OpenAccount(string id, string pwd, double money)
        {
            Account account = new Account(id,  pwd,  money);
            accounts.Add(account);
            return account;
        }

        //销户
        public bool CloseAccount(Account account)
        {
            int idx = accounts.IndexOf(account);
            if (idx < 0) return false;
            accounts.Remove(account);
            return true ;
        }

        //查找账户
        public Account FindAccount(string id, string pwd)
        {
            foreach (Account act in accounts)
            {
                if(act.Ismatch(id,pwd))
                {
                    return act;
                }
            }
            return null;
        }

        List<creditCard> creditCards = new List<creditCard>();

        public creditCard OpenCreditCard(string id, string pwd, double money, double creditLine)
        {
            creditCard creditCard = new creditCard(id, pwd, money,creditLine);
            creditCards.Add(creditCard);
            return creditCard;
        }

        public bool CloseCreditCard(creditCard creditCard)
        {
            int idx = creditCards.IndexOf(creditCard);
            if (idx < 0) return false;
            creditCards.Remove(creditCard);
            return true;
        }

        public creditCard FindCreditCard(string id, string pwd)
        {
            foreach (creditCard creditCard in creditCards)
            {
                if (creditCard.Ismatch(id, pwd))
                {
                    return creditCard;
                }
            }
            return null;
        }
    }
}
