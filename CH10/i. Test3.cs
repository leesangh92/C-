using System;

namespace CH10
{
    class Test3
    {
        static void Main(string[] args)
        {
            int[][] g = new int[3][];

            g[0] = new int[2] { 1, 2 };
            g[1] = new int[3] { 3, 4, 5 };
            g[2] = new int[4] { 6, 7, 8, 9 };

            for(int i = 0; i < g.Length; i++)
            {
                for (int j = 0; j < g[i].Length; j++)
                    Console.Write("{0}, ", g[i][j]);
                Console.WriteLine();
            }
        }
    }
}
