using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Start Here //

            // Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Josh Porter";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Ask user's name
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game.", inputName);

            // Set correct number
            int correctNumber = 8;

            // Set guess var
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            // Ask user for number

            // Looping until user guesses the number
            while(guess != correctNumber)
            {
                // Get users input
                string input = Console.ReadLine();

                // Cast to int and put in guess var
                guess = Int32.Parse(input);

                // Match guess to correct number
                if(guess != correctNumber)
                {
                    // Set color to red
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Ask user to try again
                    Console.WriteLine("Wrong Number, please try again");

                    // Reset color
                    Console.ResetColor();
                }
            }

            // Output success message
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("You win! Great job!");

            // Setting bottom to white
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
