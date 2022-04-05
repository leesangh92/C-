using System;

namespace CH08
{
    interface IToken1
    {
        void Name();
    }

    interface IToken2
    {
        void Name();
        void Accept();
    }

    class Token : IToken1, IToken2
    {
        void IToken1.Name()
        {
            Console.WriteLine("Name() 메서드");
        }

        void IToken2.Name()
        {
            Console.WriteLine("Name() 메서드");
        }

        public void Accept()
        {
            Console.WriteLine("Accept() 메서드");
        }
    }

    class Interface_다중성
    {
        static void Main(string[] args)
        {
            //Token t1 = new Token(); // 상속받은 인터페이스에 있는 자원을 모두 사용 가능
            //t1.Name();
            //t1.Accept();

            //IToken1 t2 = new Token(); // 인터페이스에 있는 자원만 사용 가능
            //t2.Name();

            //IToken2 t3 = new Token();
            //t3.Accept();

            Token t1 = new Token();
            t1.Accept();

            IToken1 t2 = t1; // t1을 IToken1 타입으로 형변환, 인터페이스 형변환
            t2.Name();

            IToken2 t3 = t1; // t1을 IToken2 타입으로 형변환
            t3.Accept();
            t3.Name();
        }
    }
}
