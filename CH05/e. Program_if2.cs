using System;

namespace IfStatement
{
	class Program
	{
		static void Main(string[] args)
		{
            int x, y , z, max;

            Console.Write("세 수를 입력하세요 ? ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            Console.WriteLine("x:{0}, y; {1}, z:{2}", x, y, x);
            if (x > y)
            {
                if (y > z)
                    max = x;
                else
                    max = z;
            }
            else if (y > z)
                max = y;
            else
                max = z;

            Console.WriteLine("max : {0}", max);
		}
	}
}
