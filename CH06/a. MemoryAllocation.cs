using System;

namespace CH06
{
    class Program
    {
        static int salary = 3500000;

        static void funcA()
        {
            int age = 30;
            Console.WriteLine("Main() salary : {0}, age : {1}", salary, age);
            salary += 100000;
        }

        static void Main(string[] args)
        {
            int age = 27;

            Console.WriteLine("Main() salary : {0}, age : {1}", salary, age);
            funcA();
            Console.WriteLine("Main() salary : {0}, age : {1}", salary, age);

            char[] str = new char[5] { 'A', 'B', 'C', 'D', 'E' }; // 초기화. 배열의 길이와 원소의 개수가 일치해야한다. 
            //str[0] = 'A';
            //str[1] = 'B';
            //str[2] = 'C';
            Console.WriteLine(str);

            string str2 = "kingdom";
            //str2[0] = 'K'; // 문자열 상수로 저장된 것이기 때문에 변경 불가능.
            Console.WriteLine(str2[0]);
            Console.WriteLine(str2);
            str2 = "Hello World!!!";
            Console.WriteLine(str2);
            Console.WriteLine(str2.GetHashCode());
        }
    }
}
