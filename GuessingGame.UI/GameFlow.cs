using GuessinGame.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame.UI
{
    public class GameFlow
    {
        GameManager gameManager;

        public void PlayGame()
        {
            CreateGameManagerInstance();
            ConsoleOutput.DisplayTitle();

            GuessResult result;

            do
            {
                int guess = ConsoleInput.GetGuessFromUser();
                result = gameManager.ProcessGuess(guess);
                ConsoleOutput.DisplayGuessMessage(result);
            } while (result != GuessResult.Victory);
        }

        private void CreateGameManagerInstance()
        {

            gameManager = new GameManager();
            gameManager.Start();
        }
    }
}
