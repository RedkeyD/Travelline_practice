using Fighters.Models.Fighters;
using Fighters.Models.Races;

namespace Fighters;

public class Program
{
    public static void Main()
    {
        UI ui = new UI();

        var firstFighter = new Fighter( 
            ui.GetFighterName(), 
            ui.GetFighterRace(), 
            ui.GetFighterWeapon(), 
            ui.GetFighterArmor() );

        Console.WriteLine( Messages.G );
        ui.Clear();

        var secondFighter = new Fighter(
            ui.GetFighterName(),
            ui.GetFighterRace(),
            ui.GetFighterWeapon(),
            ui.GetFighterArmor() );

        Console.WriteLine( Messages.StartFight );
        ui.Clear();

        var master = new GameMaster();
        var winner = master.PlayAndGetWinner( firstFighter, secondFighter );

        Console.WriteLine( $"Выигрывает  {winner.Name}" );
    }
}
