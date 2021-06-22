using System;

namespace RPSConsoleVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Thunderdome!");
            Console.WriteLine("\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/");
           
  
            int numPlayers = 0;
            do
            {
                Console.WriteLine("Please select the number of players: 1 or 2");
                string numPlayersChoice = Console.ReadLine();
                try
                {
                    numPlayers = Convert.ToInt32(numPlayersChoice);
                }
                catch
                {
                    Console.WriteLine("please enter 1 or 2");
                }
            } while (!(numPlayers == 1 || numPlayers == 2));

            Console.WriteLine($"You selected {numPlayers} players.");

            RpsGameLogger log = new();
            RpsGameLoop game = new(numPlayers, log);

            game.GameLoop();

            string gameResult = log.DetermineWinner();
            Console.WriteLine($"\n\n{gameResult}");

            Console.WriteLine("\n\n\nReload Game to Play again.");
        }
    }
}
