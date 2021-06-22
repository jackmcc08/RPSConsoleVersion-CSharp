using System;

namespace RPSConsoleVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Thunderdome!");
            Console.WriteLine("\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/");
           
            // Number of Players
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

            // Initialise various classes
            // initialise game logger
            RpsGameLoop game = new(numPlayers);

            game.GameLoop();

            string result = "X wins!";
            Console.WriteLine($"\n\n{result}");


            
            // Greeting
            // Initialize 
            // Select one or two players
            // Initiate game loop
            // end game scores

        }
    }
}
