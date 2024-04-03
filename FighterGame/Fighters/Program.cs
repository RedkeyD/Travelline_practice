using Fighters.Models.Fighters;

namespace Fighters;

public class Program
{
    public static void Main()
    {
        FighterConsoleUI fighterConsoleUI = new FighterConsoleUI();

        List<IFighter> fighters = new List<IFighter>();

        var master = new GameMaster();
        var winner = master.PlayAndGetWinner( fighters[ 0 ], fighters[ 1 ] );

        Console.WriteLine( $"Winner {winner.Name}" );
    }
}