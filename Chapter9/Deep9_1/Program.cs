using System;

namespace Deep9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };

            int passcodeLength = 6;
            int[] userInput = new int[passcodeLength];

            int count;

            Console.WriteLine("비밀번호가 5회 일치하지 않으면 5분 기다려야합니다.");
            for (count = 0; count < 5; ++count)
            {
                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; ++passcodeIndex)
                {
                    Console.Write(passcodeIndex + 1);
                    Console.WriteLine("번째 숫자를 넣어주세요.");
                    userInput[passcodeIndex] = int.Parse(Console.ReadLine());
                }

                bool isPasswordCorrect = true;
                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; ++passcodeIndex)
                {
                    if (userInput[passcodeIndex] != passcodeNumbers[passcodeIndex])
                    {
                        isPasswordCorrect = false;
                        Console.Write(count + 1);
                        Console.WriteLine("회 비밀번호가 틀렸습니다.");
                        break;
                    }
                }

                if (isPasswordCorrect == true)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }

                if (count == 4)
                {
                    Console.Write(count + 1);
                    Console.WriteLine("번의 입력횟수를 초과했습니다. 5분후 다시 시도해주세요.");
                }
            }
        }
    }
}
