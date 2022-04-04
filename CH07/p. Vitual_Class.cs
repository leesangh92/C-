using System;

namespace CH07
{
    //class Sealed Token // sealed(봉인클래스) : overriding 불가
    class Token
    {
        public virtual void Name() // 가상함수
        {
            Console.WriteLine("Token()");
        }
    }

    class Command_Token : Token
    {
        public override void Name() // override : 재정의
        {
            //base.Name();
            Console.WriteLine("Commnad_Token");
        }
    }

    class Online_Command_Token : Command_Token
    {
        public new void Name() // new : 재정의 하지 않음
        {
            Console.WriteLine("Online_Command_Token");
        }
    }

    class Vitual_Class
    {
        static void Main(string[] args)
        {
            Token t1 = new Token();
            Token t2 = new Command_Token();
            Token t3 = new Online_Command_Token();

            t1.Name();
            t2.Name();
            t3.Name();
        }
    }
}
