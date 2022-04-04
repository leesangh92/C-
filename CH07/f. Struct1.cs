using System;

namespace CH07
{
    struct Employee
    {
        private string name;
        private int salary;
        private DateTime birth;

        // 구조체의 Default 생성자는 명시적 호출하지 못한다.
        //public Employee() // 구조체는 빈 괄호 생성자를 만들 수 없다.
        //{
        //    Console.WriteLine("Employee() called.");
        //}

        public Employee(string _name, int _salary, DateTime _birth)
        {
            name = _name;
            salary = _salary;
            birth = _birth;
        }

        //public Employee(string _name, int _salary) // 구조체 생성자는 부분 초기화를 허용하지 않는다.
        //{
        //    name = _name;
        //    salary = _salary;
        //}

        public void showData()
        {
            Console.WriteLine("{0}, {1}, {2}", name, salary, birth);
        }
    }

    class ConsoleApp
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.showData();

            Employee e2 = new Employee("길동이", 2700000, DateTime.Parse("2022-01-01"));
            e2.showData();

            //Employee e3 = new Employee("홍길동", 3500000);
            //e3.showData();

            //Employee e4; // 구조체는 new로 할당해서 사용해야한다. (할당되지 않은 구조체 변수)
            //e4.showData();
        }
    }
}
