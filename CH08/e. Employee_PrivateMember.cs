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

        public void setName(string _name)
        {
            name = _name;
        }
        public void setSalary(int _salary)
        {
            salary = _salary;
        }
        public void setcomAddr(string _comAddr)
        {
            comAddr = _comAddr;
        }
        public string getName()
        {
            return name;
        }
        public int getSalary()
        {
            return salary;
        }
        public string getcomAddr()
        {
            return comAddr;
        }
        public void showData()
        {
            Console.WriteLine("{0}, {1}, {2}", name, salary, comAddr);
        }
    }

    class Employee_PrivateMember
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.showData();

            Employee emp2 = new Employee("성춘향", 3700000, "서울시 강남구");
            emp2.showData();

            Employee emp3 = new Employee();

            emp3.setName("홍길동");
            emp3.setSalary(3500000);
            emp3.setcomAddr("서울시 서초구");

            Console.WriteLine("{0}, {1}, {2}", emp3.getName(), emp3.getSalary(), emp3.getcomAddr());
        }
    }
}
