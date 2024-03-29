namespace Fighters.Models.Races;

public class Vampire : IRace
{
    public int Speed { get; } = 15;

    public int Damage { get; } = 25;

    public int Health { get; } = 120;

    public int Armor { get; } = 12;
}
