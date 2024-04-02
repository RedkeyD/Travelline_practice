namespace Fighters.Models.Races;

public class Demon : IRace
{
    public int Speed { get; } = 15;

    public int Damage { get; } = 40;

    public int Health { get; } = 150;

    public int Armor { get; } = 10;
}