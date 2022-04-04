using System;

namespace CH07
{
    class Base // 부모클래스
    {
        protected string name; // 상속클래스에서의 접근을 허용

        public void BaseMethod()
        {
            name = "Base";
            Console.WriteLine("BaseMethod() : {0}", this.name);
        }
    }

    class Derived : Base // 상속클래스
    {
        public void DerivedMethod()
        {
            name = "Derived";
            Console.WriteLine("DerivedMethod() : {0}", this.name);
        }
    }

    class BaseAndDerived
    {
        static void Main(string[] args)
        {
            Base b1 = new Base();
            b1.BaseMethod();

            Derived d1 = new Derived();
            d1.DerivedMethod();
            d1.BaseMethod();
        }
    }
}
