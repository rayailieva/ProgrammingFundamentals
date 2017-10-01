using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = 0;
            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());

            double width = 0;
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            double height = 0;
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());

            double volume = 0;
            volume = (lenght * width * height) / 3;

            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
