using System;

namespace CH06
{
    class MethodOverloading
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static double Add(double x, double y, double z)
        {
            return x + y + z;
        }

        static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        static char Add(char x)
        {
            return (char)(x + 32); // A(65)+32 = a(97)
        }

        static void Main(string[] args)
        {
            int ret = Add(10, 20);
            Console.WriteLine("ret : {0}", ret);

            double ret2 = Add(1.1, 2.1, 3.1);
            Console.WriteLine("ret2 : {0}", ret2);

            decimal ret3 = Add(100, 200);
            Console.WriteLine("ret3 : {0}", ret3);

            char ret4 = Add('A');
            Console.WriteLine("ret4 : {0}", ret4);
        }
    }
}
