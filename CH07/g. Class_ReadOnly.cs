using System;

namespace CH07
{
    class Car
    {
        //readonly와 const의 차이
        private readonly int count = 5;
        private const int speed = 10;

        public Car()
        { }

        public Car(int _n)
        {
            count = _n; // 생성자에서 readonly 필드 단 한 번 수정가능
            //speed = _n; // const 멤버는 변경 불가능
        }

        public void showData()
        {
            Console.WriteLine("count : {0}", count);
            Console.WriteLine("speed : {0}", speed);
        }
    }

    class Class_ReadOnly
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.showData();

            Car c2 = new Car(20);
            c2.showData();
        }
    }
}
