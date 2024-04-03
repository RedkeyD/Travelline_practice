namespace Fighters.Models.Weapons;

public class WeaponFabric
{
    public IWeapon ChooseWeapon( string Weapon )
    {
        switch ( Weapon )
        {
            case "sword": return new Sword();

            case "Axe": return new Axe();

            case "Spear": return new Spear();

            default: return new NoWeapon();
        }
    }
}