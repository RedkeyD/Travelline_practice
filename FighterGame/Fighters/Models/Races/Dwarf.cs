namespace Fighters.Models.Races;

public class Dwarf : IRace
{
    public int Speed { get; } = 5;

    public int Damage { get; } = 30;

    public int Health { get; } = 170;

    public int Armor { get; } = 15;
}
