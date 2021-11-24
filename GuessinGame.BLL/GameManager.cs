using System;

namespace GuessinGame.BLL
{
    public class GameManager
    {
        public const int MinGuess = 1;
        public const int MaxGuess = 20;

        private int _answer;

        public void Start()
        {
            CreateRandomAnswer();
        }

        public void Start(int answer)
        {
            _answer = answer;
        }
        private bool IsValidGuess(int guess)
        {
            return (MinGuess <= guess && guess <= MaxGuess);
            
        }

        private void CreateRandomAnswer()
        {
            Random random = new Random();
            //Next's upper bound is EXCLUSIVE of the values, so we need to add 1` to the maximum
            _answer = random.Next(MinGuess, MaxGuess + 1);

        }

        public GuessResult ProcessGuess(int guess)
        {
            //Best practice: Always initialize variables
            GuessResult guessResult = GuessResult.Invalid;

            if (IsValidGuess(guess))
            {
                if (guess < _answer)
                {
                    guessResult = GuessResult.Higher;
                }
                else if (guess > _answer)
                {
                    guessResult = GuessResult.Lower;
                }
                else
                {
                    guessResult = GuessResult.Victory;
                }

            }
            // Good Practice: single exit point
            return guessResult;
        }

    }
}
