using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arrayless
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList arr = new ArrayList();
            arr.Add("name");
            arr.Add("place");
            arr.Add("fruits");

            foreach(String var in arr){
                Console.WriteLine(arr);
            }
            Hashtable v = new Hashtable();

            v.Add(1, "veera");
            v.Add(2, "seera");
            v.Add(3, "beera");
            v.Add(4, "heera");
            foreach(DictionaryEntry entry in v)

            {
                Console.WriteLine($" {entry.Key} {entry.Value}");
            }
            Queue q = new Queue();
            q.Enqueue("lorry");
            q.Enqueue("bus");
            q.Enqueue("bike");
            q.Enqueue("scooter");

            foreach(var item in q)
            {
                Console.WriteLine(item);
                Console.WriteLine($"dequed {q.Dequeue()}");
                Console.WriteLine($"dequed {q.Peek()}");
            }
            Stack stack = new Stack();
            stack.Push("push1");
            stack.Push("push2");
            stack.Push("push3");
            stack.Push("push4");
            Console.WriteLine(stack);
       
        ///
        }
    }
}
