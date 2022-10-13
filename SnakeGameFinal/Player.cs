using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameFinal
{
    public class Player
    {
        public string name { get; set; }
        public int newPosition { get; set; }

        public Player(string name)
        {
            this.name = name;
        }

        public void DiceRoll()
        {
            int number = Dice.roll();
            newPosition += number;
            if (newPosition > 50)
            {
                newPosition = 25;
                Console.WriteLine(name + " a dépassé la position 50, il retombe à 25");
            }
            Console.WriteLine(name + " a jeté son dé et à obtenu le score de " + number + " sa position est de " + newPosition);
            Console.WriteLine("\n");
        }

    }
}
