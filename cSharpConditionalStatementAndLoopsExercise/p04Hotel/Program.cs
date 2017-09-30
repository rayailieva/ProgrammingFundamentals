using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceStudio = 0.00;
            double priceDouble = 0.00;
            double priceMasterSuite = 0.00;

            switch (month)
            {
                case "May":
                case "October": priceStudio = 50; priceDouble = 65; priceMasterSuite = 75;
                    break;
                case "June":
                case "September": priceStudio = 60; priceDouble = 72; priceMasterSuite = 82;
                    break;
                case "July":
                case "August":
                case "December": priceStudio = 68; priceDouble = 77; priceMasterSuite = 89;
                    break;
            }

            if((month == "May" || month == "October") && nights > 7)
            {
                priceStudio *= 0.95;
            }
            else if((month == "June" || month == "September") && nights > 14)
            {
                priceDouble *= 0.90;
            }
            else if((month == "July" || month == "August" || month == "December") && nights > 14)
            {
                priceMasterSuite *= 0.85;
            }

            double finalPriceStudio = priceStudio * nights;
            double finalDouble = priceDouble * nights;
            double finalMasterSuite = priceMasterSuite * nights;

            if((month == "September" || month == "October") && nights > 7)
            {
                finalPriceStudio -= priceStudio;
            }

            Console.WriteLine($"Studio: {finalPriceStudio:F2} lv.");
            Console.WriteLine($"Double: {finalDouble:F2} lv.");
            Console.WriteLine($"Suite: {finalMasterSuite:F2} lv.");

        }
    }
}
