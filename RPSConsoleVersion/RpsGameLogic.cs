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

        }

        public string TurnResult(string playerOneMove, string playerTwoMove)
        {
            if (playerOneMove == "paper" && playerTwoMove == "rock")
            {
                return "Player 1 Wins!";
            }
            return null;
        }
    }
}
