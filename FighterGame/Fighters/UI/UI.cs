using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters;

public class UI
{
    private readonly RaceFabric raceFabric = new RaceFabric();
    private readonly WeaponFabric weaponFabric = new WeaponFabric();
    private readonly ArmorFabric armorFabric = new ArmorFabric();
    private readonly ClassFabric classFabric = new ClassFabric();

    public string GetFighterName()
    {

    }

    public IRace GetFighterRace()
    {

    }

    public IWeapon GetFighterWeapon()
    {

    }

    public IArmor GetFighterArmor()
    {

    }

    public IClass GetFighterClass()
    {

    }

    public string GetInput( string promptMessage )
    {
        Console.WriteLine( promptMessage );
        string input = Console.ReadLine();

        while ( string.IsNullOrEmpty( input ) )
        {
            Console.WriteLine( "Error: Input cannot be empty. Please enter a valid value." );
            input = Console.ReadLine();
        }

        Console.Clear();
        return input.ToLower();
    }
}
