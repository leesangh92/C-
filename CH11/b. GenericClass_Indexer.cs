using System;

namespace CH11
{
    class MyList<T>
    {
        private T[] array;

        public MyList()
        {
            array = new T[3];
        }
        public T this[int index]
        {
            get { return array[index]; }
            set { 
                if(index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine("array.Length : ", array.Length);
                }
                array[index] = value; 
            }
        }
        public int length()
        {
            return array.Length;
        }
    }
    class GenericClass_Indexer
    {
        static void Main(string[] args)
        {
            MyList<string> strList = new MyList<string>();
            strList[0] = "하나";
            strList[1] = "two";
            strList[2] = "three";
            for (int i = 0; i < strList.length(); i++)
                Console.WriteLine(strList[i]);
            Console.WriteLine();

            MyList<int> intList = new MyList<int>();
            intList[0] = 100;
            intList[1] = 200;
            intList[2] = 300;
            intList[3] = 400; //할당된 배열 크기보다 크다 //Resize로 배열 크기 재조정
            for (int i = 0; i < intList.length(); i++)
                Console.WriteLine(intList[i]);
        }
    }
}
