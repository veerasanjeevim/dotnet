using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    internal class Program
    {
        abstract class person
        {
            public string Name;
            public int Age;
            public person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public void showdetails()
            {
                Console.WriteLine($"name:{Name},age:{Age}");
            }
            public abstract void displayrole();
        }
        class employee : person
        {
            public string Company;
            public employee(string name, int age, string company) : base(name, age)
            {
                Company = company;
            }
            public override void displayrole()
            {
                {
                    Console.WriteLine($"employee works at {Company} ");
                }

            }
            class school : person
            {
                public string School;
                public school(string name, int age, string school) : base(name, age)
                {
                    School = school;
                }
                public override void displayrole()
                {
                    {
                        Console.WriteLine($"employee works at {School} ");
                    }
   
                }
                static void Main(string[] args)
                {
                    employee e1 = new employee("veera", 34, "kekron");
                    e1.displayrole();

                    school s1 = new school("sanju", 56, "sairam school");
                    s1.displayrole();



                }
            }
        }
    }
}
