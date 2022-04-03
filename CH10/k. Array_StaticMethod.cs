using System;

namespace CH10
{
    class Array_StaticMethod
    {
        static void PrintArray(int[] _arr)
        {
            foreach (int n in _arr)
                Console.Write("{0}, ", n);
            Console.WriteLine();
        }

        //Array 클래스가 제공해주는 메서드
        //Static Method(정적메서드) : 객체를 만들지 않아도 메서드를 사용할 수 있다. 
        static void Main(string[] args)
        {
            int[] arr1 = { 20, 10, 50, 64, 90, 83, 4, 99, 1, 100 };
            PrintArray(arr1);
            Console.WriteLine();

            Array.Clear(arr1, 0, arr1.Length); //arr1 배열을 arr1의 길이만큼 0으로 만든다.
            PrintArray(arr1);
            Console.WriteLine();

            int[] arr2 = { 20, 10, 50, 64, 99, 83, 4, 99, 1, 100 };
            int[] arr3 = new int[arr2.Length];

            Array.Copy(arr2, arr3, arr2.Length); // 배열 복사
            PrintArray(arr2);
            PrintArray(arr3);
            Console.WriteLine();

            Array.Clear(arr3, 0, arr3.Length);
            Array.Copy(arr2, 5, arr3, 5, 3);
            PrintArray(arr3);

            int N = Array.IndexOf(arr2, 99); // 배열에서 해당 원소가 있는 인덱스 번호를 알려준다. (없으면 -1 출력)
            Console.WriteLine("{0}, {1}", N, arr2[N]);
            //int N = Array.IndexOf(arr2+N, 99);
            //Console.WriteLine("{0}, {1}", N, arr2[N]);

            Array.Sort(arr2);
            PrintArray(arr2);
            Console.WriteLine();

            Array.Reverse(arr2);
            PrintArray(arr2);
            Console.WriteLine();
        }
    }
}
