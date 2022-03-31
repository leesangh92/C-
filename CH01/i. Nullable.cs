using System;

namespace CH01
{
    class Nullable
    {
        public static void Main()
        {
        //nullable 변수
            //C#에서 변수는 초기화해야 함
            int? a = null; // null 을 저장하는 방법.(nullable)
            int b = 0;

            Console.WriteLine(a.HasValue); // 값을 가지고 있으면 true, 아니면 false
            Console.WriteLine(a != null);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();

            a = 100;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a);
            Console.WriteLine();

        //var type 변수
            int num = 100;
            Console.WriteLine("{0}, {1}", num, num.GetType());

            //반드시 초기화를 해야 함.
            var Tmp = 200; // var type 변수 : type이 정해지지 않은 변수. 값이 저장될 때 자료형이 결정된다. 
            Console.WriteLine("{0}, {1}", Tmp, Tmp.GetType());
            //Tmp = 3.4; // 형변환 불가능

            var Tmp2 = 3.4;
            Console.WriteLine("{0}, {1}", Tmp2, Tmp2.GetType());

            var Tmp3 = "Hello";
            Console.WriteLine("{0}, {1}", Tmp3, Tmp3.GetType());

            var Tmp4 = new int[] { 10, 20, 30 };
            Console.WriteLine("{0}", Tmp4.GetType());
        }
    }
}
