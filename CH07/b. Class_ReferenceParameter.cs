using System;

namespace CH07
{
    class Point
    {
        public double x;
        public double y;
    }

    class Class_ReferenceParameter
    {
        static void PassByVal(Point _c1)
        {
            Console.WriteLine("_c1 : {0}, {1}", _c1.x, _c1.y);
            _c1.x++;
            _c1.y++;

            _c1 = new Point();
        }

        static void PassByRef(ref Point _c1)
        {
            Console.WriteLine("_c1 : {0}, {1}", _c1.x, _c1.y);
            _c1.x++;
            _c1.y++;

            _c1 = new Point();
        }

        static void PassByOut(out Point _c2)
        {
            _c2 = new Point();

            _c2.x = 5.0;
            _c2.y = 5.5;
        }

    static void Main(string[] args)
        {
            Point c1 = new Point();

            c1.x = 1.0;
            c1.y = 1.5;

            PassByVal(c1);
            Console.WriteLine("PassByVal(c1) : {0}, {1}", c1.x, c1.y);

            PassByRef(ref c1);
            Console.WriteLine("PassByRef(c1) : {0}, {1}", c1.x, c1.y);

            Point c2;
            PassByOut(out c2);
            Console.WriteLine("PassByOut(out c2) : {0}, {1}", c2.x, c2.y);
        }
    }
}
