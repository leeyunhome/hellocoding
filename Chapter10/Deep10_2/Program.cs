using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deep10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int target = random.Next(1, 4);
            int[] num = new int[3];

            Console.Write("컴퓨터가 낸 것: ");
            Console.WriteLine(target);
            
            Console.WriteLine("1: 가위, 2: 바위, 3: 보");
            while (true)
            {
                for (int i = 0; i < 3; ++i)
                {
                    Console.WriteLine("가위바위보! : ");

                    num[i] = int.Parse(Console.ReadLine());
                    if (target == i + 1)
                    {
                        if (num[i] == target)
                        {
                            Console.WriteLine("비겼습니다.");
                        }
                        else if (num[i] == 2)
                        {
                            Console.WriteLine("이겼습니다.");
                            break;
                        }
                        else if (num[i] == 3)
                        {
                            Console.WriteLine("졌습니다.");
                            break;
                        }
                     
                    }
                }
                


            }
        }
    }
}
