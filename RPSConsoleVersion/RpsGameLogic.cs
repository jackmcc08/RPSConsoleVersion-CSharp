using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSConsoleVersion
{
    public class RpsGameLogic
    {
        public RpsGameLogic()
        {
            GenerateWinMatrix();
        }

        private Dictionary<string, string> WinMatrix = new Dictionary<string, string>();

        public string TurnResult(string playerOneMove, string playerTwoMove)
        {
            if (playerOneMove == "paper" && playerTwoMove == "rock")
            {
                return "Player 1 Wins!";
            }
            else
            {
                return "Player 2 Wins!";
            }
        }

        private void GenerateWinMatrix()
        {
            WinMatrix.Add("paper", "rock");
            WinMatrix.Add("rock", "scissors");
            WinMatrix.Add("scissors", "paper");
        }
    }
}
