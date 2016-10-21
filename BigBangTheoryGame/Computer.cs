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
            //ROCK", "PAPER", "SCISSORS", "SPOCK", "LIZARD" };
            Random random = new Random();
            choice = random.Next(0, 4);
        }
    }
}
