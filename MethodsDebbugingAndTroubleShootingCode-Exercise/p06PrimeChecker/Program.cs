using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06PrimeChecker
{
    class Program
    {
        static bool IsPrime(long num)
        {
            
             if(num < 2)
            {
                return false;
            }
             if(num == 2)
            {
                return true;

            }
             if (num % 2 == 0)
            {
                return false;
            }

            
             for(int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(num));

        }
    }
}
