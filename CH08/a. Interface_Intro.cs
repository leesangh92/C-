using System;

namespace CH08
{
    interface IToken // 인터페이스 선언, 구현은 없고 선언만 있다
    {
        void Name();
    }

    class Token : IToken
    {
        public void Name()
        {
            Console.WriteLine("Token Name() 메서드");
        }
    }

    class CommandToken : IToken
    {
        public void Name()
        {
            Console.WriteLine("CommandToken Name() 메서드");
        }
    }

    class Interface_Intro
    {
        static void Main(string[] args)
        {
            //IToken T1 = new IToken(); // 인터페이스는 객체 생성 불가

            Token t2 = new Token();
            t2.Name();

            CommandToken c1 = new CommandToken();
            c1.Name();


        }
    }
}
