using System;

namespace CH07
{
    class Employee
    {
        private string name; // 정보 은닉 보장을 위해 private 멤버변수로 선언
        private int salary; // 접근 지시자가 없으면 private이 default
        private string comAddr;

        public Employee()
        { }

        public Employee(string _name, int _salary, string _comAddr)
        {
            name = _name;
            salary = _salary;
            comAddr = _comAddr;
        }


        public void showData()
        {
            Console.WriteLine("{0}, {1}, {2}", name, salary, comAddr);
        }

        public void Addsalary(int _sudang)
        {
            salary += _sudang;
        }

        public Employee Deepcopy() // this e1
        {
            Employee newCopy = new Employee();

            newCopy.name = this.name;
            newCopy.salary = this.salary;
            newCopy.comAddr = this.comAddr;

            return newCopy;
        }
    }

    class Employee_Deepcopy
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("성춘향", 3700000, "서울시 강남구");
            e1.showData();

            Employee tmp;
            tmp = e1; // 참조복사
            tmp.Addsalary(200000);
            tmp.showData();
            e1.showData();

            Employee e2 = new Employee("길동이", 2000000, "서울시 강남구");
            Employee tmp2 = e2.Deepcopy();
            tmp2.Addsalary(500000);
            tmp2.showData();
            e2.showData();
        }
    }
}
