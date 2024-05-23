namespace Fighters.Models.Races;

public class RaceFabric
{
    public IRace ChooseRace( int race )
    {
        switch ( race )
        {
            case 1:
                return new Human();
            case 2:
                return new Werewolf();
            case 3:
                return new Vampire();
            default:
                return new Human();
        }
    }
}