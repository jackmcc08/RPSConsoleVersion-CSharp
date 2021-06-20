using System;

namespace RPSConsoleVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Test");

            RpsGameLogic test = new();
            Console.WriteLine(test.TurnResult("paper", "rock"));

        }
    }
}
