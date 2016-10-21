using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangTheoryGame
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        private bool round;
        private bool game;
        private bool playerName;
        private string name;
        private int gameMode;
        private string playerOneChoice;
        private string playerTwoChoice;

        public void ExecuteGameOptions()
        {
            game = true;
            while (game == true)
            {
                round = true;
                DisplayGameOptions();
                CheckGameModeUserInput();
                CheckIfContinuePlaying();
                ExecuteStartOfRound();
            }
        }
        private void ExecuteStartOfRound()
        {
            Console.Clear();
            playerName = true;
            CreatePlayers();
            while (round)
            {
                DisplayWhosTurn();
                ConvertChoice();
                GetRoundWinner();
                CheckForGameWinner();
                ProceedWithGame();
            }
            DisplayGameWinner();
        }
        private void DisplayGameOptions()
        {
            Console.WriteLine("ENTER NUMBER FOR GAME MODE");
            Console.WriteLine("1. Single Player");
            Console.WriteLine("2. Two Players");
            Console.WriteLine("3. Exit");
        }
        private void CheckGameModeUserInput()
        {
            try
            {
                gameMode = Convert.ToInt32(Console.ReadLine());
                if (gameMode > 3 || gameMode < 1)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("*ERROR: invalid game mode choice");
                ProceedWithGame();
                DisplayGameOptions();
            }
        }
        private void DisplayScore()
        {
            Console.WriteLine("{0} SCORE: {1} - {2} SCORE: {3}", playerOne.name, playerOne.score, playerTwo.name, playerTwo.score);
        }
        private void DisplayWhosTurn()
        {
            DisplayScore();
            Console.WriteLine("It's {0}'s turn to choose.", playerOne.name);
            playerOne.GetPlayerChoice();
            Console.Clear();
            DisplayScore();
            Console.WriteLine("It's {0}'s turn to choose.", playerTwo.name);
            playerTwo.GetPlayerChoice();
            Console.Clear();
        }
        private void DisplayGameWinner()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine("{0} defeated {1} with a score of {2} to {3}", playerOne.name, playerTwo.name, playerOne.score, playerTwo.score);
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine("{0} defeated {1} with a score of {2} to {3}", playerTwo.name, playerOne.name, playerTwo.score, playerOne.score);
            }
            ProceedWithGame();
        }
        private void GetPlayerName()
        {
            DisplayEnterName();
            name = Console.ReadLine();         
        }
        private void CreatePlayers()
        {
            if (gameMode == 1)
            {
                GetPlayerName();
                CheckNameInput();              
                playerOne = new Human(name);
                playerTwo = new Computer();
                Console.Clear();
            }
            else if (gameMode == 2)
            {
                name = "";
                while (playerName == true && name == "")
                {
                    GetPlayerName();
                    CheckNameInput();
                    playerOne = new Human(name);
                    Console.Clear();
                }
                while (playerName == false)
                {
                    GetPlayerName();
                    CheckNameInput();
                    playerName = true;
                    playerTwo = new Human(name);
                    Console.Clear();
                }
            }
        }
        private void DisplayEnterName()
        {
            if (playerName == true)
            {
                Console.WriteLine("Enter Player One Name");
            }
            else if (playerName == false)
            {
                Console.WriteLine("Enter Player Two Name");
            }
        }
        private void CheckNameInput()
        {
            if (name == "")
            {
                Console.Clear();
                Console.WriteLine("*ERROR: no name entered");
                ProceedWithGame();
                CreatePlayers();
            }
            else
            {
                playerName = false;
            }
        }
        private void GetRoundWinner()
        {
            int difference = (playerOne.choice + 5 - playerTwo.choice) % 5;
            if (difference == 1 || difference == 3)
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}", playerOne.name, playerOneChoice, playerTwo.name, playerTwoChoice);
                Console.WriteLine("{0} WINS!!", playerOne.name);
                playerOne.score++;
            }
            else if (difference == 2 || difference == 4)
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}", playerOne.name, playerOneChoice, playerTwo.name, playerTwoChoice);
                Console.WriteLine("{0} WINS!!", playerTwo.name);
                playerTwo.score++;
            }
            else if (difference == 0)
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}", playerOne.name, playerOneChoice, playerTwo.name, playerTwoChoice);
                Console.WriteLine("{0} and {1} TIED!!", playerOne.name, playerTwo.name);
            }
        }
        private void CheckForGameWinner()
        {
            if (playerOne.score == 2 || playerTwo.score == 2)
            {
                round = false;
            }
        }
        private void CheckIfContinuePlaying()
        {
            if (gameMode == 3)
            {
                Environment.Exit(0);
            }
        }
        private void ConvertChoice()
        {
            List<string> choices = new List<string>() { "ROCK", "PAPER", "SCISSORS", "SPOCK", "LIZARD" };
            playerOneChoice = choices[playerOne.choice];
            playerTwoChoice = choices[playerTwo.choice];
        }
        private void ProceedWithGame()
        {
            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
