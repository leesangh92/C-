using System;

namespace OperatorPrecedence
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 5;
			int b = 5;

			a *= 2;
			b *= 2 + 10;  //60

			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);

            int a1 = 3, b1 = 3;

            if (a1 == b1)	// if (a1 = b1)
                Console.WriteLine("equal");
            else
                Console.WriteLine("not equal");
		}
	}
}
