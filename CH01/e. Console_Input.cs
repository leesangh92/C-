using System;

namespace CH01
{
    class ConsoleInput
    {
        public static void Main()
        {
            Console.Write("성명 ? "); //Console.WriteLine("성명 ? "); // WriteLine() : 줄바꾸고 입력 받기
            string name1 = Console.ReadLine();
            Console.WriteLine("성명은 {0} 입니다.", name1);

            Console.Write("당신의 성 은 ? ");
            char name2 = (char)Console.Read(); // Read() : 한 문자만 받는다. 
            Console.WriteLine("당신의 성은 {0} 입니다.", name2);
            Console.ReadLine();

            Console.Write("나이 ? ");
            string tmp = Console.ReadLine();
            int age = Int32.Parse(tmp);
            //int age = int.Parse(tmp);
            //int age = Convert.ToInt32(tmp);
            Console.WriteLine("당신의 나이는 {0} 입니다.", age);
            Console.WriteLine();

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now. Hour);
            Console.WriteLine(DateTime.Now. Minute);
            Console.WriteLine(DateTime.Now. Second);
            Console.WriteLine();

            Console.Write("생년월일 ? ");
            string tmp2 = Console.ReadLine();
            DateTime birth = DateTime.Parse(tmp2);
            //DateTime birth = DateTime.Parse("1992-08-24"); // 직접 입력
            Console.WriteLine("생일은 {0} 입니다.", birth);
            Console.WriteLine("생일은 {0} 입니다.", birth.ToShortDateString());
            Console.WriteLine("출생년도는 {0} 입니다.", birth.Year);
        }
    }
}
