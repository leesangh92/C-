using System;

namespace CH08
{
    interface ISendable
    {
        void Send(string msg1, string msg2, string msg3 = "");
    }

    //EMail클래스 : ISendable인터페이스를 상속받아, 고객에게 email로 메세지 전송
    class EMail : ISendable
    {
        public void Send(string s1, string s2, string s3 = "")
        {
            Console.WriteLine("Email {0} to {1}", s1, s2);
        }
    }
    //SMS클래스 : ISendable인터페이스를 상속받아, 고객에게 sms로 메세지 전송
    class SMS : ISendable
    {
        public void Send(string s1, string s2, string s3 = "")
        {
            Console.WriteLine("phone {0} to {1}, {2}", s1, s2, s3);
        }
    }
    class Sendable_Interface
    {
        static void Main(string[] args)
        {
            EMail e1 = new EMail();
            e1.Send("길동", "hong@naver.com");

            SMS s1 = new SMS();
            s1.Send("나리", "010-0000-0000", "배송완료!");
        }
    }
}
