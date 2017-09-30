using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string('|',currentHealth).PadRight(maxHealth,'.')}|");
            Console.WriteLine($"Energy: |{new string('|', currentEnergy).PadRight(maxEnergy, '.')}|");

        }
    }
}
