using System;

namespace HelloWorld
{
    class Greeting
    {
        public static void GreetingShow1()
        {
            Console.WriteLine("같은 namespace, 다른 class GreetingShow1()");
        }
    }

    partial class Program2
    {
        public static void GoodNight()
        {
            Console.WriteLine("안녕히 주무세요!");
        }
    }
}
