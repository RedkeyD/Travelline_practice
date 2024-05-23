namespace Fighters.Models.Weapons;

public class WeaponFabric
{
    public IWeapon ChooseWeapon( int weapon )
    {
        switch ( weapon )
        {
            case 1:
                return new Sword();
            case 2:
                return new Spear();
            case 3:
                return new Axe();
            default:
                return new NoWeapon();
        }
    }
}