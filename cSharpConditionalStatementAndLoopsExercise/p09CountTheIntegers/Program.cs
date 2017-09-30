using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p09CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (true)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch (Exception)
                {
                    Console.WriteLine(counter);
                    return;
                }
            }
        }
    }
}
