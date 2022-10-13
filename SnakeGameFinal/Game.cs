using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameFinal
{
    public class Game
    {
        private int gameTurn { get; set; }
        private List<Player> players { get; set; }
        bool gameIsFinished { get; set; }

        public Game(int turn, List<Player> players)
        {
            this.gameTurn = turn;
            this.players = players;
            this.gameIsFinished = false;
        }

        public void startGame()
        {
            while (!gameIsFinished)
                foreach (Player player in players)
                {
                    player.DiceRoll();
                    if (CheckIfPlayerWin())
                        break;
                }
        }

        private bool CheckIfPlayerWin()
        {
            foreach (Player player in players)
                if (player.newPosition == gameTurn)
                    return HandleWinnerPlayer(player);
            return false;
        }

        private bool HandleWinnerPlayer(Player player)
        {
            this.gameIsFinished = true;
            Console.WriteLine("Le joueur " + player.name + " a gagné la partie !");
            return true;
        }
    }
}
