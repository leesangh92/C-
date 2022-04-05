using System;

namespace CH08
{
    class StringList
    {
        string[] list = new string[10];

        public string this[int index] // this가 indexer
        {
            set { list[index] = value; }
            get { return list[index]; }
        }
        public int length()
        {
            return list.Length; // 배열이 제공하는 속성
        }
    }
    class Indexer_Intro
    {
        static void Main(string[] args)
        {
            StringList myList = new StringList();

            myList[0] = "하나"; // set
            myList[1] = "two";
            myList[2] = "Hello World!!!";

            Console.WriteLine("myList.length() : {0}", myList.length());

            for(int i = 0; i < myList.length(); i++)
            {
                if (myList[i] != null)
                    Console.WriteLine(myList[i]); // get
                else
                    break;
            }
        }
    }
}
