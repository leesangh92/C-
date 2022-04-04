using System;

namespace CH07
{
    class Class_Constructor
    {
        class Date
        {
            private int yy;
            private int mm;
            private int dd;

            public Date() : this(2022, 1, 1) // 이웃 생성자 호출
            {
                Console.Write("Date() called : ");
                //yy = DateTime.Now.Year;
                //mm = DateTime.Now.Month;
                //dd = DateTime.Now.Day;
            }

            public Date(int yy, int mm, int dd)
            {
                this.yy = yy; // this 키워드
                this.mm = mm;
                this.dd = dd;
            }

            public void showData()
            {
                Console.WriteLine("{0}년, {1}월, {2}일", yy, mm, dd);
            }
        }

        static void Main(string[] args)
        {
            //Date d1 = new Date();
            //d1.showData();

            Date d2 = new Date(2022, 04, 05); // 생성자(메서드) Overloading
            d2.showData();

            Date d3 = new Date();
            d3.showData();
        }
    }
}
