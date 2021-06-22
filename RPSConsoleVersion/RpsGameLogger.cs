using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSConsoleVersion
{
    public class RpsGameLogger
    {
        public RpsGameLogger()
        {
            PlayerOneScore = 0;
            PlayerTwoScore = 0;
            Draws = 0;
        }

        public int PlayerOneScore { get; private set; }
        public int PlayerTwoScore { get; private set; }
        public int Draws { get; private set; }


        public void IncrementScore(string roundResult)
        {
            switch (roundResult)
            {
                case "Player 1 Wins!":
                    PlayerOneScore++;
                    break;
                default:
                    break;
            }

        }
    }
}
