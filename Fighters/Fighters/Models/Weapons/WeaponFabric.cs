namespace Fighters.Models.Weapons;

public class WeaponFabric
{
    public IWeapon ChooseWeapon( string Weapon )
    {
        switch ( Weapon )
        {
            case "sword":
                return new Sword();
            case "axe":
                return new Axe();
            case "spear":
                return new Spear();
            default:
                return new NoWeapon();
        }
    }
}