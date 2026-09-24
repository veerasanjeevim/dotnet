using exceptionthrowing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionthrowing
{
    public class invalidAgeException : ApplicationException
    {
        public invalidAgeException() : base("age is invalid") {

        }

        public invalidAgeException(string message ):base(message){


        }



    }

      

    }



 
    internal class Program
    {
        static void Main(string[] args)
        {

        try
        {
            Console.WriteLine("enter the number");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if(number<0 || number > 120)
            {
                throw new invalidAgeException();
            }

        }catch(invalidAgeException ex)
        {
            Console.WriteLine("age is not valid"+ ex.Message);
        }
      
         
        }
    }
}
