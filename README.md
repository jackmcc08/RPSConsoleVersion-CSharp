# Learning C#

## Rock Paper Scissors Console Version

Developing a rock paper scissors version via TDD to learn the C#.NET stack. 

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

- RPS Game Loop - 
	- Asks for user input
	- Checks user input
	- stores user input 
	- APplies user input to Game Logic and determines round winner
	- checks if user wants to end 

- RPS Game Logic 
	- checks winners - Done
- RPS Computer Opponents
- RPS Game Logger
	- stores results
