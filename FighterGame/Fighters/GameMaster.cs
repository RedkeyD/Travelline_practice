using Fighters.Models.Fighters;

namespace Fighters;

public class GameMaster
{
    public IFighter PlayAndGetWinner( IFighter firstFighter, IFighter secondFighter )
    {
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
        int damage = attacker.Damage;
        int defense = defender.Defense;

        defender.TakeDamage( damage, defense );

        Console.WriteLine(
            $"Fighter {defender.Name} takes {damage} damage. " +
            $"Current health: {defender.CurrentHealth}" );

        return defender.CurrentHealth < 1;
    }
}
