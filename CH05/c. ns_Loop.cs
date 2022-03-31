using System;

namespace nsLoop
{
    class ConsoleApplication
    {
        static void Main(string[] args)
        {
            
            int i, j;

            for (i = 2; i <= 9; i++)
            {
                for (j = 1; j <= 9; j++)
                    Console.Write("{0}*{1}={2}, ", i, j, i * j);
                Console.WriteLine();
            }
        }
    }
}
