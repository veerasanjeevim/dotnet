using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericclasses
{
    internal class Program
    {
        class Genericclas<T>
        {
            private T data;

            public void Add(T item)
            {
                data = item;
            }
            public T Getdata()
            {
                return data;
            }
        }
        static void Main(string[] args)
        {
            Genericclas<int> intobj = new Genericclas<int>();
            intobj.Add(4);


        }


        
    }
}
