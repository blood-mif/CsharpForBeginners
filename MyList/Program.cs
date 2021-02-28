using System;
using System.Collections.Generic;

namespace MyList
{
    class Program
    {
        private static void Main(string[] args)
        {
            // передать string, double, int в list +
            List list = new List();
            list.Add("N1ce");
            list.Add(2.23);
            list.Add(3);
         

           list.Remove(3);
            do
            {
                Console.WriteLine(list.Current);

            } while (list.MoveNext());

            

            //do
            //{
            //    Console.WriteLine(list.Current );

            //} while (list.MoveNext());

            




            Console.WriteLine();

            Queue queue = new Queue();
            queue.Enqueue(11);
            queue.Enqueue(22);
            queue.Enqueue(33);

            while (queue.Count > 0) 
            {
                Console.WriteLine(queue.Dequeue());

            }

            while (queue.Count > 0) 
            {
                Console.WriteLine(queue.Dequeue());

            }


            Console.WriteLine("");

            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pull());
            }
        }
    }
}
