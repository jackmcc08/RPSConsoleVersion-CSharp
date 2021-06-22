using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSConsoleVersion
{
    public class RpsGameLoop
    {
        public RpsGameLoop(int numPlayers)
        {
            GameRound = 1;
            NumPlayers = numPlayers;
            GameLogic = new RpsGameLogic();
            // GameLoggerClass instance
            // 
        }

        public int GameRound { get; private set; }
        private int NumPlayers { get; set; }
        private RpsGameLogic GameLogic { get; set; }

        public void GameLoop()
        {
            // Determine if one or two players
            // Ask for move
            // generate computer move
            // determine winner
            // display Winner
            // store score
            // end game or next round?
        }
        
        public string GetPlayerMove(Func<string> inputMethod)
        {
            return inputMethod();
        }
    }
}
