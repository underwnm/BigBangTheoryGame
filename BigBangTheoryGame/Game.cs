using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangTheoryGame
{
    class Game
    {
        Players playerOne;
        Players playerTwo;
        private bool keepPlaying = true;
        private bool round = true;
        private string name;
        private string gameMode;

        public void ExecuteGameOptions()
        {
            DisplayGameOptions();
            ExecuteStartOfRound();
            DisplayGameOptions();
        }
        private void DisplayGameOptions()
        {
            Console.WriteLine("ENTER NUMBER FOR GAME MODE");
            Console.WriteLine("1. Single Player");
            Console.WriteLine("2. Two Players");
            Console.WriteLine("3. Exit");
            gameMode = Console.ReadLine();
        }
        private void ExecuteStartOfRound()
        {
            GetPlayerName();
            while (keepPlaying)
            {
                DisplayPlayerChoices();
                CheckGameMode();
                CheckForWinner();
            }
            DisplayWinner();
        }
        private void DisplayPlayerChoices()
        {
            DisplayScore();
            Console.WriteLine("{0} ENTER ONE OF THE FOLLOWING", playerOne.name);
            playerOne.GetPlayerChoice();
            ProceedWithGame();
            if (gameMode == "2")
            {
                Console.WriteLine("{0} ENTER ONE OF THE FOLLOWING", playerTwo.name);
            }
            playerTwo.GetPlayerChoice();
        }
        private void DisplayScore()
        {
            Console.WriteLine("{0} SCORE: {1} - {2} SCORE: {3}", playerOne.name, playerOne.score, playerTwo.name, playerTwo.score);
        }
        private void CheckGameMode()
        {
            if (gameMode == "2")
            {
                ProceedWithGame();
            }
            if (playerOne.choice != "INVALID" && playerTwo.choice != "INVALID")
            {
                CheckTie();
                CheckWinPlayerOne();
                CheckWinPlayerTwo();
            }
            else
            {
                Console.WriteLine("INVALID ENTRY");
                ProceedWithGame();
            }
        }
        private void CheckForWinner()
        {
            if (playerOne.score == 2 || playerTwo.score == 2)
            {
                keepPlaying = false;
            }
        }
        private void GetPlayerName()
        {
            Console.WriteLine("Enter Name of Player One");
            name = Console.ReadLine();
            playerOne = new Human(name);

            if (gameMode == "1")
            {
                playerTwo = new Computer("Sheldon Lee Cooper");
            }
            else if (gameMode == "2")
            {
                Console.WriteLine("Enter Name of Player Two");
                name = Console.ReadLine();
                playerTwo = new Human(name);
            }
            else if (gameMode =="3")
            {
                Environment.Exit(0);
            }
            ProceedWithGame();

        }
        private void ProceedWithGame()
        {
            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadKey();
            Console.Clear();
        }
        private bool CheckTie()
        {
            if (playerOne.choice == playerTwo.choice)
            {
                Console.WriteLine("{0} chose {1} and {2} chose {1}.", playerTwo.name, playerTwo.choice, playerOne.name, playerOne.choice);
                Console.WriteLine("It's a tie");
                round = false;
                ProceedWithGame();
            }
            return round;
        }
        private bool CheckWinPlayerOne()
        {
            if (playerOne.choice == "SCISSORS" && playerTwo.choice == "PAPER")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerOne.name, playerOne.choice, playerTwo.name, playerTwo.choice);
                Console.WriteLine("Scissors cuts Paper");
                Console.WriteLine("{0} you WON this round!!", playerOne.name);
                playerOne.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerOne.choice == "PAPER" && playerTwo.choice == "ROCK")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerOne.name, playerOne.choice, playerTwo.name, playerTwo.choice);
                Console.WriteLine("Paper covers Rock");
                Console.WriteLine("{0} you WON this round!!", playerOne.name);
                playerOne.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerOne.choice == "ROCK" && playerTwo.choice == "LIZARD")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerOne.name, playerOne.choice, playerTwo.name, playerTwo.choice);
                Console.WriteLine("Rock crushes Lizard");
                Console.WriteLine("{0} you WON this round!!", playerOne.name);
                playerOne.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerOne.choice == "LIZARD" && playerTwo.choice == "SPOCK")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerOne.name, playerOne.choice, playerTwo.name, playerTwo.choice);
                Console.WriteLine("Lizard poisons Spock");
                Console.WriteLine("{0} you WON this round!!", playerOne.name);
                playerOne.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerOne.choice == "SPOCK" && playerTwo.choice == "SCISSORS")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerOne.name, playerOne.choice, playerTwo.name, playerTwo.choice);
                Console.WriteLine("Spock smashes Scissors");
                Console.WriteLine("{0} you WON this round!!", playerOne.name);
                playerOne.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerOne.choice == "SCISSORS" && playerTwo.choice == "LIZARD")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerOne.name, playerOne.choice, playerTwo.name, playerTwo.choice);
                Console.WriteLine("Scissors decapitates Lizard");
                Console.WriteLine("{0} you WON this round!!", playerOne.name);
                playerOne.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerOne.choice == "LIZARD" && playerTwo.choice == "PAPER")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerOne.name, playerOne.choice, playerTwo.name, playerTwo.choice);
                Console.WriteLine("Lizard eats Paper");
                Console.WriteLine("{0} you WON this round!!", playerOne.name);
                playerOne.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerOne.choice == "PAPER" && playerTwo.choice == "SPOCK")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerOne.name, playerOne.choice, playerTwo.name, playerTwo.choice);
                Console.WriteLine("Paper disproves Spock");
                Console.WriteLine("{0} you WON this round!!", playerOne.name);
                playerOne.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerOne.choice == "SPOCK" && playerTwo.choice == "ROCK")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerOne.name, playerOne.choice, playerTwo.name, playerTwo.choice);
                Console.WriteLine("Spock vaporizes Rock");
                Console.WriteLine("{0} you WON this round!!", playerOne.name);
                playerOne.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerOne.choice == "ROCK" && playerTwo.choice == "SCISSORS")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerOne.name, playerOne.choice, playerTwo.name, playerTwo.choice);
                Console.WriteLine("Rock crushes Scissors");
                Console.WriteLine("{0} you WON this round!!", playerOne.name);
                playerOne.score++;
                round = false;
                ProceedWithGame();
            }
            return round;
        }
        private bool CheckWinPlayerTwo()
        {
            if (playerTwo.choice == "SCISSORS" && playerOne.choice == "PAPER")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerTwo.name, playerTwo.choice, playerOne.name, playerOne.choice);
                Console.WriteLine("Scissors cuts Paper");
                Console.WriteLine("{0} you WON this round!!", playerTwo.name);
                playerTwo.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerTwo.choice == "PAPER" && playerOne.choice == "ROCK")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerTwo.name, playerTwo.choice, playerOne.name, playerOne.choice);
                Console.WriteLine("Paper covers Rock");
                Console.WriteLine("{0} you WON this round!!", playerTwo.name);
                playerTwo.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerTwo.choice == "ROCK" && playerOne.choice == "LIZARD")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerTwo.name, playerTwo.choice, playerOne.name, playerOne.choice);
                Console.WriteLine("Rock crushes Lizard");
                Console.WriteLine("{0} you WON this round!!", playerTwo.name);
                playerTwo.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerTwo.choice == "LIZARD" && playerOne.choice == "SPOCK")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerTwo.name, playerTwo.choice, playerOne.name, playerOne.choice);
                Console.WriteLine("Lizard poisons Spock");
                Console.WriteLine("{0} you WON this round!!", playerTwo.name);
                playerTwo.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerTwo.choice == "SPOCK" && playerOne.choice == "SCISSORS")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerTwo.name, playerTwo.choice, playerOne.name, playerOne.choice);
                Console.WriteLine("Spock smashes Scissors");
                Console.WriteLine("{0} you WON this round!!", playerTwo.name);
                playerTwo.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerTwo.choice == "SCISSORS" && playerOne.choice == "LIZARD")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerTwo.name, playerTwo.choice, playerOne.name, playerOne.choice);
                Console.WriteLine("Scissors decapitates Lizard");
                Console.WriteLine("{0} you WON this round!!", playerTwo.name);
                playerTwo.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerTwo.choice == "LIZARD" && playerOne.choice == "PAPER")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerTwo.name, playerTwo.choice, playerOne.name, playerOne.choice);
                Console.WriteLine("Lizard eats Paper");
                Console.WriteLine("{0} you WON this round!!", playerTwo.name);
                playerTwo.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerTwo.choice == "PAPER" && playerOne.choice == "SPOCK")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerTwo.name, playerTwo.choice, playerOne.name, playerOne.choice);
                Console.WriteLine("Paper disproves Spock");
                Console.WriteLine("{0} you WON this round!!", playerTwo.name);
                playerTwo.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerTwo.choice == "SPOCK" && playerOne.choice == "ROCK")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerTwo.name, playerTwo.choice, playerOne.name, playerOne.choice);
                Console.WriteLine("Spock vaporizes Rock");
                Console.WriteLine("{0} you WON this round!!", playerTwo.name);
                playerTwo.score++;
                round = false;
                ProceedWithGame();
            }
            else if (playerTwo.choice == "ROCK" && playerOne.choice == "SCISSORS")
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3}.", playerTwo.name, playerTwo.choice, playerOne.name, playerOne.choice);
                Console.WriteLine("Rock crushes Scissors");
                Console.WriteLine("{0} you WON this round!!", playerTwo.name);
                playerTwo.score++;
                round = false;
                ProceedWithGame();
            }
            return round;
        }
        private void DisplayWinner()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine("CONGRATS {0} YOU WON THE BEST 2 OUT OF 3", playerOne.name);
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine("CONGRATS {0} YOU WON THE BEST 2 OUT OF 3", playerTwo.name);
            }
            ProceedWithGame();
        }
    }
}
