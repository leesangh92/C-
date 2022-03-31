using System;
using System.Collections;

namespace ForStatement
{
	class Program
	{
		static void Main(string[] args)
		{
// for
			for (int i = 0; i < 10; i++)
			{
				Console.Write("{0} ", i);
			}
			Console.WriteLine();

  // Initial value
			for (int i = 0, j = 0; i < 10; i++, j++)
			{
				Console.Write("{0} ", i * j);
			}
			Console.WriteLine();

/
            int[] numbers = new int[6] { 10, 20, 30, 40, 50, 60 };

// for
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();

  // foreach
            foreach (int number in numbers)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
		}
	}
}

