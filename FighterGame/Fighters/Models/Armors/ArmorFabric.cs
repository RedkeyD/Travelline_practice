namespace Fighters.Models.Armors;

public class ArmorFabric
{
    public IArmor ChooseArmor( string Armor )
    {
        switch ( Armor )
        {
            case "helmet":
                return new Helmet();
            case "breastplate":
                return new Breastplate();
            case "gauntlets":
                return new Gauntlets();
            default:
                return new NoArmor();
        }
    }
}