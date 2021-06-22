# Learning C#

## Rock Paper Scissors Console Version

Developing a rock paper scissors version via TDD to learn the C#.NET stack.

The program is written in C# and was developed mostly via TDD. It has a command line interface and allows you to play with 1 or 2 players.

Working through this project, I explored some new areas:
- Dependency Injection - cut out the user input into it's own class to allow for injection of an alternate testing method. Did not need in the end as used an alternate method for automating user input.
- Console.SetIn - used the setin method to redirect Console.ReadLine Requests from the Console to a text file.

## To Use
- Git clone repository
- Run in PowerShell (in the repo root solution folder) - ` dotnet run -p .\RPSConsoleVersion\`
- Or run in Visual Studio IDE

## Tech Stack
	- C#
	- .Net Core 5.0 framework
	- MSunit testing suite 
	- use of Console.SetIn method to automate user input during tests

## Structure

- Program
	- Initiates program in Console and calls the various classes
- RPS Game Loop - 
	- Asks for user input
	- Checks user input
	- stores user input 
	- APplies user input to Game Logic and determines round winner
	- checks if user wants to end 

- RPS Game Logic 
	- checks winner based on choices

- RPS Game Logger
	- stores results
	- determines overall winners
