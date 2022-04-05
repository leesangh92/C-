using System;

namespace CH08
{
    class Person
    {
        private readonly DateTime birth; // 생성자에서 값 할당

        public Person(DateTime _birth)
        {
            birth = _birth;
        }
        public int Age // 속성
        {
            get
            {
                return DateTime.Now.Year - birth.Year;
            }
        }
    }
    class Property_읽기전용
    {
        static void Main(string[] args)
        {
            Console.Write("생년월일을 입력하시오. ");
            string tmp = Console.ReadLine();
            DateTime birthday = DateTime.Parse(tmp);

            //DateTime birthday = new DateTime(1992,8,24);

            Person p1 = new Person(birthday);
            Console.WriteLine("나이 : {0} ", p1.Age);
        }
    }
}
