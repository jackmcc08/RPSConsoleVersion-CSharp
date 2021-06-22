using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSConsoleVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSConsoleVersion.Tests
{
    [TestClass()]
    public class RpsGameLoggerTests
    {
        [TestMethod()]
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
    }
}