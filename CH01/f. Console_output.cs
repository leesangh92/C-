using System;

namespace CH01
{
    class ConsoleOutput
    {
        public static void Main()
        {
        //WriteLine
            Console.WriteLine(100);
            Console.WriteLine("hello");
            Console.WriteLine('가');
            Console.WriteLine(3.4);
            Console.WriteLine();

        //Parameter
            Console.WriteLine("{0}, {1}, {2}", 100, 200, 300);
            Console.WriteLine("{0}, {1}, {1}, {1}, {2}", 100, 200, 300); // 특정 인자를 여러번 출력
            Console.WriteLine();

        //Alignment or Format
            Console.WriteLine("{0, -10}", 999);
            Console.WriteLine("{0, 10}", 999); // 자리수 정렬
            Console.WriteLine("{0:C}", 123456789); // Currency(화폐단위)
            Console.WriteLine("{0:N}", 123456789); // 소수점
            Console.WriteLine("{0:N0}", 123456789); // 소수점 X
            Console.WriteLine("{0:X}", 123456789);
            Console.WriteLine();

            Console.WriteLine("{0}", 0);
            Console.WriteLine("{0:#,###}", 0); // 0일때는 값을 찍지 않는다.
            Console.WriteLine("{0:#,##0}", 0); // 0도 찍는다. 
            Console.WriteLine("{0:#,###}", 123456789);
            Console.WriteLine("{0:#,##0}", 123456789);
            Console.WriteLine();

            decimal tmp = 20.5M;
            string s = string.Format("온도 {0} 입니다.", tmp); // format 형식으로 저장
            Console.WriteLine(s);

        //Special string
            //Console.WriteLine("\\server\share"); // \n
            Console.WriteLine("\\\\server\\share"); // \\중 앞의 \는 뒤의 \를 문자로 만든다는 뜻.
            Console.WriteLine(@"\\server\share"); // @ 뒤에 나오는 \ 는 전부 문자로 만든다.
        }
    }
}
