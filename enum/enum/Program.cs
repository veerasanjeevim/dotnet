
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        enum days
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday

        }
        enum liftcoding
        {
            firstfloor=1,
            secondfloor=2,
            thirdfloor=3,
            fourthfloor=4
        }
        static void Main(string[] args)
        {
            liftcoding l1 = liftcoding.firstfloor;
            Console.WriteLine(l1);

            int coding = (int)liftcoding.secondfloor;
            Console.WriteLine(coding);

            liftcoding floor = (liftcoding)3;
            Console.WriteLine(floor);

            foreach(liftcoding lift in Enum.GetValues(typeof(liftcoding))){
                Console.WriteLine(lift +"is the value in enums lift coding");

            }
            if(l1 === ""
            {

            }

        }
    }
}
