using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Fighters;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

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

    public IFighter CreateFighter()
    {
        string fighterName = GetFighterName();
        IRace fighterRace = GetFighterRace();
        IWeapon fighterWeapon = GetFighterWeapon();
        IArmor fighterArmor = GetFighterArmor();
        IClass fighterClass = GetFighterClass();

        Fighter fighter = new Fighter( fighterName, fighterRace, fighterWeapon, fighterArmor, fighterClass );
        return fighter;
    }
}
