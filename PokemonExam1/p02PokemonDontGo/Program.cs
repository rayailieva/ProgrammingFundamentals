using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                          .Split(' ')
                          .Select(int.Parse)
                          .ToList();

            int element = 0;
            int sum = 0;

            while (numbers.Count > 0)
            {

                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    element = numbers[0];
                    numbers[0] = numbers[numbers.Count - 1];

                }
                else if (index > numbers.Count - 1)
                {
                    element = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];
                }
                else
                {
                    element = numbers[index];
                    numbers.Remove(index);
                        
                }
                sum += element;

                for (int i = 0; i < numbers.Count; i++)
                {
                    
                    if (numbers[i] <= element)
                    {
                        
                        numbers[i] += index;
                        
                    }
                    else 
                        
                        numbers[i] -= index;
                        
                    }
                }
            Console.WriteLine(sum);
        }
     
            
        }
           
   }
   

