using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02SoftUnikaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = new Dictionary<string,List<string>>();

            var participants = Console.ReadLine().Split(',').Select(p => p.Trim()).ToList();
            var songs = Console.ReadLine().Split(',').Select(s => s.Trim()).ToList();

            var input = Console.ReadLine();


            while (!input.Equals("dawn"))
            {
                var performance = input.Split(',').Select(p => p.Trim()).ToList();

                var participant = performance[0];
                var song = performance[1];
                var award = performance[2];

                if (participants.Contains(participant) && song.Contains(song))
                {
                    if (!results.ContainsKey(participant))
                    {
                        results[participant] = new List<string>();
                    }

                    var awards = results[participant];

                    if (!awards.Contains(award))
                    {
                        awards.Add(award);
                    }
                }
                input = Console.ReadLine();
            }
            if (results.Any())
            {
                foreach (var keyValuePair in results.OrderByDescending(p => p.Value.Count).ThenBy(n => n.Key))
                {
                    if (keyValuePair.Key.Any())
                    {
                        var participant = keyValuePair.Key;
                        var awards = keyValuePair.Value;
                        Console.WriteLine($"{participant}: {awards.Count} awards");
                        foreach (var award in awards.OrderBy(n => n))
                        {
                            Console.WriteLine($"--{award}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }

        }
    }
}
