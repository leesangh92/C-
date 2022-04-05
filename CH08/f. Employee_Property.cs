using System;

namespace CH07
{
    class Employee
    {
        private string name;
        private int salary;
        private string comAddr;

        public Employee()
        { }
        public Employee(string _name, int _salary, string _comAddr)
        {
            this.name = _name;
            this.salary = _salary;
            this.comAddr = _comAddr;
        }
        public string Name // property 생성
        {
            get { return name; }
            set { name = value; }
        }
        public int Salary
        {
            get { return salary; }
            set {
                if (value >= 0 && value <= 7000000)
                    salary = value;
                else
                {
                    Console.WriteLine("월급은 0 ~ 7000000 사이의 값을 입력!!!");
                    salary = 0;
                }
            }
        }
        public string ComAddr
        {
            get { return comAddr; }
            set { comAddr = value; }
        }
        public void showData()
        {
            Console.WriteLine("{0}, {1}, {2}", name, salary, comAddr);
        }
    } // class Employee End.

    class Employee_Property
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.showData();

            Employee emp2 = new Employee("성춘향", 3700000, "서울시 강남구");
            emp2.showData();

            Employee emp3 = new Employee();
            emp3.Name = "홍길동"; // set
            emp3.Salary = 9000000;
            emp3.ComAddr = "부산시 해운대구";

            Console.WriteLine("{0}, {1}, {2}", emp3.Name, emp3.Salary, emp3.ComAddr); // get
        }
    }
}