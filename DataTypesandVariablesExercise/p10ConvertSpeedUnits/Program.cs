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
            float distance = int.Parse(Console.ReadLine());
            float hours = int.Parse(Console.ReadLine());
            float minutes = int.Parse(Console.ReadLine());
            float seconds = int.Parse(Console.ReadLine());

            float sumTimeInMinutes = (hours * 60) + minutes + (seconds / 60);
            float sumInHours = sumTimeInMinutes / 60;
            float sumInSeconds = sumTimeInMinutes * 60;

            float metersPerSecond = distance / sumInSeconds;
            float kilometersPerHour = (distance / 1000) / sumInHours;
            float milesPerHour = (distance / 1609) / sumInHours;

            Console.WriteLine("{0:0.#######}", metersPerSecond);
            Console.WriteLine("{0:0.#######}", kilometersPerHour);
            Console.WriteLine("{0:0.#######}", milesPerHour);




        }
    }
}
