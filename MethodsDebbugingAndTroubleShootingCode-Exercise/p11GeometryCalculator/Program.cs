using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double result = 0;

            if(type == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                result = (side * height) / 2;
            }
            else if(type == "square")
            {
                double side = double.Parse(Console.ReadLine());

                result = side * side;
            }
            else if(type == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                result = width * height;
            }
            else if(type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                 result = Math.PI * radius * radius;
            }

            Console.WriteLine($"{result:F2}");
        }
    }
}
