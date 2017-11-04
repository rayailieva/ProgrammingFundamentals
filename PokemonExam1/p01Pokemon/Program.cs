using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int n1 = n;
            int counter = 0;

            while(n >= m)
            {
                n = n - m;
                counter++;

                if(n == n1 * 0.50)
                {
                    if(y != 0)
                    {
                        n = n / y;
                    }
                }

            }

            Console.WriteLine(n);
            Console.WriteLine(counter);
        }
    }
}
