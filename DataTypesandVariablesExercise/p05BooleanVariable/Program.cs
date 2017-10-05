using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            bool boolean = Convert.ToBoolean(text);

            if (boolean == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
