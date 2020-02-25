using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deep10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int target = 0;

            target = random.Next(1, 101);

            Console.Write("컴퓨터가 고른 숫자 : ");
            Console.WriteLine(target);
            while (true)
            {
                
                Console.WriteLine("숫자를 입력하세요.");
                int num = int.Parse(Console.ReadLine());

                if (num > target)
                {
                    Console.WriteLine("더 작은 숫자입니다");
                }
                else if (num < target)
                {
                    Console.WriteLine("더 큰 숫자입니다.");
                }
                else// if (num == target)
                {
                    Console.WriteLine("정답입니다.");
                    break;
                }
            }
        }
    }
}
