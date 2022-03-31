using System;

namespace PrimitiveTypes
{
    class SimpleType1
    {
        public static void Main()
        {
        //Integet Type
            sbyte sbyte1 = 127;
            SByte Sbyte1 = -127;
            byte byte1 = 250;
            int int1 = 3500000;
            Int32 int2 = -3500000;
            long longint1 = 2700000000;

            int 나이 = 30;

            Console.WriteLine(sbyte1);
            Console.WriteLine(Sbyte1);
            Console.WriteLine(byte1);
            Console.WriteLine(int1);
            Console.WriteLine(int2);
            Console.WriteLine(longint1);

            Console.WriteLine(나이);
            Console.WriteLine();

        //실수형 Type
            float float1 = 1.23F; // F 접미사(float type)
            double double1 = 3.14159;
            Double Double1 = 9.87;
            decimal decimal1 = 12456789.123M; // M 접미사(decimal type)

            Console.WriteLine(float1);
            Console.WriteLine(double1);
            Console.WriteLine(Double1);
            Console.WriteLine(decimal1);
            Console.WriteLine();

        // 문자형 Type
            char char1 = 'A';
            string string1 = "Hello";
            bool bool1 = true; // true, false 만 가능.(True, False 불가능)

            Console.WriteLine(char1);
            Console.WriteLine(string1);
            Console.WriteLine(bool1);
            Console.WriteLine();

            Console.WriteLine("{0}, {1}, {2}", sizeof(bool), sizeof(char), sizeof(decimal)); // 자료형의 크기 O
            //Console.WriteLine("{0}, {1}, {2}", sizeof(bool1), sizeof(char1), sizeof(decimal1)); // 변수의 크기 X
        }
    }
}
