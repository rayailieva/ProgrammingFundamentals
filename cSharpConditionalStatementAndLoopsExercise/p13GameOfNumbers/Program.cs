using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            var lastFirstNumber = 0;
            var lastSecondNumber = 0;

            bool isFound = false;
            int count = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                for (int j = startNumber; j < endNumber; j++)
                {
                    if(i + j == magicNumber)
                    {
                        lastFirstNumber = i;
                        lastSecondNumber = j;
                        isFound = true;
                    }
                    count++;
                }
            }

            if (isFound)
            {
                Console.WriteLine($"Number found! {lastFirstNumber} + {lastSecondNumber} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }

        }
    }
}
