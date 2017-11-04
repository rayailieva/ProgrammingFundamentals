using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            int locoPower = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();

            while (input != "All ofboard!")
            {
                    var wagons = (int.Parse(input));

                    numbers.Add(wagons);

                    int totalWeight = numbers.Sum();

                    if(totalWeight > locoPower)
                    {
                        int average = totalWeight / numbers.Count;
                        int closest = numbers.Aggregate((x, y) => Math.Abs(x - average) < Math.Abs(y - average) ? x : y);

                        numbers.Remove(closest);
                        numbers.Add(locoPower);
                        numbers.Reverse();
                    }

                
            }

            foreach (var item in numbers)
            {
                Console.Write(String.Join(" ", item));
            }
        }
    }
}
