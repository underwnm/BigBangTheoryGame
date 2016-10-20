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
        public string choice;
        public int score = 0;

        public virtual void GetPlayerChoice()
        {
            DisplayUserChoices();
            choice = Console.ReadLine().ToUpper();
            choice = CheckPlayerChoice(choice);
        }
        private string CheckPlayerChoice(string userInput)
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
        private void DisplayUserChoices()
        {
            Console.WriteLine("Rock");
            Console.WriteLine("Paper");
            Console.WriteLine("Scissors");
            Console.WriteLine("Lizard");
            Console.WriteLine("Spock");
            Console.WriteLine("ENTER YOUR CHOICE");
        }
    }
}
