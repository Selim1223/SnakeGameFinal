using SnakeGameFinal.Classes;
using System.Numerics;

class Program
{

    private static void Main(string[] args)
    {
        startSnakeGame();
    }

    private static void startSnakeGame()
    {
        int gameTurn = 50;
        List<Player> players = new List<Player>();
        players.Add(new Player("John"));
        players.Add(new Player("Tom"));
        Game board = new Game(gameTurn, players);
        board.startGame();
    }

}
