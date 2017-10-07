using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p16ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double difference = 0.000001;

            if(Math.Abs(firstNum - secondNum) < difference)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


        }
    }
}
