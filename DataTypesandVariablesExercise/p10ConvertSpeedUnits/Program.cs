using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            decimal inMiles = distance / 1609;
            long secondsSum = hours * 3600 + minutes * 60 + seconds;

            double milesPerSecond = (double)distance / secondsSum;
            double kilometeresPerHour = ((double)distance / 1000) / ((double)secondsSum / 3600);
            double milesPerHour = ((double)inMiles) / ((double)secondsSum / 3600);

            Console.WriteLine(milesPerSecond);
            Console.WriteLine(kilometeresPerHour);
            Console.WriteLine(milesPerHour);




        }
    }
}
