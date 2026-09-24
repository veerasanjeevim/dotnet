using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace polymorphism
{
    internal class Program
    {
        class school
        {
           public string name;
            public int schnumber;

            public school( string getname , int schnumber23)
            {
                name = getname;
                schnumber = schnumber23;
            }
            public virtual void goschool()
            {
                Console.WriteLine($"the detail of school is {name} and num {schnumber}");
            }

        }
        class work  : school
        {
            public string empname;
            public int empnum;
            public work(string getnameemp, int empnumber):base( "abschool",345)
            {
                 empname = getnameemp;
                empnum = empnumber;
            }
            public override void goschool()
            {
                Console.WriteLine($"over ride {empname} {empnum}");
            }
        }
        class employee :work
        {
            public employee(string  getemp ,int getempnumemp  ) : base("kumar ",7272)
            {

            }
        }
        static void Main(string[] args)
        {
            school s1 = new school("abc school", 1223);
            school s3 = new work("kumaresan", 526262);

            s1.goschool();
            s3.goschool();

        }
    }
}
