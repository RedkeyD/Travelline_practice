namespace Fighters.Models.Races;

public class RaceFabric
{
    public IRace ChooseRace( string race )
    {
        switch ( race )
        {
            case "human":
                return new Human();
            case "werewolf":
                return new Werewolf();
            case "vampire":
                return new Vampire();
            default:
                return new Human();
        }
    }
}