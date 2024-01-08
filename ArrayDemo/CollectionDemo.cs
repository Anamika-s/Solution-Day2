using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class CollectionDemo
    {
        static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add("ajay");
            list.Add(10.6f);
            Console.WriteLine("Elements are ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Remove(2);
            Console.WriteLine("After Removing 2");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            // list.RemoveAt(0);
            //list.Re
            list.Insert(2, 100);
            Console.WriteLine("After isnerting 100");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Queue queue= new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue("aaaa");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Stack

            Stack stack= new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();



            Hashtable ht= new Hashtable();
            ht[100] = 20;
            ht[101] = 30;
            ht["ajay"] = 90;
            Console.WriteLine(ht[100]);

           foreach(var key in ht.Keys) {
                Console.WriteLine($"Scores of {key} are {ht[key]}");
            }
        }
    }
}
