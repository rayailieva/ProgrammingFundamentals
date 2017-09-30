﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (age >= 0 && age <= 18)
            {

                if (day == "Weekday")
                {
                    price = 12;
                }
                if (day == "Weekend")
                {
                    price = 15;
                }
                if (day == "Holiday")
                {
                    price = 5;
                }

                Console.WriteLine($"{price}$");
            }

            if (age > 18 && age <= 64)
            {

                if (day == "Weekday")
                {
                    price = 18;
                }
                if (day == "Weekend")
                {
                    price = 20;
                }
                if (day == "Holiday")
                {
                    price = 12;
                }

                Console.WriteLine($"{price}$");
            }

            if (age > 64 && age <= 122)
            {

                if (day == "Weekday")
                {
                    price = 12;
                }
                if (day == "Weekend")
                {
                    price = 15;
                }
                if (day == "Holiday")
                {
                    price = 10;
                }

                Console.WriteLine($"{price}$");
            }

            else if(age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
