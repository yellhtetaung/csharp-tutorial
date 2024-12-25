using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class TextBasedDatatypes
    {
        static void Main(string[] args)
        {
            /*
             * String can store empty string
             * Char cannot store empty string. Default value of char is \0
             */
            string name = "Aba";
            char letter = '\0';

            Console.WriteLine("Your name is ");
            Console.WriteLine(name);

            Console.WriteLine();
            Console.WriteLine(letter);

            Console.ReadLine();
        }
    }
}
