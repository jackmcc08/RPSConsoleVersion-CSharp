using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSConsoleVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSConsoleVersion.Tests
{
    [TestClass]
    public class RpsGameLoggerTests
    {
        [TestMethod]
        public void IncrementScoreTest_afterOneVictoryByP1()
        {
            // Arrange
            int expectedP1Score = 1;

            // Act
            RpsGameLogger testLogger = new();
            testLogger.IncrementScore("Player 1 Wins!");
            int actualP1Score = testLogger.PlayerOneScore;

            // Assert
            Assert.AreEqual(expectedP1Score, actualP1Score, "Score Logger did not increment P1 score by 1.");
        }

        [TestMethod]
        public void IncrementScoreTest_ForP1OrDraw()
        {
            // Arrange
            int expectedP2Score = 1;
            int expectedDraws = 1;

            // Act
            RpsGameLogger testLogger = new();
            testLogger.IncrementScore("Player 2 Wins!");
            testLogger.IncrementScore("Draw!");
            int actualP2Score = testLogger.PlayerTwoScore;
            int actualDrawScore = testLogger.Draws;


            // Assert
            Assert.AreEqual(expectedP2Score, actualP2Score, "Score Logger did not increment P2 score by 1.");
            Assert.AreEqual(expectedDraws, actualDrawScore, "Score Logger did not increment Draws score by 1.");
        }
    }
}