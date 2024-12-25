using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class ConstKeyword
    {
        static void Main(string[] args)
        {
            const int vat = 20;
            const double precentVAT = vat / 100D;

            int balance = 1000;
            Console.WriteLine(balance * (vat / 100));
            Console.WriteLine(balance * precentVAT);

            const string version = "v1.0";

            Console.WriteLine(vat);

            Console.ReadLine();
        }
    }
}
