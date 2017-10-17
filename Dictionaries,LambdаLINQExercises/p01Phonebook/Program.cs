using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var people = new Dictionary<string, string>(); // name, number
                        
            while(true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                var commandArgs = input.Split(' ');

                string command = commandArgs[0];
                string name = commandArgs[1];
                


                if(command == "A")
                {
                    people[name] = commandArgs[2];
                }
                else if(command == "S")
                {
                    if (people.ContainsKey(name))
                    {
                        foreach (var item in people)
                        {
                            if (item.Key == name)
                            {
                                Console.WriteLine($"{item.Key} -> {item.Value}");
                            }
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }


            }
        }
    }
}
