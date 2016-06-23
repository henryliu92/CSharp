using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess1
{
    // Using if-else statements. 
    class Guess
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int guessNumber = random.Next(100) + 1;
            int userGuess = 0;

            while (userGuess != guessNumber)
            {
                Console.WriteLine("Enter a random number:");
                int.TryParse(Console.ReadLine(), out userGuess);

                if (userGuess > guessNumber)
                    Console.WriteLine("{0}   is too high! enter another number", userGuess);

                //check if the number is greater or less than the target number
                else if (userGuess < guessNumber)
                    Console.WriteLine("{0}   is too low! enter another number", userGuess);

                else
                {
                    Console.WriteLine("{0}   is the number! Well done.", userGuess);
                    Console.ReadLine();
                }

            }
        }
    }
}

