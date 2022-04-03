using System;

namespace CH10
{
    class TwoArray
    { 
    
        static void Main(string[] args)
        {
            int[,] grid = new int[2, 3]; // 2행 3열의 배열

            grid[0, 0] = 10;
            grid[0, 1] = 20;
            grid[1, 0] = 30;
            grid[1, 1] = 40;

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                    Console.Write("{0}, ", grid[i, j]);
                Console.WriteLine();
            }

            int[,] grid2 = new int[2, 3] // 다차원 배열 초기화
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("{0}, ", grid[i, j]);
                Console.WriteLine();
            }

            //int[,] grid3 = new int[2, 3] // C#에서의 배열 초기화는 생략할 수 없음.(배열 행렬 수 = 배열 원소 수)
            //{
            //    { 1, 2 },
            //    { 4, 5 }
            //};

            //int[,] grid4 = new int[2, 3] // 행 단위 구분해주어야 한다. 
            //{
            //    { 1, 2, 3, 4, 5, 6 }
            //};
        }
    }
}
