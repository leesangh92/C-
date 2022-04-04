using System;

namespace CH07
{
    class Point
    {
        public double x; // 멤버 변수
        public double y;
    }

    class Class_Intro
    {
        static void Main(string[] args)
        {
            Point c1 = new Point();
            Point c2 = new Point();
            Point c3;

            c1.x = 1.0;
            c1.y = 1.5;
            c2.x = 2.0;
            c2.y = 2.5;
            Console.WriteLine("c1 : {0}, {1}", c1.x, c1.y);
            Console.WriteLine("c2 : {0}, {1}", c2.x, c2.y);

            c3 = c1;

            if (c1 == c2)
                Console.WriteLine("Equal !!!");
            else
                Console.WriteLine("Not Equal !!!");

            if (c1 == c3)
                Console.WriteLine("Equal !!!");
            else
                Console.WriteLine("Not Equal !!!");

            c3.x = 3.0;
            c3.y = 3.5;
            Console.WriteLine("c1 : {0}, {1}", c1.x, c1.y);

            c1 = null; // 동적 할당은 가비지컬렉터가 자동으로 해제한다.
            c2 = null; // 객체를 참조하는 reference count를 감소하여 0이 되면 가비지컬렉터(GC)의 더 빠른 해제를 유도하기 때문에 null값을 준다.
            c3 = null;
        }
    }
}
