using Fighters.Models.Fighters;

namespace Fighters;

public class GameMaster
{
    public IFighter PlayAndGetWinner( List<IFighter> fighters )
    {
        while ( fighters.Count > 1 )
        {
            Console.WriteLine( $"Number of fighters remaining: {fighters.Count}" );

            // Organize duels between adjacent fighters
            for ( int i = 0; i < fighters.Count - 1; i += 2 )
            {
                IFighter firstFighter = fighters[ i ];
                IFighter secondFighter = fighters[ i + 1 ];

                IFighter winner = Duel( firstFighter, secondFighter );

                Console.WriteLine( $"Winner of the duel: {winner.Name}" );
                Console.WriteLine();
            }

            // Remove defeated fighters
            fighters.RemoveAll( fighter => fighter.CurrentHealth < 1 );
        }

        // Return the remaining fighter (the winner)
        return fighters[ 0 ];
    }

    private IFighter Duel( IFighter firstFighter, IFighter secondFighter )
    {
        Console.WriteLine( $"Duel between {firstFighter.Name} and {secondFighter.Name}" );

        int round = 1;
        while ( true )
        {
            Console.WriteLine( $"Round {round++}." );

            // Determine which fighter attacks first based on speed
            IFighter attacker, defender;

            if ( firstFighter.Speed >= secondFighter.Speed )
            {
                attacker = firstFighter;
                defender = secondFighter;
            }
            else
            {
                attacker = secondFighter;
                defender = firstFighter;
            }

            // Attacker fights defender
            if ( FightAndCheckIfOpponentDead( attacker, defender ) )
            {
                return attacker;
            }

            // Defender fights attacker
            if ( FightAndCheckIfOpponentDead( defender, attacker ) )
            {
                return defender;
            }

            Console.WriteLine();
        }
    }

    private bool FightAndCheckIfOpponentDead( IFighter attacker, IFighter defender )
    {
        // Calculate damage as a random value within a range
        double damageModifier = GetDamageModifier();
        int damage = ( int )( attacker.Damage * damageModifier );

        // Check for critical damage
        if ( IsCriticalHit() )
        {
            Console.WriteLine( "Critical Hit!" );
            damage *= 2; // Double the damage for critical hits
        }

        int defense = defender.Defense;

        defender.TakeDamage( damage, defense );

        Console.WriteLine(
            $"Fighter {defender.Name} takes {damage} damage. " +
            $"Current health: {defender.CurrentHealth}" );

        return defender.CurrentHealth < 1;
    }

    // Method to get a random damage modifier between -10% and +20%
    private double GetDamageModifier()
    {
        Random random = new Random();
        double modifier = random.Next( -10, 21 ) / 100.0; // Generates a random integer between -10 and 20
        return 1 + modifier; // Adding 1 ensures the modifier is between -0.1 and +0.2
    }

    // Method to determine if the attack is a critical hit
    private bool IsCriticalHit()
    {
        Random random = new Random();
        int chance = random.Next( 1, 101 ); // Generates a random integer between 1 and 100
        return chance <= 10; // 10% chance of critical hit 
    }
}