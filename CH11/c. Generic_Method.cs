using System;

namespace CH11
{
    class Generic_Method
    {
        public static void CopyArray<T>(T[] sour, T[] targ)
        {
            for (int i = 0; i < sour.Length; i++)
            targ[i] = sour[i];
        }
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);

            foreach (int item in target)
                Console.Write("{0}, ", item);
            Console.WriteLine();

            string[] s2 = { "one", "two", "three", "four", "five" };
            string[] t2 = new string[s2.Length];

            CopyArray<string>(s2, t2);

            foreach (string item in t2)
                Console.Write("{0}, ", item);
        }
    }
}
