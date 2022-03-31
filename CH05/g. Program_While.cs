using System;

namespace WhileStatement
{
    class ConsoleApplication
    {
        static void Main(string[] args)
        {
            char ch = (char)65;

            //while(true) => 무한loop, while(1) Error

            while (ch < 'Z')
            {
                Console.Write("{0} ", ch);
                ch++;
            }
            Console.WriteLine();

            ch = (char)65;
            do
            {
                Console.Write("{0} ", ch);
                ch++;
            } while (ch < 'Z');
            Console.WriteLine();

        }
    }
}

