using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangTheoryGame
{
    class Players
    {
        Game game = new Game();
        public string name;
        public int choice;
        public int score = 0;

        private void DisplayUserChoices()
        {
            Console.WriteLine("Rock");
            Console.WriteLine("Paper");
            Console.WriteLine("Scissors");
            Console.WriteLine("Lizard");
            Console.WriteLine("Spock");
            Console.WriteLine("ENTER YOUR CHOICE");
        }
        public virtual void GetPlayerChoice()
        {
            DisplayUserChoices();
            string userInput = Console.ReadLine().ToUpper();
            CheckPlayerChoice(userInput);
        }
        private void CheckPlayerChoice(string userInput)
        {
            switch (userInput)
            {
                case "ROCK":
                    choice = 0;
                    break;
                case "PAPER":
                    choice = 1;
                    break;
                case "SCISSORS":
                    choice = 2;
                    break;
                case "SPOCK":
                    choice = 3;
                    break;
                case "LIZARD":
                    choice = 4;
                    break;
                default:
                    choice = 5;
                    Console.WriteLine("INVALID INPUT");
                    break;
            }
        }
    }
}
