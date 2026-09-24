using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandlingassignment
{
    internal class Program
    {
        class ageexception : Exception
        {
            public ageexception(string message) : base(message)
            {

            }
        }
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("enter the number to divide");
                string input1 = Console.ReadLine();
                int a = Convert.ToInt32(input1);

                Console.WriteLine("enter the second number");
                string input2 = Console.ReadLine();
                int b = Convert.ToInt32(input2);

                int c = a / b;
                Console.WriteLine(c+"the divide result is");
                
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cannot be divided by zero");
            }
            catch (ArrayTypeMismatchException)
            {
                Console.WriteLine("cinsert the data type correctly");
            }
            catch (FormatException)
            {
                Console.WriteLine("enter numbers only");
            }
            finally
            {
                Console.WriteLine("block runnned succesfully");
            }

            try
            {
                string input3 = Console.ReadLine();
                int weight = Convert.ToInt32(input3);
                if (weight > 69)
                {
                    throw new ageexception("srry you are overweight ");
                }
                else
                {
                    Console.WriteLine("you are eligible0");
                }

            }catch(ageexception Mx)
            {
                Console.WriteLine(Mx.Message);
            }
            finally
            {
                Console.WriteLine("you haveeusccefully finished your weight checking");
            }

        }
    }
    
}
