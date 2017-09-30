using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p09MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = 1;

            while(multiplier <= 10)
            {
                Console.WriteLine(n * multiplier);
                multiplier++;
            }

            
        }
    }
}
