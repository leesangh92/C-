using System;

namespace SwitchStatement
{
    class ConsoleApplication
    {
        static void Main(string[] args)
        {
            Console.Write("점수? ");
            int score = int.Parse(Console.ReadLine());

            switch (score / 10)
            {
                case 10:
                case 9:
                    Console.WriteLine("{0} A학점", score);
                    break;
                case 8:
                    Console.WriteLine("{0} B학점", score);
                    break;
                case 7:
                    Console.WriteLine("{0} C학점", score);
                    break;
                case 6:
                    Console.WriteLine("{0} D학점", score);
                    break;
                default:
                    Console.WriteLine("{0} F학점", score);
                    break;
            }

            // string
            string greeting = "korean";
            switch (greeting)
            {
                case "english":
                    Console.WriteLine("Good Morning.");
                    break;
                case "korean":
                    Console.WriteLine("안녕하세요.");
                    break;
            }
        }
    }
}
