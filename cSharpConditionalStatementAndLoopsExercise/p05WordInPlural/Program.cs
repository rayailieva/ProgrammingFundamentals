using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.EndsWith("y"))
            {
                var remove = word.Remove(word.Length - 1, 1);
                var plurals = remove + "ies";
                Console.WriteLine(plurals);
            }
            else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("sh")
                || word.EndsWith("x") || word.EndsWith("z") || word.EndsWith("s"))
            {
                var plurals = word + "es";
                Console.WriteLine(plurals);
            }
            else
            {
                var plurals = word + "s";
                Console.WriteLine(plurals);
            }
        }
    }
}
