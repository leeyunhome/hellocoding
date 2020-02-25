using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem0801
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int[] scores = new int[5];
            int totalScore = 0;
            while (n < 5)
            {
                Console.Write(n);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[n] = int.Parse(Console.ReadLine());

                totalScore = totalScore + scores[n];
                n++;
            }

            Console.Write("총점은 ");
            Console.Write(totalScore);
            Console.WriteLine("점입니다.");
        }
    }
}
