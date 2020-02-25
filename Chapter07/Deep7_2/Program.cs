using System;

namespace Deep7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = { "국어", "영어", "수학", "과학", "사회" };
            int[] scores = new int[5];

            Console.Write(subjects[0]);
            Console.WriteLine(" 점수를 입력하세요. ");
            scores[0] = int.Parse(Console.ReadLine());

            Console.Write(subjects[1]);
            Console.WriteLine(" 점수를 입력하세요. ");
            scores[1] = int.Parse(Console.ReadLine());

            Console.Write(subjects[2]);
            Console.WriteLine(" 점수를 입력하세요. ");
            scores[2] = int.Parse(Console.ReadLine());

            Console.Write(subjects[3]);
            Console.WriteLine(" 점수를 입력하세요. ");
            scores[3] = int.Parse(Console.ReadLine());

            Console.Write(subjects[4]);
            Console.WriteLine(" 점수를 입력하세요. ");
            scores[4] = int.Parse(Console.ReadLine());

            Console.Write(" 평균점수: ");
            Console.WriteLine((scores[0] + scores[1] + scores[2] + scores[3] + scores[4]) / 5);
        }
    }
}
