using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {

            double mile = double.Parse(Console.ReadLine());

            double km = mile * 1.60934;

            Console.WriteLine($"{km:F2}");
        }
    }
}
