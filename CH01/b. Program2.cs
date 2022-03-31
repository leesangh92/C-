using System;
using GreetingWorld;

namespace HelloWorld
{
    partial class Program2
    {
        public static void Main()
        {
            Console.WriteLine("namespace, class, method 구분.");

            GoodMorning(); // 같은 클래스의 메서드

            Program3.GoodBye(); // 다른 클래스의 메서드

            Greeting.GreetingShow1(); // 같은 namespace, 다른 class

            GoodNight(); // partial 키워드

            GreetingWorld.Greeting2.GreetingShow2(); // 다른 namespace, 다른 class
            Greeting2.GreetingShow2(); // using GreetingWorld 를 추가하면 이런 식으로도 사용이 가능하다.
        }

        public static void GoodMorning()
        {
            Console.WriteLine("안녕하세요!");
        }
    } // class Program2 End.

    class Program3
    {
        public static void GoodBye()
        {
            Console.WriteLine("안녕히 가세요!");
        }
    }
}
