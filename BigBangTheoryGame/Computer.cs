using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangTheoryGame
{
    class Computer : Player
    {
        public Computer()
        {
            this.name = "Sheldon Cooper";
        }
        public override void GetPlayerChoice()
        {
            //ROCK", "PAPER", "SCISSORS", "SPOCK", "LIZARD" };
            Random random = new Random();
            choice = random.Next(0, 4);
        }
    }
}
