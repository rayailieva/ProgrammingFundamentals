using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03restaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double price = 0.00;
                      

            if(groupSize <= 50)
            {   
               
                if(package == "Normal")
                {
                    price = (3000 * 0.95) / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {price:F2}$");
                }
                if (package == "Gold")
                {
                    price = (3250 * 0.90) / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {price:F2}$");
                }
                if (package == "Platinum")
                {
                    price = (3500 * 0.85) / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {price:F2}$");
                }
            }

            else if (groupSize > 50 && groupSize <= 100)
            {

                if (package == "Normal")
                {
                    price = (5500 * 0.95) / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {price:F2}$");
                }
                if (package == "Gold")
                {
                    price = (5750 * 0.90) / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {price:F2}$");
                }
                if (package == "Platinum")
                {
                    price = (6000 * 0.85) / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {price:F2}$");
                }
            }

            else if (groupSize > 100 && groupSize <= 120)
            {

                if (package == "Normal")
                {
                    price = (8000 * 0.95) / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {price:F2}$");
                }
                if (package == "Gold")
                {
                    price = (8250 * 0.90) / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {price:F2}$");
                }
                if (package == "Platinum")
                {
                    price = (8500 * 0.85) / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {price:F2}$");
                }
            }
            else if(groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }


        }
    }
}
