using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine();
            var valueInHex = Convert.ToInt32(value, 16);

            Console.WriteLine(valueInHex);
            
        }
    }
}
