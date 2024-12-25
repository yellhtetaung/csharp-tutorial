using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class ForLoop
    {
        static void Main(string[] args)
        {
            Console.Write("What do you want to repeat?: ");
            string message = Console.ReadLine();

            Console.Write("And how many times do you want to repeat it?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());


            if (loopCounter <= 0)
            {
                Console.WriteLine("Sorry, please enter a value above 0");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine($"{i + 1}. {message}");
                }
            }



            /*for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }*/

            Console.ReadLine();
        }
    }
}
