using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";

            for (int i = input.Length - 1; i >= 0 ; i--)
            {
                result += input[i];
            }

            Console.WriteLine(result);
        }
    }
}
