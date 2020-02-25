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
            Console.WriteLine("가위 바위 보 게임을 해보자");
            
            while (true)
            {
                Random random = new Random();
                int target = random.Next(1, 4);

                //Console.Write("컴퓨터가 낸 것: ");
                Console.WriteLine(target);

                Console.WriteLine("컴퓨터는 이미 정했습니다. 가위바위보를 숫자로 입력해주세요.");
                Console.WriteLine("1: 가위, 2: 바위, 3: 보");

                int num = int.Parse(Console.ReadLine());

                if (target == 1)
                {
                    if (num == 2)
                    {
                        Console.WriteLine("이겼습니다.");
                        break;
                    }
                    else if (num == 3)
                    {
                        Console.WriteLine("졌습니다.");
                        Console.Write("컴퓨터가 낸 것: ");
                        Console.WriteLine(target);
                        break;
                    }
                    else //if (num == 1)
                    {
                        Console.WriteLine("비겼습니다.");
                    }
                }
                else if (target == 2)
                {
                    if (num == 1)
                    {
                        Console.WriteLine("졌습니다.");
                        Console.Write("컴퓨터가 낸 것: ");
                        Console.WriteLine(target);
                        break;
                    }
                    else if (num == 3)
                    {
                        Console.WriteLine("이겼습니다.");
                        break;
                    }
                    else //if (num == 2)
                    {
                        Console.WriteLine("비겼습니다.");
                    }
                }
                else if (target == 3)
                {
                    if (num == 1)
                    {
                        Console.WriteLine("이겼습니다.");
                        break;
                    }
                    else if (num == 2)
                    {
                        Console.WriteLine("졌습니다.");
                        Console.Write("컴퓨터가 낸 것: ");
                        Console.WriteLine(target);
                        break;
                    }
                    else //if (num == 3)
                    {
                        Console.WriteLine("비겼습니다.");
                    }
                }
            }
        }
    }
}
