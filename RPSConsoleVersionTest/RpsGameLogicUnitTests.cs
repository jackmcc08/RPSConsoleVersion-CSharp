using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSConsoleVersion;

namespace RPSConsoleVersionTest
{
    [TestClass]
    public class RpsGameLogicUnitTests
    {
        [TestMethod]
        public void Player1GetsPaper_Player2GetsRock_Player1Wins()
        {
            // Arrange
            string expected = "Player 1 Wins!";

            // Act
            RpsGameLogic testGame = new RpsGameLogic();
            string p1Move = "paper";
            string p2Move = "rock";
            string actual = testGame.TurnResult(p1Move, p2Move);

            // Assert
            string failureMessage = "The correct result - p1 wins was not returned, with P1Move - Paper, P2Move - Rock";
            Assert.AreEqual(expected, actual, false, failureMessage);
        }

        [TestMethod]
        public void Player1GetsRock_Player2GetsScissors_Player1Wins()
        {
            // Arrange
            string expected = "Player 1 Wins!";

            // Act
            RpsGameLogic testGame = new RpsGameLogic();
            string p1Move = "rock";
            string p2Move = "scissors";
            string actual = testGame.TurnResult(p1Move, p2Move);

            // Assert
            string failureMessage = "The correct result - p1 wins was not returned, with P1Move - Rock, P2Move - Scissors";
            Assert.AreEqual(expected, actual, false, failureMessage);
        }

        [TestMethod]
        public void Player1GetsPaper_Player2GetsScissors_Player1Loses()
        {
            // Arrange
            string expected = "Player 2 Wins!";

            // Act
            RpsGameLogic testGame = new RpsGameLogic();
            string p1Move = "paper";
            string p2Move = "scissors";
            string actual = testGame.TurnResult(p1Move, p2Move);

            // Assert
            string failureMessage = "The correct result - p2 wins was not returned, with P1Move - Paper, P2Move - Scissors";
            Assert.AreEqual(expected, actual, false, failureMessage);
        }

        [TestMethod]
        public void Player1GetsPaper_Player2GetsPaper_ItsADraw()
        {
            // Arrange
            string expected = "Draw!";

            // Act
            RpsGameLogic testGame = new RpsGameLogic();
            string p1Move = "paper";
            string p2Move = "paper";
            string actual = testGame.TurnResult(p1Move, p2Move);

            // Assert
            string failureMessage = "The correct result - draw was not returned, with P1Move - Paper, P2Move - Paper";
            Assert.AreEqual(expected, actual, false, failureMessage);
        }
    }
}
