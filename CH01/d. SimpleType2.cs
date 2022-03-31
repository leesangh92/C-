using System;

namespace CH01
{
    class SimpleType2
    {
        public static void Main()
        {
            int x1 = 100;
            Console.WriteLine(x1);

            //uint x2 = x1; // C#에서는 묵시적 형변환을 허용하지 않음.
            //Console.WriteLine(x2);
            uint x2 = (uint)x1; // C#에서는 묵시적 형변환을 허용하지 않음.
            Console.WriteLine(x2);
            Console.WriteLine();

            x1 = -100;
            x2 = (uint)x1;
            Console.WriteLine(x1);
            Console.WriteLine(x2); // 부호비트에 입력되는 부호 값을 계산한다.
            Console.WriteLine();

            int num = 500;
            float fnum = 1.5F;

            string s1 = num.ToString(); // 값을 문자열로 변환(ToString)
            string s2 = fnum.ToString();
            string s3 = 100.ToString();
            string s4 = 3.14.ToString();

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            Console.WriteLine("{0}, {1}", num.GetType(), s1.GetType());
            Console.WriteLine();

            int n1 = Int32.Parse(s1); // 문자열을 값으로 반환(자료형.Parse)
            int n2 = int.Parse("200");
            double d1 = Double.Parse("1.9");
            bool b1 = Boolean.Parse("true");

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(d1);
            Console.WriteLine(b1);

            Console.WriteLine("{0}, {1}", n1.GetType(), b1.GetType());
            Console.WriteLine();
        }
    }
}
