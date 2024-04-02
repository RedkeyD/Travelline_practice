using System.Diagnostics;
using Fighters.Models.Armors;
using Fighters.Models.Fighters;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters;
internal class UI
{

    public string GetFighterName()
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

    public IRace GetFighterRace() 
    {
        Console.WriteLine( Messages.AvailableRaces );
        Console.WriteLine( Messages.ChooseFighterRace );

        string? race = Console.ReadLine().ToLower();

        if ( string.IsNullOrEmpty( race ) )
        {
            Console.WriteLine( Messages.NullOrEmptyRaceError );

            GetFighterRace();
        }

        return ChooseRace(race);
    }

    public IWeapon GetFighterWeapon()
    {
        Console.WriteLine( Messages.AvailableWeaponsQuality );
        Console.WriteLine( Messages.ChooseFighterWeapon);

        string? qualityOfWeapon = Console.ReadLine().ToLower();

        if ( string.IsNullOrEmpty( qualityOfWeapon ) )
        {
            Console.WriteLine( Messages.NullOrEmptyWeaponError );

            GetFighterWeapon();
        }

        WeaponFabric weaponFabric = new WeaponFabric();
        return weaponFabric.ChooseQualityOfWeapon(qualityOfWeapon);

    }

    public IArmor GetFighterArmor()
    {
        Console.WriteLine( Messages.AvailableArmorsQuality );
        Console.WriteLine( Messages.ChooseFighterArmor );

        string? qualityOfArmor = Console.ReadLine().ToLower();

        if ( string.IsNullOrEmpty( qualityOfArmor ) )
        {
            Console.WriteLine( Messages.NullOrEmptyWeaponError );

            GetFighterArmor();
        }

        ArmorFabric armorFabric = new ArmorFabric();
        return armorFabric.ChooseQualityOfArmor( qualityOfArmor );

    }

    public void Clear()
    {
        Console.ReadKey();
        Console.Clear();
    }



    private IRace ChooseRace( string race )
    {
        switch ( race )
        {
            case "human":
                return new Human();

            case "dwarf":
                return new Dwarf();

            case "angel":
                return new Angel();

            case "demon":
                return new Demon();

            case "werewolf":
                return new Werewolf();

            case "vampire":
                return new Vampire();

            default:
                return new Human();
        }
    }
}
