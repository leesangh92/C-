using System;

namespace CH08
{
    class Employee
    {
        private int salary;

        public string Name // auto property 생성 // 조작이 필요없는 멤버는 auto property로 생략해줄 수 있다.
        {
            get;
            set;
        }
        public string ComAddr
        {
            get;
            set;
        }
        public int Salary // 조작이 필요한 멤버는 구현해주어야한다
        {
            get { return salary; }
            set
            {
                if (value >= 0 && value <= 7000000)
                    salary = value;
                else
                {
                    Console.WriteLine("월급은 0 ~ 7000000 사이의 값을 입력!!!");
                    salary = 0;
                }
            }
        }
        public Employee()
        { }
        public Employee(string _name, int _salary, string _comAddr)
        {
            this.Name = _name;
            this.Salary = _salary;
            this.ComAddr = _comAddr;
        }
        public void showData()
        {
            Console.WriteLine("{0}, {1}, {2}", Name, Salary, ComAddr);
        }
    } // class Employee End.
    class Employee_Auto_Property
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.showData();

            Employee emp2 = new Employee("성춘향", 3700000, "서울시 강남구");
            emp2.showData();

            Employee emp3 = new Employee();
            emp3.Name = "홍길동";
            emp3.Salary = 3500000;
            emp3.ComAddr = "부산시 해운대구";
            Console.WriteLine("{0}, {1}, {2}", emp3.Name, emp3.Salary, emp3.ComAddr);

            Employee emp4 = new Employee() // 객체 생성 시 속성멤버 초기화 가능
            {
                Name = "이몽룡",
                Salary = 2800000,
                ComAddr = "서울시 종로구"
            };
            emp4.showData();
        }
    }
}
