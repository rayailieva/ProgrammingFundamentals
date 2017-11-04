using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = new Dictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine();

            while (!input.Equals("wubbalubbadubdub"))
            {
                var commandArgs = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                var pokemonName = commandArgs[0];
                var evolutionType = commandArgs[1];
                var evolutionIndex = int.Parse(commandArgs[2]);

                
                    
                    if (!results.ContainsKey(pokemonName))
                    {
                        results[pokemonName] = new Dictionary<string, int>();
                    }

                    results[pokemonName].Add(evolutionType, evolutionIndex);
               

                
        
                input = Console.ReadLine();
            }

            foreach (var pokemon in results)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var evolution in pokemon.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{evolution.Key} <-> {evolution.Value}");
                }
            }
        }

        
        }
    }

