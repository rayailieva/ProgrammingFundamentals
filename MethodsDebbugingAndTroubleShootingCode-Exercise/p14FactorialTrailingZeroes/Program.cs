using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace p14FactorialTrailingZeroes
{
    class Program
    {

        static BigInteger Fact(int n)
        {
            BigInteger result = n;
            int counter = 0;


            for (int i = 1; i < n; i++)
            {
                result = i * result;
            }
            
            while(result % 10 == 0)
            {
                counter++;
                result /= 10;
            }

            return counter;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fact(n));
        }
    }
}
