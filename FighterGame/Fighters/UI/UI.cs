using System;
using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Fighters;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters;

public class UI
{
    private readonly RaceFabric raceFabric = new RaceFabric();
    private readonly WeaponFabric weaponFabric = new WeaponFabric();
    private readonly ArmorFabric armorFabric = new ArmorFabric();
    private readonly ClassFabric classFabric = new ClassFabric();

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

    private string GetFighterName()
    {
        Console.WriteLine( Messages.CreateFighterName );
        string fighterName = Console.ReadLine();

        if ( string.IsNullOrEmpty( fighterName ) )
        {
            Console.WriteLine( Messages.NullOrEmptyNameError );
            fighterName = GetFighterName();
        }

        Console.Clear();
        return fighterName;
    }

    private IRace GetFighterRace()
    {
        Console.WriteLine( Messages.AvailableRaces );
        Console.WriteLine( Messages.ChooseFighterRace );
        string race = Console.ReadLine().ToLower();

        if ( string.IsNullOrEmpty( race ) )
        {
            Console.WriteLine( Messages.NullOrEmptyRaceError );
            return GetFighterRace();
        }

        Console.Clear();
        return raceFabric.ChooseRace( race );
    }

    private IWeapon GetFighterWeapon()
    {
        Console.WriteLine( Messages.AvailableWeaponsQuality );
        Console.WriteLine( Messages.ChooseFighterWeapon );
        string qualityOfWeapon = Console.ReadLine().ToLower();

        if ( string.IsNullOrEmpty( qualityOfWeapon ) )
        {
            Console.WriteLine( Messages.NullOrEmptyWeaponError );
            return GetFighterWeapon();
        }

        Console.Clear();
        return weaponFabric.ChooseQualityOfWeapon( qualityOfWeapon );
    }

    private IArmor GetFighterArmor()
    {
        Console.WriteLine( Messages.AvailableArmorsQuality );
        Console.WriteLine( Messages.ChooseFighterArmor );
        string qualityOfArmor = Console.ReadLine().ToLower();

        if ( string.IsNullOrEmpty( qualityOfArmor ) )
        {
            Console.WriteLine( Messages.NullOrEmptyArmorError );
            return GetFighterArmor();
        }

        Console.Clear();
        return armorFabric.ChooseQualityOfArmor( qualityOfArmor );
    }

    private IClass GetFighterClass()
    {
        Console.WriteLine( Messages.AvailableClasses );
        Console.WriteLine( Messages.ChooseFighterClass );
        string fighterClass = Console.ReadLine().ToLower();

        if ( string.IsNullOrEmpty( fighterClass ) )
        {
            Console.WriteLine( Messages.NullOrEmptyClassError );
            return GetFighterClass();
        }

        Console.Clear();
        return classFabric.ChooseFighterClass( fighterClass );
    }
}
