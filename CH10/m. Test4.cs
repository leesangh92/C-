using System;

/*
 * 성명(name), 월급(salary), 회사주소(comAddr) 배열에 데이터를 입력한 수 데이터와 함께 월급 평균을 출력.
 * 배열 선언은 Main() 에서, 데이터는 자식메서드에서 입력
 * 출력은 Main() 에서 한다.
 * 단 5명을 넘지 않는다. 5명 입력전 성명이 'end' 이면 입력은 종료('end'는 대소문자 구분 X)
 */

namespace CH10
{
    class Test4
    {
        static int Input(string[] _names, int[] _salary, string[] _comAddr)
        {
            int i;
            
            for(i = 0; i < _names.Length; i++)
            {
                Console.Write("성명 (입력 종료 시 'end') : ");
                _names[i] = Console.ReadLine();

                if (string.Compare(_names[i], "end", true) == 0)
                    break;

                Console.Write("월급 : ");
                _salary[i] = int.Parse(Console.ReadLine());

                Console.Write("회사 주소 : ");
                _comAddr[i] = Console.ReadLine();
            }
            return i;
        }

        static void Main(string[] args)
        {
            string[] names= new string[5];
            int[] salary= new int[5];
            string[] comAddr= new string[5];
            int size, salTot = 0;

            size = Input(names, salary, comAddr); // 입력 개수가 바뀌기 때문에 size를 통해 입력받은 데이터 개수를 파악한다.

            Console.WriteLine();
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}, {1:N0}, {2}", names[i], salary[i], comAddr[i]);
                salTot += salary[i];
            }

            if (size != 0) // 입력받은 데이터가 없으면 계산이 되지 않기 때문에 확인한다.
                Console.WriteLine("월급 평균 : {0}", salTot / size);
        }
    }
}
