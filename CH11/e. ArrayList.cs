using System;
using System.Collections;

namespace CH11
{
    class ArrayList2
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(100);
            list.Add(3.4);
            list.Add('A');
            list.Add("Hello");

            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);

            foreach (object tmp in list)
                Console.Write("{0}, ", tmp.ToString());
            Console.WriteLine();

            list.RemoveAt(1); // 첨자 위치 제거

            foreach (object tmp in list)
                Console.Write("{0}, ", tmp.ToString());
            Console.WriteLine();

            for (int i = 0; i < list.Count; i++)
                Console.Write("{0}, ", list[i]);
            Console.WriteLine();
        }
    }
}
