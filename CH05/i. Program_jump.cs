using System;
namespace GotoStatement
{
    class ConsoleApplication
    {
        static void Main(string[] args)
        {
            //continue, break 활용
            int num = 0;
            int sum = 0, count = 0;

            Console.WriteLine("input ? (입력종료:-99999) ");
            while (true)
            {
                num = int.Parse(Console.ReadLine());

                if (num == -99999)
                    break; ;
                if (num == 0)
                    continue;

                sum += num;
                count++;
            }
            if (count != 0)
                Console.WriteLine("합: {0}, 평균:{1}", sum, sum / count);
            Console.WriteLine();

        }
    }
}
