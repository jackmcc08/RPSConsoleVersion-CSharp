using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSConsoleVersion;

namespace RPSConsoleVersionTest
{
    [TestClass]
    public class RpsGameLoopUnitTests
    { 
        public string testChoicePaper() => "paper";
        public string testChoiceRock() => "rock";
        public string testChoiceScissors() => "scissors";

        
        [TestMethod]
        public void GameAsksPlayerForInput_ReturnsString()
        {
            //  Arrange
            string expected = "paper";

            //  Act
            RpsGameLoop testGame = new();
            string actual = testGame.GetPlayerMove(testChoicePaper);
            // https://stackoverflow.com/questions/3161341/c-sharp-unit-test-for-a-method-which-calls-console-readline
            // https://stackoverflow.com/questions/2082615/pass-method-as-parameter-using-c-sharp
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
            // Assert
            Assert.AreEqual(expected, actual, false, "player choice does not match expected");
        }

        [TestMethod]
        public void GameLoopRunsTheGame_GeneratesAScoreInTheLogger()
        {
            // Arrange

            // Act

            // Assert

        }
    }
}
