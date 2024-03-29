using System.Diagnostics;
using Fighters.Models.Armors;
using Fighters.Models.Fighters;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters;
internal class UI
{
    Messages messages = new Messages();

    public string GetFighterName()
    {
        Console.WriteLine( messages.CreateFighterNameMessage );

        string? fighterName = Console.ReadLine();

        if (string.IsNullOrEmpty( fighterName ) )
        {
            Console.WriteLine( messages.NullOrEmptyNameErrorMessage );

            GetFighterName();
        }

        return fighterName;
    }

    public IRace GetFighterRace() 
    {
        Console.WriteLine( messages.AvailableRacesMessage );
        Console.WriteLine( messages.ChooseFighterRaceMessage );

        string? race = Console.ReadLine().ToLower();

        if ( string.IsNullOrEmpty( race ) )
        {
            Console.WriteLine( messages.NullOrEmptyRaceErrorMessage );

            GetFighterRace();
        }

        return ChooseRace(race);
    }

    public IWeapon GetFighterWeapon()
    {
        Console.WriteLine( messages.AvailableWeaponsQualityMessage );
        Console.WriteLine( messages.ChooseFighterWeaponMessage );

        string? qualityOfWeapon = Console.ReadLine().ToLower();

        if ( string.IsNullOrEmpty( qualityOfWeapon ) )
        {
            Console.WriteLine( messages.NullOrEmptyWeaponErrorMessage );

            GetFighterWeapon();
        }

        return ChooseQualityOfWeapon(qualityOfWeapon);

    }

    public IArmor GetFighterArmor()
    {
        Console.WriteLine( messages.AvailableArmorsQualityMessage );
        Console.WriteLine( messages.ChooseFighterArmorMessage );

        string? qualityOfArmor = Console.ReadLine().ToLower();

        if ( string.IsNullOrEmpty( qualityOfArmor ) )
        {
            Console.WriteLine( messages.NullOrEmptyWeaponErrorMessage );

            GetFighterArmor();
        }

        return ChooseQualityOfArmor( qualityOfArmor );

    }

    public void ClearUI()
    {
        Console.ReadKey();
        Console.Clear();
    }

    private IArmor ChooseQualityOfArmor( string qualityOfArmor )
    {
        switch ( qualityOfArmor )
        {
            case "low":
                return new LowQualityArmor();

            case "average":
                return new AverageQualityArmor();

            case "high":
                return new HighQualityArmor();

            default:
                return new LowQualityArmor();
        }
    }

    private IWeapon ChooseQualityOfWeapon( string qualityOfWeapon )
    {
        switch ( qualityOfWeapon )
        {
            case "low":
                return new LowQualityWeapon();

            case "average":
                return new AverageQualityWeapon();

            case "high":
                return new HighQualityWeapon();

            default:
                return new LowQualityWeapon();
        }
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
