using System;

namespace csharppractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro text with user input of the amount of dice rolls
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.WriteLine("How many dice rolls would you like to simulate?");
            int diceRolls = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1 % of the total number of rolls.\nTotal number of rolls = " + diceRolls + ".\n");

            Random r = new Random(3);

            int[] myArray = new int[11];

            //Simulate the roll of 2 die for input number of times
            for (int i = 0; i < diceRolls; i++)
            {
                int roll = r.Next(11);
                myArray[roll]++;

            }
            for (int i = 0; i < 11; i++)
            {
                if (myArray[i] > 0)
                {
                    double percent = ((Convert.ToDouble(myArray[i]) / Convert.ToDouble(diceRolls)) * 100.0);
                    int starCount = Convert.ToInt32(Math.Round(percent));
                    Console.Write("\n" + (i + 2) + ": ");
                    for (int j = 0; j < starCount; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("\n" + (i + 2) + ": ");
                }

            }

            Console.WriteLine("\n\nThank you for using the dice throwing simulator. Goodbye!");

        }
    }
}
