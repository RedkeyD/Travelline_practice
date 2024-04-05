using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters.Models.Fighters;

public class Fighter : IFighter
{
    public int MaxHealth => Race.Health + Class.Health;
    public int Damage => Race.Damage + Class.Damage + Weapon.Damage;
    public int Defense => Race.Armor;
    public int Speed => Race.Speed;

    public int CurrentHealth { get; private set; }


    public string Name { get; }

    public IArmor Armor { get; }
    public IWeapon Weapon { get; }
    public IRace Race { get; }
    public IClass Class { get; }

    public Fighter( string name, IArmor armor, IWeapon weapon, IRace race, IClass fighterClass )
    {
        Name = name;
        Armor = armor;
        Weapon = weapon;
        Race = race;
        Class = fighterClass;
        CurrentHealth = MaxHealth;
    }

    public override string ToString()
    {
        return $"Name: {Name}\n" +
               $"Max Health: {MaxHealth}\n" +
               $"Damage: {Damage}\n" +
               $"Defense: {Defense}\n" +
               $"Speed: {Speed}\n" +
               $"Armor: {Armor.Name}\n" +
               $"Weapon: {Weapon.Name}\n" +
               $"Race: {Race.Name}\n" +
               $"Class: {Class.Name}\n";
    }

    public void TakeDamage( int damage, int defense )
    {

        CurrentHealth -= damage - defense;

        if ( CurrentHealth < 0 )
        {
            CurrentHealth = 0;
        }
    }
}