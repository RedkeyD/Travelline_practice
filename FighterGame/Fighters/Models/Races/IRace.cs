namespace Fighters.Models.Races;

public interface IRace
{
    int Speed { get; }
    int Damage { get; }
    int Health { get; }
    int Armor { get; }
}