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
    }
}
