using System;

namespace CH06
{
    class Test2
    {
        static void swap(ref int x, ref int y)
        {
            int tmp;

            tmp = x;
            x = y;
            y = tmp;
        }

        static void Main(string[] args)
        {
            int n1 = 100, n2 = 200;

            Console.WriteLine("n1 : {0}, n2 : {1}", n1, n2);
            swap(ref n1, ref n2);
            Console.WriteLine("n1 : {0}, n2 : {1}", n1, n2);
        }
    }
}
