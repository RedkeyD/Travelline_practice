using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Fighters;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters.UI;

public class FighterConsoleUI : IFighterUserInterface
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

    public List<IFighter> CreateFighters( int numFighters )
    {
        List<IFighter> fighters = new List<IFighter>();

        for ( int i = 0; i < numFighters; i++ )
        {
            fighters.Add( CreateFighter() );
        }

        return fighters;
    }

    public void DetailsOfFighters( List<IFighter> fighters )
    {
        Console.WriteLine( Messages.FightersDetails );

        foreach ( var fighter in fighters )
        {
            Console.WriteLine( fighter.ToString() );
        }
    }

    public IFighter CreateFighter()
    {
        string name = GetName();

        IArmor armor = GetArmor();
        IWeapon weapon = GetWeapon();
        IRace race = GetRace();
        IClass fighterClass = GetClass();

        Fighter fighter = new Fighter( name, armor, weapon, race, fighterClass );

        return fighter;
    }

    public void Print( string promptMessage )
    {
        Console.WriteLine( promptMessage );
    }

    public string Input( string promptMessage )
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

    public int IntInput( string promptMessage )
    {
        Console.WriteLine( promptMessage );
        string input = Console.ReadLine();
        int num;

        while ( !int.TryParse( input, out num ) )
        {
            Console.WriteLine( "Invalid input. Please enter a valid integer." );
            input = Console.ReadLine();
        }

        Console.Clear();
        return num;
    }

    private string GetName()
    {
        string fighterName = Input( Messages.CreateFighterName );
        return fighterName;
    }

    private IArmor GetArmor()
    {
        string fighterArmor = Input( Messages.AvailableArmors );
        return _armorFabric.ChooseArmor( fighterArmor );
    }

    private IWeapon GetWeapon()
    {
        string fighterWeapon = Input( Messages.AvailableWeapons );
        return _weaponFabric.ChooseWeapon( fighterWeapon );
    }

    private IRace GetRace()
    {
        string fighterRace = Input( Messages.AvailableRaces );
        return _raceFabric.ChooseRace( fighterRace );
    }

    private IClass GetClass()
    {
        string fighterClass = Input( Messages.AvailableClasses );
        return _classFabric.ChooseFighterClass( fighterClass );
    }
}