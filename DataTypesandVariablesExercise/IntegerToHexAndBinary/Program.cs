using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());

            string hex = value.ToString("X");
            string binary = Convert.ToString(value, 2);

            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
