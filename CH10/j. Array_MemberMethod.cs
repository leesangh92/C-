using System;

namespace CH10
{
    class Array_MemberMethod
    {
        static void Main()
        {
            int[] data1 = { 10, 20 };
            int[] copy = data1; // 얕은 복사

            copy[0]++;
            copy[1]++;

            foreach (int n in data1)
                Console.Write("{0}, ", n);
            Console.WriteLine();

            int[] data2 = { 10, 10 };
            int[] copy2 = (int[])data2.Clone(); // 깊은 복사

            copy[0]++;
            copy[1]++;

            foreach (int n in data2)
                Console.Write("{0}, ", n);
            Console.WriteLine();

            int[] data3 = { 10, 10 };
            int[] copy3 = new int[5];
            //data3.CopyTo(copy3, 2);
            data3.CopyTo(copy3, 0);

            foreach (int n in copy3)
                Console.Write("{0}, ", n);
            Console.WriteLine();
        }
    }
}
