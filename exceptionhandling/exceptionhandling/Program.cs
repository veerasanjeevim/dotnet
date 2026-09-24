using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText("textfile.txt");
                Console.WriteLine(content);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("udexception" + ex.Message);
            }
            finally
            {
                Console.WriteLine("FINALLY BLOCK EXECUTED");
            }
            {

            }


        }
    }
}
