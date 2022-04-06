using System;
using System.Collections.Generic;

namespace GenericStack
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
                Console.Write("{0}, ",stack.Pop());
            Console.WriteLine();
            //1 회성 데이터
            Console.Write("stack.Count: {0}, ", stack.Count);
            Console.WriteLine();

            Stack<double> stack2 = new Stack<double>();

            stack2.Push(1.1);
            stack2.Push(2.1);
            stack2.Push(3.1);
            stack2.Push(4.1);
            stack2.Push(5.1);

            while (stack2.Count > 0)
                 Console.Write("{0}, ",stack2.Pop());
            Console.WriteLine();

            Stack<string> stack3 = new Stack<string>();

            stack3.Push("one");
            stack3.Push("two");
            stack3.Push("three");
            stack3.Push("four");
            stack3.Push("five");

            while (stack3.Count > 0)
                Console.Write("{0}, ", stack3.Pop());
            Console.WriteLine();
        }
    }
}
