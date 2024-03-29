using Fighters.Models.Fighters;
using System.Diagnostics;

namespace Fighters;

public class GameMaster
{
    public IFighter PlayAndGetWinner( IFighter firstFighter, IFighter secondFighter )
    {
        int round = 1;
        while ( true )
        {
            Console.WriteLine( $"Раунд {round++}." );

            // First fights second
            if ( FightAndCheckIfOpponentDead( firstFighter, secondFighter ) )
            {
                return firstFighter;
            }

            // Second fights first
            if ( FightAndCheckIfOpponentDead( secondFighter, firstFighter ) )
            {
                return secondFighter;
            }

            Console.WriteLine();
        }

        throw new UnreachableException();
    }

    private bool FightAndCheckIfOpponentDead( IFighter roundOwner, IFighter opponent )
    {
        int damage = roundOwner.CalculateDamage();
        opponent.TakeDamage(damage);

        Console.WriteLine(
            $"Боец {opponent.Name} получает {damage} урона. " +
            $"Количество жизней: {opponent.CurrentHealth}" );

        return opponent.CurrentHealth < 1;
    }
}