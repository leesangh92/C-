using System;

namespace CH10
{
    class String_Method
    {
        static void Main()
        {
            string s1 = "Hello";
            Console.WriteLine(s1);

            s1 = "World"; // 자동 메모리 할당 및 해제
            Console.WriteLine(s1);
            Console.WriteLine();

            string s2 = "C is great !";
            string s3 = s2.Insert(1, "#"); // 지정한 인덱스에 문자열 삽입
            Console.WriteLine(s3);
            Console.WriteLine();

            int len = s3.Length; // 문자열 길이
            Console.WriteLine("문자열 길이 : {0}", len);
            Console.WriteLine();

            string s4 = string.Copy(s1); // 복사
            Console.WriteLine(s4);
            Console.WriteLine();

            string s5 = s4; // 메모리를 새롭게 할당하여 저장
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            s4 = "Campus";
            Console.WriteLine(s5);
            Console.WriteLine();

            string s6 = string.Concat("One", "Two", "Three"); // 문자열 잇기
            Console.WriteLine(s6);
            Console.WriteLine();

            string s7 = string.Concat("Multi", s4);
            Console.WriteLine(s7);
            Console.WriteLine();

            string s8 = "Hello World!!!";
            int n1 = s8.IndexOf("World"); // 문자열의 시작 인덱스 찾기(없으면 -1 출력)
            Console.WriteLine("s8.IndexOf(\"World\") : {0}", n1);
            Console.WriteLine();

            string a1 = "Apple"; // 대소문자는 다르다.
            string a2 = "apple";
            if (a1 == a2)
                Console.WriteLine("Equal !!!");
            else
                Console.WriteLine("Not Equal !!!");
            Console.WriteLine();

            if (a1.ToUpper().Equals(a2.ToUpper())) // 모두 대문자로 만들어서 같은지 비교(소문자로도 가능)
                Console.WriteLine("Equal !!!");
            else
                Console.WriteLine("Not Equal !!!");
            Console.WriteLine();

            int n2 = string.Compare(a1, a2, true); // 대소문자 구분하지 않고 문자열 비교
            //int n2 = string.Compare(a1, a2, false); // 대소문자 구분해서 문자열 비교
            Console.WriteLine("string.Compare(a1, a2, true) : {0}", n2); // 문자열이 같으면 0을 반환 다르면 0이 아닌 수를 반환
            Console.WriteLine();

            string s9 = s8.Substring(0, 5); // 기존 문자열의 일부분 호출
            Console.WriteLine(s9);
            Console.WriteLine();
        }
    }
}
