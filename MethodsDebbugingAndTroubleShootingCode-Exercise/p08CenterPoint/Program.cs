using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08CenterPoint
{
    class Program
    {
        static void IsClosest(double x1, double y1, double x2, double y2)
        {
            double first = Math.Abs(x1) + Math.Abs(y1);
            double second = Math.Abs(x2) + Math.Abs(y2);

            if (first > second)
            {
                Console.WriteLine($"({x2}, {y2})"); 
            }
            
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
      

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            IsClosest(x1, y1, x2, y2);
        }
    }
}
