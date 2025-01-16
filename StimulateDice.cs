using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class StimulateDice
    {
        
        public void CalcDice(int dice)
        {

            Dictionary<int, int> rollHistory = new Dictionary<int, int>(); //store the history
            for (int i = 2; i <= 12; i++)
            {
                rollHistory[i] = 0;
            }

            Random rand = new Random();


            for (int i = 0; i < dice; i++)
            {
                int dice1 = rand.Next(1,7);
                int dice2 = rand.Next(1,7);
                int sum = dice1 + dice2;

                rollHistory[sum]++;
            }

         Console.WriteLine("DICE ROLLING STIMULATION RESULT");
         Console.WriteLine("Each '*' represents 1% of the total numbers of rolls.");
         Console.WriteLine("Total number of rolls = " + dice + ".\n");

            for (int sum = 2; sum <= 12; sum++) // Loop from 2 to 12
            {
                int count = rollHistory[sum];

                // Calculate percentage
                double percentage = (double)count / dice * 100;

                // Replace numbers with astarisk
                string stars = new string('*', (int)Math.Round(percentage));

                // Display the sum, percentage, and astarisks
                Console.WriteLine($"{sum}: {stars}");
            }

            Console.WriteLine("\nThank you for using the dice throwing stimulator. Goodbye!");

        }
        
    }
}
