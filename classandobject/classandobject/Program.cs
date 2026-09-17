using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace classandobject
{
    class car
    {
        string carname;
        public car(string cardet)
        {
            string carname = cardet;
            Console.WriteLine("the car engine is started");

       
        }
        public void throtling()
        {
            Console.WriteLine("your car is throtling using method ");
        }
       public string name = "toyota";
    }
    class dog
    {
        public dog()
        {
            Console.WriteLine("your dog name is jimmy");
        }
        public void barking()
        {
            Console.WriteLine("your dog is barking in using method");
        }
        public string feed = "feeding pedigree";
    }

   
    internal class Program
    {
        static void Main(string[] args)
        {
            car s3 = new car("toyoto");
            Console.WriteLine(s3.name);
            s3.throtling();

            dog d4 = new dog();
            d4.barking();
            Console.WriteLine(d4.feed);
        }
    }
}
