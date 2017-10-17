using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new SortedDictionary<string, string>(); // name, number

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                var commandArgs = input.Split(' ');

                string command = commandArgs[0];
                
                
                if (command == "A")
                {
                    people[commandArgs[1]] = commandArgs[2];
                }
                else if (command == "S")
                {
                    if (people.ContainsKey(commandArgs[1]))
                    {
                        foreach (var item in people)
                        {
                            if (item.Key == commandArgs[1])
                            {
                                Console.WriteLine($"{item.Key} -> {item.Value}");
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine($"Contact {commandArgs[1]} does not exist.");
                    }
                }
                else if(command == "ListAll")
                {

                    foreach (var item in people)
                    {
                        
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        
                    }
                }
            }
        }
    }
}
