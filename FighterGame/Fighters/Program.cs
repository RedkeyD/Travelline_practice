using Fighters.Models.Fighters;
using Fighters.Models.Races;

namespace Fighters;

public class Program
{
    public static void Main()
    {
        UI ui = new UI();

        List<IFighter> fighters = new List<IFighter>();
        fighters.Add(ui.CreateFighter());
        fighters.Add( ui.CreateFighter() );

        var master = new GameMaster();
        var winner = master.PlayAndGetWinner( fighters[0], fighters[1] );

        Console.WriteLine( $"Winner {winner.Name}" );
    }
}
