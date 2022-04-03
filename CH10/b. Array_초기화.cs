using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10
{
    class Array_초기화
    {
        static void Main(string[] args)
        {
            int[] row1 = new int[3] { 1, 2, 3 }; // 배열 초기화
            int[] row2 = new int[] { 1, 2, 3 }; // 배열 초기화 시에만 배열인자 개수 생략 가능
            int[] row3 = { 1, 2, 3 }; // 배열 초기화 시에만 생략 가능

            for(int i = 0; i < row3.Length; i++)
                Console.WriteLine("{0}, {1}, {2}", row1[i], row2[i], row3[i]);
            Console.WriteLine();
           int[] row4;
            row4 = new int[4] { 1, 2, 3, 4 };

            int[] row5 = new int[4];
            for (int i = 0; i < row3.Length; i++)
                Console.WriteLine("{0}, {1}", row4[i], row5[i]);
            Console.WriteLine();

            int[] row6;
            //row6 = {1, 2, 3, 4, 5}; // 대입문이기 때문에 배열 초기화와는 다르다. 

            //int[] row7 = new int[2] { 1 }; // 배열크기와 인자 개수가 같아야한다. 
            //int[] row8 = new int[2] { }; // 초기화할 때는 인자 생략은 불가능하다. 
        }
    }
}
