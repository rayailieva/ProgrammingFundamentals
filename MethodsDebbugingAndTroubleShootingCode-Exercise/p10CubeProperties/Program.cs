using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10CubeProperties
{
    class Program
    {

        static double Properties(double side, string parameter)
        {
            double result = 0;

            if(parameter == "volume")
            {
                result = side * side * side;
            }
            else if(parameter == "area")
            {
                result = 6 * side * side;
            }
            else if(parameter == "space")
            {
                result = Math.Sqrt(3 * side * side);
            }
            else if(parameter == "face")
            {
                result = Math.Sqrt(2 * side * side);
            }

            return result;
        }
        
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            Console.WriteLine($"{Properties(side, parameter):F2}");
        }
    }
}
