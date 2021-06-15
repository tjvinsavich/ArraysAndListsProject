using System;
using System.Collections.Generic;
using System.Threading;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (int num in numArray)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            Console.WriteLine("We have the results for the list of numbers 1-10!");
            Thread.Sleep(2500);
            Console.WriteLine("First up, the EVEN numbers are...");
            Thread.Sleep(2500);

            for(int i = 0; i < evens.Count; i++)
            {
                Console.WriteLine(evens[i]);
                Thread.Sleep(250);
            }

            Thread.Sleep(1000);
            Console.WriteLine("Last, but certainly not least, the ODD numbers are...");
            Thread.Sleep(2500);

            for (int i = 0; i < odds.Count; i++)
            {
                Console.WriteLine(odds[i]);
                Thread.Sleep(250);
            }

            Thread.Sleep(1000);
            Console.WriteLine("It's over!");
            Thread.Sleep(1000);

        }
    }
}
