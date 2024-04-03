namespace Fighters.Models.Classes;

public class ClassFabric
{
    public IClass ChooseFighterClass( string fighterClass )
    {
        switch ( fighterClass )
        {
            case "warrior":
                return new Warrior();
            case "knight":
                return new Knight();
            default:
                return new Warrior();
        }
    }
}