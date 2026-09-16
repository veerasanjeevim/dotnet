using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraytypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //normal array
            int[] number = { 10, 30, 50, 90 };
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            //multi dimensional array


            //jagged

            int[][] jagged = new int[3][];
            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 3, 4, 5 };
            jagged[2] = new int[] { 6, 57, 82, 9 };

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged.Length; j++)
                {

                }
            }
            int[] arr = { 5, 8, 2, 9 };

            Console.WriteLine("priginal arrr" + string.Join("*", arr));
            //sorting array
            Array.Sort(arr);
            Console.WriteLine("sorted array" + string.Join("*", arr));
            //reversing array
            Array.Reverse(arr);
            Console.WriteLine(string.Join("*",arr));
            //finding index
            int index = Array.IndexOf(arr, 2);
            Console.WriteLine("6th elements" + index);
            
            //boxing and unboxing
            int a = 30;
            object objnum = a;
            //unboxing
            int dobnum = (int)objnum;
            // boxing and unboxing the double and object
            double gh = 44.67;
            object objdouble = gh;
            double unbox = (double)objdouble;

            //method
            
                sayhello();
            addnumber(20, 40);
            displayageandname(name: "veera", Age: 35);
            int result = multiply(5, 6);

        }
            static void sayhello()
            {
                Console.WriteLine("HWLLO BRO");
            }
          static void displayageandname( int Age ,string name)

        {
            Console.WriteLine($"{Age} , {name} is my details");
        }

        static int multiply (int a, int b)
        {
            return a*b;
        }



        static void addnumber(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($" the sum of {a} and {b} is {sum}");
        }

        }
    }

