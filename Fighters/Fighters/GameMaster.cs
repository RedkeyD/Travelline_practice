using Fighters.Models.Fighters;
using Fighters.UI;

namespace Fighters;
public class GameMaster
{
    private Random _random;
    private IFighterUserInterface _fighterUserInterface;

    public GameMaster( Random random, IFighterUserInterface fighterUserInterface )
    {
        _random = random;
        _fighterUserInterface = fighterUserInterface;
    }

    public IFighter PlayAndGetWinner( List<IFighter> fighters )
    {
        if ( fighters == null || fighters.Count == 0 )
        {
            throw new ArgumentException( "The fighters list is empty." );
        }

        if ( fighters.Count == 1 )
        {
            return fighters[ 0 ];
        }

        while ( fighters.Count > 1 )
        {
            _fighterUserInterface.Print( $"Number of fighters remaining: {fighters.Count}" );

            for ( int i = 0; i < fighters.Count - 1; i++ )
            {
                IFighter firstFighter = fighters[ i ];
                IFighter secondFighter = fighters[ _random.Next( i + 1, fighters.Count ) ];

                AttackEachOther( firstFighter, secondFighter );
            }


            fighters.RemoveAll( fighter => fighter.CurrentHealth < 1 );
        }

        return fighters[ 0 ];
    }


    private void AttackEachOther( IFighter fighter1, IFighter fighter2 )
    {
        _fighterUserInterface.Print( $"Fight between {fighter1.Name} and {fighter2.Name}" );

        Attack( fighter1, fighter2 );
        Attack( fighter2, fighter1 );

        _fighterUserInterface.Print(" ");
    }

    private void Attack( IFighter attacker, IFighter defender )
    {
        double damageModifier = CalculateDamageModifier();

        int baseDamage = ( int )( attacker.Damage * damageModifier );

        if ( IsCriticalHit( attacker.Weapon.CriticalHitChance ) )
        {
            _fighterUserInterface.Print( "Critical Hit!" );
            baseDamage *= 2;
        }

        int defense = defender.Defense;

        defender.TakeDamage( baseDamage, defense );

        _fighterUserInterface.Print(
            $"Fighter {defender.Name} takes {baseDamage} damage. " +
            $"Current health: {defender.CurrentHealth}" );
    }


    private double CalculateDamageModifier()
    {
        int randomDamageModifierRange = _random.Next( -10, 21 );
        double randomDamageModifierPercentage = randomDamageModifierRange / 100.0;
        double finalDamageModifier = 1 + randomDamageModifierPercentage;

        return finalDamageModifier;
    }


    private bool IsCriticalHit( int weaponCriticalHitChance )
    {
        int randomNumber = _random.Next( 1, 101 );
        bool isCriticalHit = randomNumber <= weaponCriticalHitChance;

        return isCriticalHit;
    }
}


