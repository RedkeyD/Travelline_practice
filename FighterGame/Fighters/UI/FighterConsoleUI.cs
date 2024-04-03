using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Races;
using Fighters.Models.Weapons;
using Fighters.UI;

namespace Fighters;

public class FighterConsoleUI : IFighterUserUnterface
{
    private readonly RaceFabric _raceFabric;
    private readonly WeaponFabric _weaponFabric;
    private readonly ArmorFabric _armorFabric;
    private readonly ClassFabric _classFabric;

    public FighterConsoleUI()
    {
        _raceFabric = new RaceFabric();
        _weaponFabric = new WeaponFabric();
        _armorFabric = new ArmorFabric();
        _classFabric = new ClassFabric();
    }

    public string GetName()
    {
        string fighterName = GetInput( Messages.CreateFighterName );
        return fighterName;
    }

    public IArmor GetArmor()
    {
        string fighterArmor = GetInput( Messages.AvailableArmors );
        return _armorFabric.ChooseArmor( fighterArmor );
    }

    public IWeapon GetWeapon()
    {
        string fighterWeapon = GetInput( Messages.AvailableWeapons );
        return _weaponFabric.ChooseWeapon( fighterWeapon );
    }

    public IRace GetRace()
    {
        string fighterRace = GetInput( Messages.AvailableRaces );
        return _raceFabric.ChooseRace( fighterRace );
    }

    public IClass GetClass()
    {
        string fighterClass = GetInput( Messages.AvailableClasses );
        return _classFabric.ChooseFighterClass( fighterClass );
    }

    public string GetInput( string promptMessage )
    {
        Console.WriteLine( promptMessage );
        string input = Console.ReadLine();

        while ( string.IsNullOrEmpty( input ) )
        {
            Console.WriteLine( Messages.NullOrEmptyError );
            input = Console.ReadLine();
        }

        Console.Clear();
        return input.ToLower();
    }
}

