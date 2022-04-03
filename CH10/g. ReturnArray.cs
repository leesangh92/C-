using System;

namespace CH10
{
    class ReturnArray
    {
        static int[] CreateArray1(int n)
        {
            return new int[n];
        }
        
        static int[,] CreateArray2(int r, int c)
        {
            return new int[r, c];
        }

        static void Main()
        {
            int[] arr1 = CreateArray1(5);

            for (int i = 0; i < 5; i++)
                arr1[i] = i + 100;

            for(int i = 0; i < 5; i++)
                Console.Write("{0}, ", arr1[i]);
            Console.WriteLine();

            int[,] arr2 = CreateArray2(2, 3);
            int N = 1;

            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr2[i, j] = N++;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("{0}, ", arr2[i, j]);
                Console.WriteLine();
            }
        }
    }
}
