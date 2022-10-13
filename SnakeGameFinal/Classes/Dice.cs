using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameFinal.Classes
{
    public class Dice
    {
        private static Random random = new Random();

        public static int Roll()
        {
            return random.Next(1, 7);
        }
    }
}
