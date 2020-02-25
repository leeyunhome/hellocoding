using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem0903
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 2; j <= 8; j += 2)
            {
                for (int i = 1; i <=9; ++i)
                {
                    Console.Write(j);
                    Console.Write("x");
                    Console.Write(i);
                    Console.Write(" = ");
                    Console.Write(j * i);
                    Console.Write(" ");
                    //if (j%2 == 0)
                    //{
                    //    Console.Write(j);
                    //    Console.Write("x");
                    //    Console.Write(i);
                    //    Console.Write(" = ");
                    //    Console.WriteLine(j * i);
                    //}
                }
                Console.WriteLine();
            }
        }
    }
}
