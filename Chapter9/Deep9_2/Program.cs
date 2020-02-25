using System;

namespace Deep9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] scores = new int[5,10];

            int j;
            for (j = 0; j < 5; ++j)
            {
                for (int i = 0; i < 10; ++i)
                {
                    Console.Write(j + 1);
                    Console.Write("반 ");
                    Console.Write(i + 1);
                    Console.WriteLine("번 학생의 성적을 입력하세요.");
                    scores[j,i] = int.Parse(Console.ReadLine());
                }
            }

            for (j = 0; j < 5; ++j)
            {
                Console.Write(j + 1);
                Console.Write("반 평균은");
                int totalScore = 0;
                for (int i = 0; i < 10; ++i)
                {
                    totalScore += scores[j, i];
                }
                Console.Write(totalScore / 10);
                Console.WriteLine("점 입니다.");
            }

        }
    }
}
