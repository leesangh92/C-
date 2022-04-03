using System;

namespace CH10
{
    class OneArray
    {
        static void scoreInput(int[] _score)
        {
            for (int i = 0; i < _score.Length; i++)
            {
                Console.Write("{0} 성적 ? ", i + 1);

                _score[i] = int.Parse(Console.ReadLine());
            }
        }

        static void scoreOutput(int[] _score)
        {
            for(int i = 0; i < _score.Length; i++)
            {
                Console.Write("{0}, ", _score[i]);
            }
            Console.WriteLine();
        }

        static void scoreCalc(int[] _score)
        {
            int sum = 0, max = 0, min = 99999;

            for(int i = 0; i < _score.Length; i++)
            {
                sum += _score[i];

                if (max < _score[i])
                    max = _score[i];

                if (min > _score[i])
                    min = _score[i];
            }
            Console.WriteLine("합 : {0}, 평균 : {1}, max : {2}, min : {3}", sum, sum/_score.Length, max, min);
        }

        static void Main(string[] args)
        {
            int[] score = new int[5];

            scoreInput(score); // 학생 점수 입력
            scoreOutput(score); // 학생 점수 출력
            scoreCalc(score);
        }
    }
}
