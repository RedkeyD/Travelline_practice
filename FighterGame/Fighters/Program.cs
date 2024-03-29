using Fighters.Models.Fighters;
using Fighters.Models.Races;

namespace Fighters;

public class Program
{
    public static void Main()
    {
        UI ui = new UI();
        Messages messages = new Messages();

        var firstFighter = new Fighter( ui.GetFighterName(), ui.GetFighterRace(), ui.GetFighterWeapon(), ui.GetFighterArmor() );
        Console.WriteLine( messages.FighterCreatedMessage );
        ui.ClearUI();

        var secondFighter = new Fighter(ui.GetFighterName(), ui.GetFighterRace(), ui.GetFighterWeapon(), ui.GetFighterArmor() );
        Console.WriteLine( messages.StartFightMessage );
        ui.ClearUI();

        var master = new GameMaster();
        var winner = master.PlayAndGetWinner( firstFighter, secondFighter );

        Console.WriteLine( $"Выигрывает  {winner.Name}" );
    }
}
