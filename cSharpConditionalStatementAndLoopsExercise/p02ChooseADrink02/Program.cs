﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02ChooseADrink02
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;

            if(profession == "Athlete")
            {
                price = 0.70 * quantity;
                Console.WriteLine($"The {profession} has to pay {price:F2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price = 1.00 * quantity;
                Console.WriteLine($"The {profession} has to pay {price:F2}.");
            }
            else if (profession == "SoftUni Student" )
            {
                price = 1.70 * quantity;
                Console.WriteLine($"The {profession} has to pay {price:F2}.");
            }
            else
            {
                price = 1.20 * quantity;
                Console.WriteLine($"The {profession} has to pay {price:F2}.");

            }
        }
    }
}
