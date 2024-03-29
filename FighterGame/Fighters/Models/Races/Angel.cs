namespace Fighters.Models.Races;

public class Angel : IRace
{
    public int Speed { get; } = 20;

    public int Damage { get; } = 35;

    public int Health { get; } = 200;

    public int Armor { get; } = 30;
}