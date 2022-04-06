using System;
using System.Collections.Generic;

namespace GenericQueue
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            while (queue.Count > 0)
                Console.Write("{0}, ",queue.Dequeue());
            Console.WriteLine();
            Console.Write("queue.Count: {0}, ", queue.Count);
            Console.WriteLine();

            Queue<string> queue2 = new Queue<string>();

            queue2.Enqueue("kim");
            queue2.Enqueue("lee");
            queue2.Enqueue("han");
            queue2.Enqueue("Park");
            queue2.Enqueue("uk");

            while (queue2.Count > 0)
                Console.Write("{0}, ", queue2.Dequeue());
            Console.WriteLine();
        }
    }
}
