using GuessinGame.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame.UI
{
    class ConsoleOutput
    {
        /*
         * Best practice: Use helper function to avoid duplicate code.
         * 
         * <summary>
         * <param name = "prompt"> Message to display for prompt. If none specified, display default "Press any key to continue..." Uses C# option paramter with default value </param>

        */
        public static void PressKeyToContinue (string prompt)
        {
            Console.WriteLine(prompt);
            Console.ReadKey();
        }

        public static void PressKeyToContinue()
        {
            Console.ReadKey();
        }

        public static void DisplayTitle()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Better, Testable, Guessing Game!\n\n");
            PressKeyToContinue("Press Any Key to start the game...");
        }

        public static void DisplayGuessMessage(GuessResult result)
        {
            string message = string.Empty;

            switch (result)
            {
                case GuessResult.Invalid:
                    //Since this message includes the valid range, get the range from the manager
                    message = $"That guess wasn't valid, try something between {GameManager.MinGuess} and {GameManager.MaxGuess}.";
                    break;
                case GuessResult.Higher:
                    message = "Your guess was too low, try something higher.";
                    break;
                case GuessResult.Lower:
                    message = "Your guess was too high, try something lower.";
                    break;
                case GuessResult.Victory:
                    message = "You guessed right! Great job!";

                    break;
                
            }
            Console.WriteLine(message);
            //Parameter not specified and uses default value
            PressKeyToContinue();
        }

    }
}
