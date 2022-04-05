using System;

namespace ConsoleApp7
{
    interface IEmployee   //인터페이스 속성
    {
        string Name { get; set; }
        string Telno { get; set; }

        void ShowData();  //묵시적으로 public이다.
    }

    public class Employee : IEmployee
    {
        public string Name { get; set; }  //인터페이스 상속멤버, 자동속성멤버

        private string mTelno;            //일반 private 멤버
        private int mSalary;              //일반 private 멤버

        public string Telno  //인터페이스 상속멤버, 일반속성멤버 
        {
            get { return this.mTelno; }
            set
            {
                if (value.Length > 15)
                    this.mTelno = "over flow...";
                else
                    this.mTelno = value;
            }
        }

        public int Salary
        {
            get { return this.mSalary; }
            set
            {
                if (value < 0 || value > 7000000)
                    this.mSalary = -1;
                else
                    this.mSalary = value;
            }
        }

        public Employee()
        {
            this.Name = "";
            this.Telno = "";
            this.Salary = 0;
        }

        public Employee(string _Name, string _Telno, int _Salary)
        {
            this.Name = _Name;
            this.Telno = _Telno;   //속성필드에서 크기 체크
            this.Salary = _Salary; //속성필드에서 범위 체크
        }

        public void ShowData()
        {
            Console.WriteLine("사원정보: {0}, {1}, {2} ", Name, Telno, Salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.ShowData();

            Employee e2 = new Employee("kim", "010-1234", 3400000);
            e2.ShowData();

            Employee e3 = new Employee("lee", "010-12345678901234567890", 7400000);
            e3.ShowData();
            Console.WriteLine("\n==================================================\n");


            Customer c1 = new Customer();
            c1.Name = "김부장";
            c1.Telno = "030-12345";
            c1.Position = "부장대우";
            c1.ShowData();

            Customer c2 = new Customer();
            c2.Name = "박이사";
            c2.Telno = "030-123456789123456789";
            c2.Position = "이사대우";
            c2.ShowData();

        }
    }

    public class Customer : IEmployee
    {
        public string Name { get; set; }       //상속자동속성멤버
        public string Position { get; set; }   //자동속성필드
        private string mTelno;                 //일반 private 멤버

        public string Telno   //상속속성멤버
        {
            get { return this.mTelno; }
            set
            {
                if (value.Length > 15)
                    this.mTelno = "over flow...";
                else
                    this.mTelno = value;
            }
        }

        public Customer()
        { }

        public Customer(string _name, string _tel, string _pos)
        {
            Name = _name;
            mTelno = _tel;
            Position = _pos;
        }

        public void ShowData()
        {
            Console.WriteLine("고객정보: {0}, {1}, {2} ", Name, Telno, Position);
        }
    }
}
