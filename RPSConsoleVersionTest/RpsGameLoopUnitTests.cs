using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSConsoleVersion;
using System;
using System.IO;


namespace RPSConsoleVersionTest
{
    [TestClass]
    public class RpsGameLoopUnitTests
    { 
        public string testChoicePaper() => "paper";
        public string testChoiceRock() => "rock";
        public string testChoiceScissors() => "scissors";

        
   /*   Method was changed to private - keeping test here as an example 
    *   of basic dependency injection - which enables a form of mocking the user input
    *     [TestMethod]
        public void GameAsksPlayerForInput_ReturnsString()
        {
            //  Arrange
            string expected = "paper";

            //  Act
            RpsGameLogger testLogger = new RpsGameLogger();
            RpsGameLoop testGame = new RpsGameLoop(1, testLogger);
            string actual = testGame.GetPlayerMove(testChoicePaper);
            // https://stackoverflow.com/questions/3161341/c-sharp-unit-test-for-a-method-which-calls-console-readline
            // https://stackoverflow.com/questions/2082615/pass-method-as-parameter-using-c-sharp
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
            // Assert
            Assert.AreEqual(expected, actual, false, "player choice does not match expected");
        }*/

        [TestMethod]
        public void GameLoopRunsTheGame_GeneratesAScoreInTheLogger()
        {
            // Arrange
            string workingDirectory = Environment.CurrentDirectory;
            string directory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            StreamReader reader = new StreamReader($"{directory}\\testText1.txt");


            Console.SetIn(reader);
            int expectedP1Score = 2;

            // Act
            RpsGameLogger testLogger = new RpsGameLogger();
            RpsGameLoop testGame = new RpsGameLoop(2, testLogger);
            testGame.GameLoop();
            int actualP1Score = testLogger.PlayerOneScore;

            // Assert
            Assert.AreEqual(expectedP1Score, actualP1Score, "Player 1 Score is not what was expected.");

        }
    }
}
