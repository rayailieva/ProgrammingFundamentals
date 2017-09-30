using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int productsCount = int.Parse(Console.ReadLine());
            int counter = 0;
            
            for (int i = 0; i < productsCount; i++)
            {
                string product = Console.ReadLine().ToLower();

                switch (product)
                {
                    case "cheese": counter += 500;
                        break;
                    case "tomato sauce": counter += 150;
                        break;
                    case "salami": counter += 600;
                        break;
                    case "pepper": counter += 50;
                        break;
                    default: counter += 0;
                        break;
                }
            }

            Console.WriteLine($"Total calories: " + counter);
        }
    }
}
