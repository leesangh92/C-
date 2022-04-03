using System;

namespace CH06
{
    class PassingParameter
    {
        static void PassByVal(int x, int y)
        {
            x++;
            y++;
        }

        static void PassByRef(ref int x, ref int y)
        {
            x++;
            y++;
        }

        static void PassByOut(out int x, out int y) 
        {
            //x++;
            //y++;

            // 여러 개의 인자 값을 넘길 때 유용하다.
            x = 30;
            y = 40;
        }

        static void Main( string[] args )
        {
            int a1 = 10, b1 = 20;
            int a2 = 10, b2 = 20;
            //int a3 = 10, b3 = 20; // 기존 값을 사용할 수 없고, out은 저장만 가능하다. 초기화가 의미가 없다.
            int a3, b3;

            PassByVal(a1, b1); // 값
            Console.WriteLine("a1 : {0}, b1 : {1}", a1, b1);

            PassByRef(ref a2, ref b2); // 참조
            Console.WriteLine("a2 : {0}, b2 : {1}", a2, b2);

            PassByOut(out a3, out b3);
            Console.WriteLine("a3 : {0}, b3 : {1}", a3, b3);
        }
    }
}
