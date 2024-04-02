using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters.Models.Fighters;

public class Fighter : IFighter
{
    public int MaxHealth => Race.Health + Class.Health;
    public int CurrentHealth { get; private set; }
    public int Speed => Race.Speed;

    public string Name { get; }

    public IRace Race { get; }
    public IWeapon Weapon { get; } 
    public IArmor Armor { get; } 
    public IClass Class { get; }

    public Fighter( string name, IRace race, IWeapon weapon, IArmor armor, IClass fighterClass)
    {
        Name = name;
        Race = race;
        Weapon = weapon;
        Armor = armor;
        Class = fighterClass;
        CurrentHealth = MaxHealth;
    }

    public int CalculateDamage()
    {
        return Race.Damage + Weapon.Damage + Class.Damage;
    }

    public void TakeDamage( int damage )
    {
        CurrentHealth -= damage;

        if ( CurrentHealth < 0 )
        {
            CurrentHealth = 0;
        }
    }
}