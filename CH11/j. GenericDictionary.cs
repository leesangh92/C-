using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDictionarycs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> name1 = new Dictionary<string, string>();
            Dictionary<char, string> name2 = new Dictionary<char, string>();
            Dictionary<int, int> name3 = new Dictionary<int, int>();

            name1["첫번째"] = "안재은";
            name1["두번째"] = "까꿍이";
            name1["세번째"] = "예쁜이";

            Console.Write(name1["첫번째"]);
            Console.Write(name1["두번째"]);
            Console.WriteLine(name1["세번째"]);

            name2['z'] = "C++";
            name2['A'] = "C# ";
            name2['B'] = "Program.";
            Console.Write(name2['A']);
            Console.WriteLine(name2['B']);

            name3[0] =1000;
            name3[1] = 2000;
            Console.Write("{0}, ", name3[0]);
            Console.WriteLine(name3[1]);
            Console.WriteLine();

            foreach (var item in name1)  //키,value 모두 출력
            {
                Console.Write("{0}, ", item);
            }
            Console.WriteLine("\n");

            foreach (KeyValuePair<string, string> tmp in name1)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    tmp.Key, tmp.Value);
            }

            foreach (char key  in name2.Keys)
            {
                Console.WriteLine(key);      
            }

            foreach (string value in name2.Values)
            {
                Console.WriteLine(value);
            }

            foreach(KeyValuePair<string, string> tmp in name1)
            {
                Console.WriteLine("Key = {0}, Value = {1}", tmp.Key, tmp.Value);
            }
        }
    }
}
