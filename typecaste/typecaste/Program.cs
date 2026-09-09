using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typecaste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type casting
            //implicit
            int num = 20;  //int (4 bytes)
            double number = num; //double(8 bytes)

            Console.WriteLine("changine double"+number);
            //explicit

            double value = 1234.748;
            int storevalue = (int)value;
            Console.WriteLine(storevalue+"storevalue from double to int");

            //converting

            string strnumber = "250";
            int convertdouble = Convert.ToInt32(strnumber);
            string convertstring = Convert.ToString(strnumber);

            Console.WriteLine(convertstring);

            string setfloat = "12.34";
            double parsedata = double.Parse(setfloat);
            Console.WriteLine(parsedata);


        }
    }
}
