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
    }
}
