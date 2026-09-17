using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsspractise
{
    class car
    {
        private string brand;
        private string millage;
        public string topspeed;
       public car()
        {
            brand = "unknown";
            millage = "unknown";
            topspeed = "unknown";


        }   
        public car(string carbrand,string carmillage ,string cartopspeed)
        {
            brand = carbrand;
            millage = carmillage;
            topspeed = cartopspeed;
        }
        public void showcardetails()
        {
            Console.WriteLine(brand);
            Console.WriteLine(millage);
            Console.WriteLine(topspeed);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car s1 = new car("hyundai","25","250");
            s1.showcardetails();

            car s2 = new car("maruhti", "40", "210");

            s2.showcardetails();

       
        }
    }
}
