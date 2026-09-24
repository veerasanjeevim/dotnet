using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            ///generic type used to store list on specific type fo data.

            List<string> name = new List<string> { "riya", "jhon", "alex" };
            Console.WriteLine("GENERIC list stored datas:");

            foreach(string names in name)
            {
                Console.WriteLine(names);
            }

            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(101, "veera");
            students.Add(102, "nora");
            students.Add(103, "oorra");
            students.Add(104, "keeera");
            
            foreach(var par in students)
            {
                Console.WriteLine("PRINTING USING THE DICTIONARY GENERIC");
                Console.WriteLine($"{par.Key} {par.Value}");
            }

        }
    }
}
