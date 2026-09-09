using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] fruits = { "veera", "sudhan", "ram" };

            foreach (string clas in fruits)
            {
                Console.WriteLine(clas);

            }
            for(int num=1; num<=10; num++)
            {
                if(num == 5)
                {
                    Console.WriteLine("breaking when number 5");
                }
                else if(num == 6)
                {
                    Console.WriteLine("brekasng loop when number 6");
                }
            }
        }
    }
}
