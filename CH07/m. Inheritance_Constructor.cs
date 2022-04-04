using System;

namespace CH07
{
    class Token
    {
        protected string name;

        public Token()
        {
            name = "Unknown";
            Console.WriteLine("Token : " + name);
        }

        public Token(string _name)
        {
            name = _name;
            Console.WriteLine("Token(string _name) : " + name);
        }
    }
    // this() 생성자 : 현재 클래스의 이웃생성자 호출
    // base() 생성자 : 기반 클래스의 생성자 호출
    class Command_Token : Token
    {
        public Command_Token(string _name) : base(_name)
        {
            Console.WriteLine("Command_Token() : " + name);
        }
    }

    class Inheritance_Constructor
    {
        static void Main(string[] args)
        {
            Command_Token c1 = new Command_Token("홍길동");
        }
    }
}
