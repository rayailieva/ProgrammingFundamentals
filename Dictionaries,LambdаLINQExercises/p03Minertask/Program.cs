using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03Minertask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, long>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "stop")
                {
                    break;
                }
                else
                {
                    long quantity = long.Parse(Console.ReadLine());

                    if (resources.ContainsKey(input))
                    {
                        resources[input] += quantity;
                    }
                    else
                    {
                        resources.Add(input, quantity);
                    }
                }

            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
