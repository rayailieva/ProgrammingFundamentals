using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01HelloName
{
    class Program
    {
        static void nameGetter(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            nameGetter(name);
        }
    }
}
