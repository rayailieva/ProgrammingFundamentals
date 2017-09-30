using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                for (int i = num2; i <= num1; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if(num2 > num1)
            {
                for (int j = num1; j <= num2; j++)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
