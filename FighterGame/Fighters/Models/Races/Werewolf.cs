namespace Fighters.Models.Races;

public class Werewolf : IRace
{
    public int Speed { get; } = 12;

    public int Damage { get; } = 20;

    public int Health { get; } = 150;

    public int Armor { get; } = 15;
}