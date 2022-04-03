using System;

namespace CH10
{
    class Array_Jagged
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[2][]; // 톱니바퀴 배열

            grid[0] = new int[2];
            grid[1] = new int[4];

            grid[0][0] = 10;
            grid[0][1] = 20;

            grid[1][0] = 100;
            grid[1][1] = 200;
            grid[1][2] = 300;
            grid[1][3] = 400;

            for (int i = 0; i < 2; i++)
                Console.WriteLine("{0}, ", grid[0][i]);

            for (int i = 0; i < 4; i++)
                Console.WriteLine("{0}, ", grid[1][i]);
        }
    }
}
