using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p09LongerLine
{
    class Program
    {
        static void IsClosest(double x1, double y1, double x2, double y2, double u1, double z1, double u2, double z2)
        {
            double first = Math.Abs(x1) + Math.Abs(y1) + Math.Abs(x2) + Math.Abs(y2);
            double second = Math.Abs(u1) + Math.Abs(z1) + Math.Abs(u2) + Math.Abs(z2);

            if (first >= second)
            {
                if ((Math.Abs(x1) + Math.Abs(y1)) <= (Math.Abs(x2) + Math.Abs(y2)))
                 {

                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                 }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }

            else 
            {
                if ((Math.Abs(u1) + Math.Abs(z1) <= Math.Abs(u2) + Math.Abs(z2)))
                {
                    Console.WriteLine($"({u1}, {z1})({u2}, {z2})");
                }
                else
                {
                    Console.WriteLine($"({u2}, {z2})({u1}, {z1})");
                }
            }
        }
        
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double u1 = double.Parse(Console.ReadLine());
            double z1 = double.Parse(Console.ReadLine());
            double u2 = double.Parse(Console.ReadLine());
            double z2 = double.Parse(Console.ReadLine());

            IsClosest(x1, y1, x2, y2, u1, z1, u2, z2);
        }
    }
}
