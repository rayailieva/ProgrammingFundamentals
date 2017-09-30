using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyPer100 = int.Parse(Console.ReadLine());
            int sugarPer100 = int.Parse(Console.ReadLine());

            double kcal = (volume * (double)energyPer100) / 100;
            double sugars = (volume * (double)sugarPer100) / 100;


            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kcal}kcal, {sugars}g sugars");


        }
    }
}
