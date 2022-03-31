using System;

namespace Increment
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 0, b = 0;
            int n1 = 100, n2 = 200, n3=150, max;

            int x = a++;
            int y = ++b;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("x = {0}", x);
            Console.WriteLine("y = {0}", y);

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            for (int i = 0; i < 10; ++i)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            max = (n1 > n2 ? n1 : n2);
            max = (max > n3 ? max : n3);
            Console.WriteLine("max : {0}", max);
        }
	}
}
