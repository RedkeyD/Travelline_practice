using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Fighters;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters;
internal class UI
{
    public IFighter CreateFighter()
    {
        Fighter fighter = new Fighter(
            GetFighterName(),
            GetFighterRace(),
            GetFighterWeapon(),
            GetFighterArmor(),
            GetFighterClass() );

        return fighter;
    }

    private string GetFighterName()
    {
        Console.WriteLine( Messages.CreateFighterName );

        string? fighterName = Console.ReadLine();

        if (string.IsNullOrEmpty( fighterName ) )
        {
            Console.WriteLine( Messages.NullOrEmptyNameError);

            GetFighterName();
        }

        return fighterName;
    }

    private IRace GetFighterRace() 
    {
        Console.WriteLine( Messages.AvailableRaces );
        Console.WriteLine( Messages.ChooseFighterRace );

        string? race = Console.ReadLine().ToLower();
        RaceFabric raceFabric = new RaceFabric();

        if ( string.IsNullOrEmpty( race ) )
        {
            Console.WriteLine( Messages.NullOrEmptyRaceError );

            GetFighterRace();
        }

        return raceFabric.ChooseRace(race);
    }

    private IWeapon GetFighterWeapon()
    {
        Console.WriteLine( Messages.AvailableWeaponsQuality );
        Console.WriteLine( Messages.ChooseFighterWeapon);

        WeaponFabric weaponFabric = new WeaponFabric();

        string? qualityOfWeapon = Console.ReadLine().ToLower();

        if ( string.IsNullOrEmpty( qualityOfWeapon ) )
        {
            Console.WriteLine( Messages.NullOrEmptyWeaponError );

            GetFighterWeapon();
        }

        return weaponFabric.ChooseQualityOfWeapon(qualityOfWeapon);

    }

    private IArmor GetFighterArmor()
    {
        Console.WriteLine( Messages.AvailableArmorsQuality );
        Console.WriteLine( Messages.ChooseFighterArmor );

        ArmorFabric armorFabric = new ArmorFabric();

        string? qualityOfArmor = Console.ReadLine().ToLower();

        if ( string.IsNullOrEmpty( qualityOfArmor ) )
        {
            Console.WriteLine( Messages.NullOrEmptyWeaponError );

            GetFighterArmor();
        }

        return armorFabric.ChooseQualityOfArmor( qualityOfArmor );

    }

    private IClass GetFighterClass()
    {
        Console.WriteLine( Messages.AvailableClasses );
        Console.WriteLine( Messages.ChooseFighterClass );

        ClassFabric classFabric = new ClassFabric();

        string? fighterClass = Console.ReadLine().ToLower();

        if ( string.IsNullOrEmpty( fighterClass ) )
        {
            Console.WriteLine( Messages.NullOrEmptyClassError );

            GetFighterArmor();
        }

        return classFabric.ChooseFighterClass( fighterClass );

    }

    public void Clear()
    {
        Console.ReadKey();
        Console.Clear();
    } 
}