using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p17PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
