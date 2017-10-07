using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05FibonacciNumbers
{
    class Program
    {
        static int Fib(int n)
        {
            int firstNum = 1;
            int secondNum = 0;
            int result = 0;

            for (int i = 0; i <= n; i++)
            {
                if(n == 0 || n == 1)
                {
                    return firstNum;
                }
                else
                {
                    result = firstNum + secondNum;
                    firstNum = secondNum;
                    secondNum = result;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }
    }
}
