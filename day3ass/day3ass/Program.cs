using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 25;
            double bignumber = number;
            Console.WriteLine($"implicit typecasting :{bignumber}");

            double c = 223.7348;

            float b = 45.67f;
            double d =  b;
            Console.WriteLine(d);

            float f = 34.87f;
            double g = Convert.ToDouble(f);

            Console.WriteLine(g);

            int a = 10;
            string db = Convert.ToString(a);

            Console.WriteLine("converted string:  "+db);
            //operators
            //addition
            int ab = 9;
            int bc = 10;

            Console.WriteLine(ab + bc);
            //subtraction
            int cb = 25;
            int bg = 50;

            Console.WriteLine(cb - bg);

            //addition and assign

            int gh = 78;
            int hg = 722;
            gh += hg;
            Console.WriteLine("addition and assign vaue"+gh);

            //and operator

            bool hari = true;
            bool saran = true;

            if(hari && saran)
            {
                Console.WriteLine("both are present");
            }
            else
            {
                Console.WriteLine("not present");
            }

            for( int i = 0; i < 10; i++)
            {
                Console.WriteLine("numer:",i);
            }

            string[] anime = { "deer", "lion", "goat" };
            
            foreach(string anim in anime)
            {
                Console.WriteLine(anim);
            }





        }
    }
}
