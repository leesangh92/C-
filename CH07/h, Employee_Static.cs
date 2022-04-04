using System;

namespace CH07
{
    class Employee
    {
        private string name; // 정보 은닉 보장을 위해 private 멤버변수로 선언
        private int salary; // 접근 지시자가 없으면 private이 default
        private string comAddr;

        private static int sudang; // 정적멤버 추가 // 클래스 객체 변수가 공유

        public Employee()
        {
            Console.WriteLine("publicEmployee() called."); // 객체가 생성될 때마다 실행
            sudang = 100000;
        }

        static Employee()
        {
            Console.WriteLine("static Employee() called."); // 객체가 처음 생성될 때 new 하기 전 한 번만 실행
        }

        public Employee(string name, int salary, string comaddr)
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
            Console.WriteLine("{0}, {1}, {2}", name, salary == 0 ? salary : salary+sudang, comAddr);
        }

        static public void M_sudang(int _su)
        {
            sudang = _su;
        }
    }

    class Employee_PrivateMember
    {
        static void Main(string[] args)
        {
            Employee.M_sudang(300000); // 정적메서드 호출

            Employee e1 = new Employee();
            e1.showData();

            Employee e2 = new Employee("성춘향", 3700000, "서울시 강남구");
            e2.showData();
        }
    }
}
