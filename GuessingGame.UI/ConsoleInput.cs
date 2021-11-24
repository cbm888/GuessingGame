using GuessinGame.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GuessingGame.UI
{
    public class ConsoleInput
    {

        public static int GetIntFromUser(string prompt)
        {
            bool first = true;
            int result;
            string userInput;

            do
            {
                //If here a second or subsequent time, the input was not valid
                if (!first)
                {
                    //bad input
                    Console.WriteLine("That is not a valid input.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

                //Set first to false to cause the error message to display
                //above on the next pass through the loop

                first = false;

                //1 & 2: Prompt and Read
                Console.Write(prompt);
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out result));
            return result;
        }

        public static int GetGuessFromUser()
        {
            Console.Clear();
            return GetIntFromUser($"Enter a guess between {GameManager.MinGuess} and {GameManager.MaxGuess}: ");
        }

    }
}
