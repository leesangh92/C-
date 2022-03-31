using System;

namespace CH01
{
    class BoxingUnboxing
    {
        public static void Main()
        {
            int a = 123;
            object b = (object)a; // Boxing
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();

            int c = (int)b; // Unboxing
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
