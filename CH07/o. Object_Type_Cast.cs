using System;

namespace CH07
{
    class Token
    {
        public void Name()
        {
            Console.WriteLine("Token()");
        }
    }

    class Command_Token : Token
    {
        public void Name() // Method Overriding(메서드 재정의)
        {
            //base.Name();
            Console.WriteLine("Commnad_Token");
        }
    }

    class Online_Command_Token : Command_Token
    {
        public void Name() // Method Overriding(메서드 재정의)
        {
            Console.WriteLine("Online_Command_Token");
        }
    }

    class Object_Type_Cast
    {
        static void Main(string[] args)
        {
            Token t1 = new Token();
            t1.Name();
            // 파생클래스에서 동일한 이름의 메서드가 호출되면 기반클래스의 메서드는 가려진다. 
            Command_Token c1 = new Command_Token();
            c1.Name();

            Online_Command_Token oc1 = new Online_Command_Token();
            oc1.Name();
            Console.WriteLine();

            Token t2, t3;
            t2 = new Command_Token(); // Upcast
            t3 = new Online_Command_Token();

            // 파생클래스 객체가 기반클래스 객체 변수에 대입되면 기반클래스 메서드가 호출된다. 
            t2.Name();
            t3.Name();

            //Command_Token c2 = new Token(); // Downcast // 오류

            if(t2 is Command_Token) // is 메서드 : 형변환이 가능한지 확인. 형변환 가능하면 true, 형변환 불가능하면 false
            {
                c1 = (Command_Token)t2;
                c1.Name();
            }

            Online_Command_Token oc2 = t3 as Online_Command_Token; // as 메서드 : 무조건 형변환. 형변환 불가능하면 null
            if (oc2 != null)
                oc2.Name();
        }
    }
}
