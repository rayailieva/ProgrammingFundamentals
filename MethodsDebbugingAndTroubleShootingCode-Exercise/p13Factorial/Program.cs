using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace p13Factorial
{
    class Program
    {
        static BigInteger Fact(int n)
        {
           BigInteger result = n;
           
                      
           for (int i = 1; i < n; i++)
           {
               result = i * result ;
           }

            return result;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fact(n));
        }
    }
}
