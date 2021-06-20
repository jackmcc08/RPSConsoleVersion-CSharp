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

        [TestMethod]
        public void AdditionalScenarios()
        {
            // Arrange
            string expected1 = "Player 1 Wins!";
            string expected2 = "Player 2 Wins!";
            string expected3 = "Draw!";


            // Act
            RpsGameLogic testGame = new RpsGameLogic();
            string actual1 = testGame.TurnResult("scissors", "paper");
            string actual2 = testGame.TurnResult("rock", "paper");
            string actual3 = testGame.TurnResult("scissors", "rock");
            string actual4 = testGame.TurnResult("rock", "rock");
            string actual5 = testGame.TurnResult("scissors", "scissors");


            // Assert
            string failureMessage = "The correct result was not returned";
            Assert.AreEqual(expected1, actual1, false, failureMessage);
            Assert.AreEqual(expected2, actual2, false, failureMessage);
            Assert.AreEqual(expected2, actual3, false, failureMessage);
            Assert.AreEqual(expected3, actual4, false, failureMessage);
            Assert.AreEqual(expected3, actual5, false, failureMessage);

        }
    }
}
