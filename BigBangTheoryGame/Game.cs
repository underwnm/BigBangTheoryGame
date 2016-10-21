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
        private bool playerName;
        private bool series;
        private bool gameplay;
        private int gameMode;
        private string userName;
        private string playerOneChoice;
        private string playerTwoChoice;

        public void ExecuteGameOptions()
        {
            gameplay = true;
            while (gameplay == true)
            {
                series = true;
                DisplayGameOptions();
                CheckGameOptionInput();
                ExecuteStartOfRound();
            }
        }
        private void DisplayGameOptions()
        {
            Console.WriteLine("ENTER NUMBER FOR GAME MODE");
            Console.WriteLine("1. Single Player");
            Console.WriteLine("2. Two Players");
            Console.WriteLine("3. Exit");
        }
        private void CheckGameOptionInput()
        {
            try
            {
                GetGameMode();
                if (gameMode > 3 || gameMode < 1)
                {
                    throw new Exception();
                }
                if (gameMode == 3)
                {
                    Environment.Exit(0);
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("*ERROR: invalid game mode choice");
                ProceedWithGame();
                ExecuteGameOptions();
            }
        }
        public void GetGameMode()
        {
            gameMode = Convert.ToInt32(GetUserInput());
        }
        private void ExecuteStartOfRound()
        {
            Console.Clear();
            playerName = true;
            CreatePlayers();
            while (series)
            {
                ExecutePlayerTurn();
                ConvertChoice();
                GetRoundWinner();
                CheckForGameWinner();
                ProceedWithGame();
            }
            DisplayGameWinner();
        }
        private void CreatePlayers()
        {
            if (gameMode == 1)
            {
                DisplayEnterName();
                userName = GetUserInput();
                CheckNameInput();
                playerOne = new Human(userName);
                playerTwo = new Computer();
                Console.Clear();
            }
            else if (gameMode == 2)
            {
                userName = "";
                while (playerName == true && userName == "")
                {
                    DisplayEnterName();
                    userName = GetUserInput();
                    CheckNameInput();
                    playerOne = new Human(userName);
                    Console.Clear();
                }
                while (playerName == false)
                {
                    DisplayEnterName();
                    userName = GetUserInput();
                    CheckNameInput();
                    playerName = true;
                    playerTwo = new Human(userName);
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
            if (userName == "")
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
        private void ExecutePlayerTurn()
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
        private void DisplayScore()
        {
            Console.WriteLine("{0} SCORE: {1} - {2} SCORE: {3}", playerOne.name, playerOne.score, playerTwo.name, playerTwo.score);
        }
        private void ConvertChoice()
        {
            List<string> choices = new List<string>() { "ROCK", "PAPER", "SCISSORS", "SPOCK", "LIZARD" };
            playerOneChoice = choices[playerOne.choice];
            playerTwoChoice = choices[playerTwo.choice];
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
                series = false;
            }
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
        private void ProceedWithGame()
        {
            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadKey();
            Console.Clear();
        }
        private string GetUserInput()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
