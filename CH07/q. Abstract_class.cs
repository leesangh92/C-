using System;


namespace CH07
{
    abstract class Token // 추상클래스
    {
        protected string str;

        //public void Token()
        //{
        //    Console.WriteLine("Token.");
        //}

        public Token(string _str)
        {
            Console.WriteLine("Token(string _str)");
            str = _str;
        }

        public void Hi()
        {
            Console.WriteLine("Hi.");
        }

        public virtual void Name()
        {
            Console.WriteLine("Token." + str);
        }

        public abstract void Length(); // 추상메서드 Length() 바디가 없으므로 아래에서는 반드시 구현
    }

    class CommandToken : Token
    {
        public CommandToken(string _str) : base(_str)
        {
            Console.WriteLine("CommandToken(string _str)" + base.str);
        }

        public override void Name()
        {
            Console.WriteLine("CommandToken." + base.str);
        }

        public override void Length() // 추상메서드 Length() 바디가 없으므로 반드시 구현
        {
            Console.WriteLine("Length.");
        }
    }

    class Abstract_class
    {
        static void Main(string[] args)
        {
            //Token t1 = new Token(); // 추상클래스 객체 생성 불가
            //t1.Hi();
            //t1.Name();
            //t1.Length();
            //Console.WriteLine();

            Token t2 = new CommandToken("홍길동");
            t2.Hi();
            t2.Name();
            t2.Length();
        }
    }
}
