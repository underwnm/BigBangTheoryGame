using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangTheoryGame
{
    class Game
    {
        List<string> options = new List<string>() { "ROCK", "PAPER", "SCISSORS", "LIZARD", "SPOCK" };
        public string userInput;
        public string userOneChoice;
        //public string userTwoChoice;
        public string computerChoice;
        public bool keepPlaying = true;
        public int computerScore = 0;
        public int userOneScore = 0;
        //public int userTwoScore;

        public void ExecuteGame()
        {
            while (keepPlaying)
            {
                DisplayScore();
                DisplayUserChoices();
                GetUserInput();
                userOneChoice = CheckUserInput(userInput);
                if (userOneChoice != "INVALID")
                {
                    GetComputerChoice();
                    GetYouTie();
                    GetYouWon();
                    GetYouLose();
                }
                else
                {
                    Console.WriteLine("INVALID ENTRY");
                }
                if (userOneScore == 2 || computerScore == 2)
                {
                    keepPlaying = false;
                }
            }
            DisplayWinner();
        }
        public void ProceedWithGame()
        {
            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadKey();
            Console.Clear();
        }
        public void DisplayScore()
        {
            Console.WriteLine("USER SCORE: {0} ------ COMPUTER SCORE: {1}", userOneScore, computerScore);
        }
        public void DisplayWinner()
        {
            if (userOneScore == 2)
            {
                Console.WriteLine("CONGRATS YOU WON");
            }
            else if (computerScore == 2)
            {
                Console.WriteLine("YOU LOSE AND THE COMPUTER WINS");
            }
        }
        public void DisplayUserChoices()
        {
            Console.WriteLine("Enter one of the following");
            Console.WriteLine("Rock");
            Console.WriteLine("Paper");
            Console.WriteLine("Scissors");
            Console.WriteLine("Lizard");
            Console.WriteLine("Spock");
            Console.WriteLine("YOUR CHOICE:\t");
        }
        public void GetUserInput()
        {
            userInput = Console.ReadLine().ToUpper();
        }
        public string CheckUserInput(string userInput)
        {
            switch (userInput)
            {
                case "ROCK":
                    return userInput;
                case "PAPER":
                    return userInput;
                case "SCISSORS":
                    return userInput;
                case "LIZARD":
                    return userInput;
                case "SPOCK":
                    return userInput;
                default:
                    return userInput = "INVALID";
            }
        }
        public void GetComputerChoice()
        {
            Random r = new Random();
            int number = r.Next(5);
            computerChoice = options[number];            
        }
        public void GetYouTie()
        {
            if (userOneChoice == computerChoice)
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("It's a tie");
                ProceedWithGame();
            }
        }
        public void GetYouWon()
        {
            if (userOneChoice == "SCISSORS" && computerChoice == "PAPER")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Scissors cuts Paper");
                Console.WriteLine("YOU WIN!!");
                userOneScore++;
                ProceedWithGame();
            }
            else if (userOneChoice == "PAPER" && computerChoice == "ROCK")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Paper covers Rock");
                Console.WriteLine("YOU WIN!!");
                userOneScore++;
                ProceedWithGame();
            }
            else if (userOneChoice == "ROCK" && computerChoice == "LIZARD")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Rock crushes Lizard");
                Console.WriteLine("YOU WIN!!");
                userOneScore++;
                ProceedWithGame();
            }
            else if (userOneChoice == "LIZARD" && computerChoice == "SPOCK")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Lizard poisons Spock");
                Console.WriteLine("YOU WIN!!");
                userOneScore++;
                ProceedWithGame();
            }
            else if (userOneChoice == "SPOCK" && computerChoice == "SCISSORS")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Spock smashes Scissors");
                Console.WriteLine("YOU WIN!!");
                userOneScore++;
                ProceedWithGame();
            }
            else if (userOneChoice == "SCISSORS" && computerChoice == "LIZARD")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Scissors decapitates Lizard");
                Console.WriteLine("YOU WIN!!");
                userOneScore++;
                ProceedWithGame();
            }
            else if (userOneChoice == "LIZARD" && computerChoice == "PAPER")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Lizard eats Paper");
                Console.WriteLine("YOU WIN!!");
                userOneScore++;
                ProceedWithGame();
            }
            else if (userOneChoice == "PAPER" && computerChoice == "SPOCK")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Paper disproves Spock");
                Console.WriteLine("YOU WIN!!");
                userOneScore++;
                ProceedWithGame();
            }
            else if (userOneChoice == "SPOCK" && computerChoice == "ROCK")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Spock vaporizes Rock");
                Console.WriteLine("YOU WIN!!");
                userOneScore++;
                ProceedWithGame();
            }
            else if (computerChoice == "ROCK" && userOneChoice == "SCISSORS")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Rock crushes Scissors");
                Console.WriteLine("YOU WIN!!");
                userOneScore++;
                ProceedWithGame();
            }
        }
        public void GetYouLose()
        {
            if ((computerChoice == "SCISSORS") && (userOneChoice == "PAPER"))
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Scissors cuts Paper");
                Console.WriteLine("YOU LOSE!");
                computerScore++;
                ProceedWithGame();
            }
            else if (computerChoice == "PAPER" && userOneChoice == "ROCK")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Paper covers Rock");
                Console.WriteLine("YOU LOSE!!");
                computerScore++;
                ProceedWithGame();
            }
            else if (computerChoice == "ROCK" && userOneChoice == "LIZARD")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Rock crushes Lizard");
                Console.WriteLine("YOU LOSE!!");
                computerScore++;
                ProceedWithGame();
            }
            else if (computerChoice == "LIZARD" && userOneChoice == "SPOCK")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Lizard poisons Spock");
                Console.WriteLine("YOU LOSE!!");
                computerScore++;
                ProceedWithGame();
            }
            else if (computerChoice == "SPOCK" && userOneChoice == "SCISSORS")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Spock smashes Scissors");
                Console.WriteLine("YOU LOSE!!");
                computerScore++;
                ProceedWithGame();
            }
            else if (computerChoice == "SCISSORS" && userOneChoice == "LIZARD")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Scissors decapitates Lizard");
                Console.WriteLine("YOU LOSE!!");
                computerScore++;
                ProceedWithGame();
            }
            else if (computerChoice == "LIZARD" && userOneChoice == "PAPER")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Lizard eats Paper");
                Console.WriteLine("YOU LOSE!!");
                computerScore++;
                ProceedWithGame();
            }
            else if (computerChoice == "PAPER" && userOneChoice == "SPOCK")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Paper disproves Spock");
                Console.WriteLine("YOU LOSE!!");
                computerScore++;
                ProceedWithGame();
            }
            else if (computerChoice == "SPOCK" && userOneChoice == "ROCK")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Spock vaporizes Rock");
                Console.WriteLine("YOU LOSE!!");
                computerScore++;
                ProceedWithGame();
            }
            else if (computerChoice == "ROCK" && userOneChoice == "SCISSORS")
            {
                Console.WriteLine("User has chosen {0} and computer {1}.", userOneChoice, computerChoice);
                Console.WriteLine("Rock crushes Scissors");
                Console.WriteLine("YOU LOSE!!");
                computerScore++;
                ProceedWithGame();
            }
        }
    }
}
