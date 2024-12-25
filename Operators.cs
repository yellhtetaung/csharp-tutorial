using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            double age = 23;
            // + - * /
            age /= 10;
            Console.WriteLine(age);

            string name = "Aba";
            name += " is programming!";
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine(++i);
            Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
