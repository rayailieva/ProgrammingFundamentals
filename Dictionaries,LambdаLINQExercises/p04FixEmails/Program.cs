using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, string>(); //name, email

            while (true)
            {
                string name = Console.ReadLine(); 

                if (name == "stop")
                {
                    break;
                }
                else
                {
                    string email = Console.ReadLine();

                    string domain = email.Substring(email.Length - 2);

                    if(domain == "us" || domain == "uk")
                    {
                        continue;
                    }
                    else
                    {

                        people.Add(name, email);
                    }
                }

            }

            foreach (var item in people)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
