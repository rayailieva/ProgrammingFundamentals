using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine().Split(' ').ToList();
            var zones = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int startingFuel = 0;
            bool isFinished = true;

            foreach (var driver in drivers)
            {
                startingFuel = (char)driver[0];

                for (int i = 0; i < zones.Count; i++)
                {
                    
                        if(checkpoints.Contains(i))
                        {
                            startingFuel += zones[i];
                        }
                        else
                        {
                            startingFuel -= zones[i];
                        }

                        if(startingFuel <= 0)
                        {
                            isFinished = false;
                            Console.WriteLine($"{driver} - reached {i}");
                            break;
                        }
                    
                }

                if (isFinished)
                {
                    Console.WriteLine($"{driver} - fuel left {startingFuel:F2}");
                }


            }
        }
    }
}
