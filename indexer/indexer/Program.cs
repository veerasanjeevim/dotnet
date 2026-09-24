using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    internal class Program
    {
        class marks
        {
            public int[] mark = new int[6];
            
            public int this[int index]
            {
                get
                {
                    return mark[index];
                }
                set
                {
                    mark[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            marks mk = new marks();
            mk[0] = 345;
            mk[1] = 6373;
            mk[2] = 7662;

            Console.WriteLine(mk[3]+"3 rd array");
            

        }
    }
}
