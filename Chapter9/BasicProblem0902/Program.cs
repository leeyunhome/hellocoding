using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem0902
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            int totalScore = 0;
            for (int i = 0; i < 5; ++i)
            {
                Console.Write(i);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[i] = int.Parse(Console.ReadLine());
                totalScore += scores[i];
            }

            Console.Write("총점은 ");
            Console.Write(totalScore);
            Console.WriteLine("점입니다.");
        }
    }
}
