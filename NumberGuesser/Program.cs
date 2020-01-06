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

            GetAppInfo();
            GreetUser();

            while (true)
            {
                // Set correct number

                // Create new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Set guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                // Ask user for number

                // Looping until user guesses the number
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColormessage(ConsoleColor.Red, "Please enter an actual number");

                        // Keep going
                        continue;

                    }

                    // Cast to int and put in guess var
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColormessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }
                }

                // Output success message
                PrintColormessage(ConsoleColor.DarkYellow, "You win, great job!");

                // Ask to play again
                Console.WriteLine("Play again? (Y/N)");

                // Get the answer
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            // Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Josh Porter";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

        }

        static void GreetUser()
        {
            // Ask user's name
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game.", inputName);
        }

        // Print color message
        static void PrintColormessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
