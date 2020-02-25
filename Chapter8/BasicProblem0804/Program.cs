using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem0804
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";

            while (true)
            {
                Console.WriteLine("아무 글자나 입력하세요. 끝내려면 '끝'을 입력하세요.");
                userInput = Console.ReadLine();
                Console.WriteLine(userInput);
                if (userInput == "끝")
                {
                    break;
                }
            }
        }
    }
}
