﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class WhileLoops
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }*/

            /* int i = 0;

             while (i < 10)
             {
                 Console.WriteLine(i);
                 i++;
             }*/

            Console.Write("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.Write("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);
            Console.WriteLine();

            int answer = numberA * numberB;
            int actualAnswer = 0;

            Console.Write("What the value of " + numberA + " x " + numberB + ": ");
            Console.WriteLine();


            /* while (answer != actualAnswer)
             {
                 Console.Write("Enter your answer: ");
                 string answerInput = Console.ReadLine();
                 actualAnswer = Convert.ToInt32(answerInput);

                 if (answer != actualAnswer)
                 {
                     Console.WriteLine("Close but it was wrong!");
                     Console.WriteLine();
                 }
             }*/

            do
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (answer != actualAnswer)
                {
                    Console.WriteLine("Close but it was wrong!");
                    Console.WriteLine();
                }
            } while (answer != actualAnswer);

            Console.WriteLine("Well done!");

            Console.ReadLine();
        }
    }
}
