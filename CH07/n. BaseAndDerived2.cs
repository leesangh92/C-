using System;

namespace CH07
{
    class Base
    {
        protected string name;
        protected int salary;

        public Base()
        {
            name = "Base";
            salary = 0;
        }

        public void BaseMethod()
        {
            Console.WriteLine("BaseMethod() : {0}, {1}", name, salary);
        }
    }

    class Derived : Base
    {
        private string name;
        private string telno;

        public Derived()
        {
            this.name = "Derived";
            telno = "010-0000-0000";
            salary = 3500000;
        }

        public void DerivedMethod()
        {
            Console.WriteLine("DerivedMethod() : {0}, {1}, {2}, {3}", base.name, this.name, this.telno, base.salary);
            //Console.WriteLine("DerivedMethod() : {0}, {1}, {2}, {3}", base.name, name, telno, salary);
        }
    }

    class BaseAndDerived2
    {
        static void Main(string[] args)
        {
            Base b1 = new Base();
            b1.BaseMethod();

            Derived d1 = new Derived();
            d1.DerivedMethod();
        }
    }
}
