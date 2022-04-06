using System;
using System.Collections;

namespace CH11
{
    class HashtableProgram
    {
        public static void DataShow(Hashtable htList)
        {
            IDictionaryEnumerator myEnum = htList.GetEnumerator(); // 컬렉션에서 반복하는 반복자를 반환

            while (myEnum.MoveNext())
                Console.WriteLine("{0}, {1}", myEnum.Key, myEnum.Value);
        }
        static void Main(string[] args)
        {
            Hashtable nameHT = new Hashtable();

            nameHT.Add("홍길동", 3500000);
            nameHT.Add("이몽룡", 2500000);
            nameHT.Add("성춘향", 5700000);
            nameHT.Add("진달래", 2900000);

            DataShow(nameHT);
            Console.WriteLine();

            bool ret = nameHT.Contains("이몽룡");
            Console.WriteLine("이몽룡 존재 여부 : {0}", ret);
            Console.WriteLine();

            nameHT.Remove("이몽룡");
            DataShow(nameHT);
            Console.WriteLine();

            //컬렉션의 크기, 열거자 등 사용
            ICollection myKey = nameHT.Keys;
            foreach (object item in myKey)
                Console.WriteLine("{0}, ", item);
            Console.WriteLine();

            ICollection myValue = nameHT.Values;
            foreach (object item in myValue)
                Console.WriteLine("{0}, ", item);
            Console.WriteLine();
        }
    }
}
