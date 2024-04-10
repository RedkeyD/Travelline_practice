namespace Fighters.Models.Classes;

public class ClassFabric
{
    public IClass ChooseFighterClass( int fighterClass )
    {
        switch ( fighterClass )
        {
            case 1:
                return new Warrior();
            case 2:
                return new Knight();
            default:
                return new Warrior();
        }
    }
}