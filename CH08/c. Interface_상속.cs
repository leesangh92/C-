using System;

namespace CH08
{
    interface IA
    {
        void foo1();
    }
    interface IB
    {
        void foo2();
    }
    interface IC : IA, IB       //인터페이스가 인터페이스를 상속받음
    {
        void foo3();
    }
    class ABC : IC
    {
        public void foo1()
        {
            Console.WriteLine("foo1()");
        }
        public void foo2()
        {
            Console.WriteLine("foo2()");
        }
        public void foo3()
        {
            Console.WriteLine("foo3()");
        }
    }
    class Interface_상속
    {
        static void Main(string[] args)
        {
            ABC abc = new ABC();
            abc.foo1();
            abc.foo2();
            abc.foo3();
            Console.WriteLine();

            IA a1 = abc;    //IA 메서드만 사용가능
            a1.foo1();

            IB b1 = abc;
            b1.foo2();

            IC c1 = abc;    //IC는 상속받아서 부모인터페이스 메서드도 접근가능
            c1.foo1();
            c1.foo2();
            c1.foo3();
        }
    }
}
