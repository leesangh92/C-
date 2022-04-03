using System;

namespace CH06
{
    class OptionalParameter
    {
        static void PrintProfile(string name = "", string phone = "", int salary = 0)
        {
            Console.WriteLine("name : {0}, phone : {1}, salary : {2}", name, phone, salary);
        }

        static void Main(string[] args)
        {
            PrintProfile();
            PrintProfile("홍길동");
            PrintProfile("홍길동", "010-0000-0000");
            PrintProfile("홍길동", "010-0000-0000", 3500000);

            PrintProfile(salary : 3700000, phone : "010-1111-1111", name : "이몽룡"); // 명명된 인자 전달(인자명은 동일해야 한다.)
        }
    }
}
