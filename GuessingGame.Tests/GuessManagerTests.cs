using GuessinGame.BLL;
using NUnit.Framework;
using System;

namespace GuessingGame.Tests
{
    [TestFixture]
    public class GuessManagerTests
    {

        private int middleOfRange;

        public GuessManagerTests()
        {
            //Pick the number in the middle of the range
            middleOfRange = (GameManager.MaxGuess + GameManager.MinGuess) / 2;
        }

       [Test]  
       public void InvalidTestGuess()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start();

            GuessResult actual = gameInstance.ProcessGuess(GameManager.MaxGuess + 1);
            Assert.AreEqual(GuessResult.Invalid, actual);
        }
        [Test]
        public void HigherGuessResultTest()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start(middleOfRange);

            GuessResult actual = gameInstance.ProcessGuess(middleOfRange - 1);
            Assert.AreEqual(GuessResult.Higher, actual);
        }


        [Test]
        public void LowerGuessResultTest()
        {
            //Pick the number in the middle of the range
            GameManager gameInstance = new GameManager();
            gameInstance.Start(middleOfRange);

            GuessResult actual = gameInstance.ProcessGuess(middleOfRange + 1);
            Assert.AreEqual(GuessResult.Lower, actual);
        }

        [Test]
        public void VictoryGuessResultTest()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start(middleOfRange);

            GuessResult actual = gameInstance.ProcessGuess(middleOfRange);
            Assert.AreEqual(GuessResult.Victory, actual);

        }
    }
}
