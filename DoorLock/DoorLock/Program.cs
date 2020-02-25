using System;

namespace DoorLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int passcodeNumbers1 = 6;
            int passcodeNumbers2 = 2;

            Console.WriteLine("input first number: ");
            int userInput1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input second number: ");
            int userInput2 = int.Parse(Console.ReadLine());

            if (userInput1 == passcodeNumbers1 && userInput2 == passcodeNumbers2)
            {
                Console.WriteLine("문이 열렸습니다.");

            }
        }
    }
}
