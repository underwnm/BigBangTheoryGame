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
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            Console.WriteLine("4. Spock");
            Console.WriteLine("5. Lizard");
            Console.WriteLine("ENTER YOUR CHOICE");
        }
        public virtual void GetPlayerChoice()
        {
            try
            {
                DisplayUserChoices();
                choice = Convert.ToInt32(Console.ReadLine()) - 1;

                if (choice > 4 || choice < 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("INVALID ENTRY \nPRESS ENTER TO CONTINUE");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("RE-ENTER a valid choice");
                GetPlayerChoice();
            }
        }        
    }
}
