using System;

namespace CH07
{
    class Employee
    {
        private string name; // 정보 은닉 보장을 위해 private 멤버변수로 선언
        private int salary; // 접근 지시자가 없으면 private이 default
        private string comAddr;

        public void Employee(string name, int salary, string comAddr)
        {
            this.name = name;
            this.salary = salary;
            this.comAddr = comAddr;
        }

        public void setData()
        {
            name = "홍길동";
            salary = 35000000;
            comAddr = "서울시 종로구 혜화동";
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
            emp1.setData();
            emp1.showData();

            Employee emp2 = new Employee("성춘향", 3700000, "서울시 강남구");
            emp2.showData();
        }
    }
}
