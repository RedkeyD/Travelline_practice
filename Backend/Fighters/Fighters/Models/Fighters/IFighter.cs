using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters.Models.Fighters;

public interface IFighter
{
    public int CurrentHealth { get; }
    public int Speed { get; }
    public int Damage { get; }
    public int Defense { get; }
    public string Name { get; }

    public IWeapon Weapon { get; }
    public IRace Race { get; }
    public IArmor Armor { get; }
    public IClass Class { get; }

    public void TakeDamage( int damage, int armor );
}