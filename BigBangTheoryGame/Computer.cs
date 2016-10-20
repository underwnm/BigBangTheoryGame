using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangTheoryGame
{
    class Computer : Players
    {
        public Computer(string name)
        {
            this.name = name;
        }
        public override void GetPlayerChoice()
        {
            List<string> choices = new List<string>() { "ROCK", "PAPER", "SCISSORS", "LIZARD", "SPOCK" };
            Random random = new Random();
            int number = random.Next(0, 5);
            choice = choices[number];
        }
    }
}
