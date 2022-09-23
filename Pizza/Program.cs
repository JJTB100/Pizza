using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toppings = new List<string>
            {
                "Pepperoni", "Margerita", "Ham and Pineapple"
            };

            List<string> selection = ChooseFrom(toppings);
            Console.WriteLine(selection);

        }

        private static List<string> ChooseFrom(List<string> options)
        {
            bool quit = false;
            List<string> choices = new List<string>();
            while (!quit)
            {
                int choice;
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}-{options[i]}");

                    
                }
                Console.WriteLine("0 To Quit");
                Console.Write("Choose a Number: ");
                choice = int.Parse(Console.ReadLine())-1;
                if (choice == -1)
                {
                    quit = true;
                }
                else
                {
                    choices.Add(options[choice]);
                }
                

                
            }
            return choices;
        }
    }
}
