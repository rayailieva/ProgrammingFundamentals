using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;

            string ingredient = "";

            while (ingredient != "Bake!") 
            {       

                ingredient = Console.ReadLine();

                if(ingredient == "Bake!")
                {
                    break;
                }

                Console.WriteLine($"Adding ingredient {ingredient}.");
                counter++;
                
            }

            Console.WriteLine($"Preparing cake with {counter} ingredients.");

        }
    }
}
