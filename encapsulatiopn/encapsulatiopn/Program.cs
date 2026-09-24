
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace encapsulatiopn
{

    class bankaccount
    {
        private string accountholder;
        private double balance;
        private double deposit;

        public string Accountholder
        {
            get { return accountholder; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    accountholder = value;

                else
                {
                    accountholder = "unknownholder";
                }

            }
        }
        public double Balance
        {
            get { return balance ; }
            set { balance = value; }
        }
        public double Deposit
        {
            get { return deposit; }
            set { deposit=value; }
        }

        public bankaccount(  string name , double balancee,double dep)
        {
            this.accountholder = name;
            this.balance = balancee;
            this.deposit = dep;
        }
        public void diplayinfo()
        {
            Console.WriteLine($"{accountholder} is the account holder name");
            Console.WriteLine($"{balance} is the balance");

        }
      public void fixeddeposit()
        {
            balance += deposit;
            Console.WriteLine(balance + "is the balance after done fixed deposit");

        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bankaccount b1 = new bankaccount("VEERA",6000,7899);

            b1.diplayinfo();
            b1.fixeddeposit();
        }
    }
}
