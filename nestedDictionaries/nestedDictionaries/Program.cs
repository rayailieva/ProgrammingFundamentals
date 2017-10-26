using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var telephoneBook = new Dictionary<string, List<int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                string name = input[0];
                int number = int.Parse(input[1]);

                if (!telephoneBook.ContainsKey(name))
                {
                    telephoneBook.Add(name, new List<int>);
                }
                telephoneBook[name].Add(number);
            }

            foreach (KeyValuePair<string, List<int>> item in telephoneBook)
            {
                string name = item.Key;
                List<int> numbers = item.Value;

                Console.WriteLine($"{name} -> {string.Join(" ", numbers)}");
            }
        }
    }
}
