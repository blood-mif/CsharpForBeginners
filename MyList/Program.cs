using System;

namespace MyList
{
    class Program
    {
        private static void Main(string[] args)
        {
            List list = new List();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            do
            {
                Console.WriteLine(list.Current);

            } while (list.MoveNext());


            //for (; list.Current != null ; list.MoveNext())
            //{
            //    Console.WriteLine(list.Current);
            //}

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
