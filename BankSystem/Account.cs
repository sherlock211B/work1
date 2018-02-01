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
        public string getId()
        {
            return id;
        }
       //设置id
        public void setId(string id)
        {
            this.id = id;
           
        }

        //得到pwd
        public string getPwd()
        {
            return pwd;
        }
        //设置pwd
        public void setPwd(string pwd)
        {
            this.pwd = pwd;

        }

        //得到money
        public double getmoney()
        {
            return money;
        }
        //设置money
        public void setmoney(double money)
        {
            this.money = money;

        }

        //匹配账号与密码
        public bool Ismatch(string id,string pwd)
        {
           
            return id==this.id && pwd==this.pwd;
        }

        //存钱
        public  bool saveMoney(double money)
        {
            if (money < 0) return false;

            this.money += money;
            return true;
        }
        //取钱
        public virtual bool withdrawMoney(double money)
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
