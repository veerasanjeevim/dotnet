using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace inheritancepract
{
    internal class Program
    {
        class father
        {
            public int money;
         public father(int mmoney)
            {
                money = mmoney;
            }
            public void monthlysalary(int salary)
            {
                Console.WriteLine("salary of father is:" + salary);
                money = salary;
                Console.WriteLine(money);
            }
        }
        class son : father
        {
           public int moneys = 78;
            public void gettingfathersalary()
            {
                Console.WriteLine("getting father salary by son"+money);
            }
        }
        class mother : son
        {
            int moneym = 12;

            public void gettingsonsalary()
            {
                Console.WriteLine(moneys + "son salary got by mother");

            }

        }
        static void Main(string[] args)
        {

            father f1 = new father(2334);
            
            


        }
    }
}
