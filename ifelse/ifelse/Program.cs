using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 50;
            if (num > 10)
            {
                Console.WriteLine("this is big");
            }
            else
            {
                {
                    Console.WriteLine("this is not big");
                }

            }
            int mark = 65;
            if (mark >50 && mark<59)
            {
                Console.WriteLine("mark is more than 50");
            }
            else if(mark > 60  && mark<70){
                Console.WriteLine("mark is 60");
            }
            else if (mark > 80 && mark <90)
            {
                Console.WriteLine("mark is above 80");
            }
            else
            {
                Console.WriteLine("you are fail");
            }
            bool result = true;
            int marks = 98;

            if (result)
            {
             if (marks > 50 && marks < 59)
                {
                    Console.WriteLine("average");
                }
             else if(marks >60 && marks < 69)
                {
                    Console.WriteLine("good");
                }
             else if(marks >70 )
                {
                    Console.WriteLine("veery good");
                }
            }
            else
            {

            }

        }

    }
}
