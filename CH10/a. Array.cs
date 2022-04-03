using System;

namespace CH10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("배열");

            int[] x = new int[5]; // 선언과 동시에 메모리 할당

            int[] y; // 참조할 배열 변수만 선언
            y = new int[5]; // 이후에 메모리 할당하여 y가 참조

            x[0] = 10;
            x[1] = 20;
            x[2] = 30;
            for(int i = 0; i < x.Length; i++)
                Console.Write("{0}, ", x[i]);
            Console.WriteLine();

            int[] z;
            z = x; // 참조변수 
            for(int i = 0; i < x.Length; i++)
                Console.Write("{0}, ", x[i]);
            Console.WriteLine();

            z[0] = 100;
            z[1] = 200;
            for(int i = 0; i < x.Length; i++)
                Console.Write("{0}, ", x[i]);
            Console.WriteLine();

            //int[5] a1; // 오류
            //int a2[5]; // C, C++ 식 배열 선언 // 오류
            //int[] a3 = new int[-5] // 배열의 크기가 음수 // 오류
            //int[] a4 = new int[]; // 배열의 크기를 지정해야한다. // 오류
            int n = 5;
            int[] a5 = new int[n]; // 런타임 수행 // stack 메모리 할당을 받았다면 오류

        }
    }
}
