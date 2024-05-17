namespace Fighters.Models.Armors;

public class ArmorFabric
{
    public IArmor ChooseArmor( int armor )
    {
        switch ( armor )
        {
            case 1:
                return new Helmet();
            case 2:
                return new Gauntlets();
            case 3:
                return new Breastplate();
            default:
                return new NoArmor();
        }
    }
}