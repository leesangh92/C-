using System;

/*
 키보드로부터 성명, 출생년도, 월급을 입력받아 다음과 같이 출력하시오.

성명 ? 홍길동
출생년도 ? 1972
월급 ? 3500000

당신의 이름은 홍길동입니다.
당신의 나이는 50세 입니다. 
당신의 연봉은 \42,000,000 입니다. 
 */
namespace CH01
{
    class Test1
    {
        public static void Main()
        {
            Console.Write("성명 ? ");
            string name = Console.ReadLine();

            Console.Write("출생년도 ? ");
            string birth = Console.ReadLine();
            int age = DateTime.Now.Year - Int32.Parse(birth);

            Console.Write("월급 ? ");
            int salary = Int32.Parse(Console.ReadLine());


            Console.WriteLine("당신의 이름은 {0}입니다.", name);
            Console.WriteLine("당신의 나이는 {0}세 입니다.", age);
            Console.WriteLine("당신의 연봉은 {0:C} 입니다.", salary*12);
        }
    }
}
