using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int returnValue = rng.Next(1, 5);

            int No = 0;
            int count = 0;
            Console.WriteLine("I am thinking of a number between 1-100.  Can you guess what it is?");


            while (No != returnValue)

            {
                count++;
                No = int.Parse(Console.ReadLine());

                if (No < returnValue)
                {
                    Console.WriteLine("No, the number is higher than " + No);
                }
                else
                {
                    if (No > returnValue)
                        Console.WriteLine("No, the number is lower than " + No);
                }

            }

            Console.WriteLine("Great! The answer was {0} you need {1} attempt \n", returnValue, count);


        }
    }
}


