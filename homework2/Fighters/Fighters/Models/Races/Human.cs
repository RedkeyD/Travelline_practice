namespace Fighters.Models.Races;

public class Human : IRace
{
    public string Name { get; } = "Human";
    public int Speed { get; } = 9;
    public int Damage { get; } = 11;
    public int Health { get; } = 100;
    public int Armor { get; } = 9;
}