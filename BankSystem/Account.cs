using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Account
    {
        double money;
        string id;
        string pwd;
        
        public Account(string id, string pwd,double money)
        {
            this.id = id;
            this.pwd = pwd;
            this.money = money;
        }


        //得到id
        public string GetId()
        {
            return id;
        }
       //设置id
        public void SetId(string id)
        {
            this.id = id;
           
        }

        //得到pwd
        public string GetPwd()
        {
            return pwd;
        }
        //设置pwd
        public void SetPwd(string pwd)
        {
            this.pwd = pwd;

        }

        //得到money
        public double Getmoney()
        {
            return money;
        }
        //设置money
        public void Setmoney(double money)
        {
            this.money = money;

        }

        //匹配账号与密码
        public bool Ismatch(string id,string pwd)
        {
           
            return id==this.id && pwd==this.pwd;
        }

        //存钱
        public  bool SaveMoney(double money)
        {
            if (money < 0) return false;

            this.money += money;
            return true;
        }
        //取钱
        public virtual bool WithdrawMoney(double money)
        {
            if (this.money >= money)
            {
                this.money -= money;
                return true;
            }
            return false;

        }
    }
}
