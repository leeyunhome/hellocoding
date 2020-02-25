using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deep8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("총 학생수 : ");
            int totalStudentCount = int.Parse(Console.ReadLine());
            string[] subjects = { "국어", "영어", "수학" };
            int[] scores = new int[3];
            //int[] students = new int[totalStudentCount];
            int index = 0;
            int score_index = 0;
            int[] total = new int[3];

            while (index < totalStudentCount)
            {
                Console.Write(index);
                Console.WriteLine("번째 학생의 점수를 입력하세요.");
                while (score_index < 3)
                {
                    Console.Write(subjects[score_index]);
                    scores[score_index] = int.Parse(Console.ReadLine());
                    total[index] = total[index] + scores[score_index];
                    score_index = score_index + 1;
                }
                score_index = 0;
                index = index + 1;
            }

            index = 0;
            while (index < totalStudentCount)
            {
                Console.Write(index);
                Console.Write("번째 학생의 총점 : ");
                Console.WriteLine(total[index]);
                Console.Write(index);
                Console.Write("번째 학생의 평균 : ");
                Console.WriteLine(total[index] / 3);

                index = index + 1;
            }
        }
    }
}
