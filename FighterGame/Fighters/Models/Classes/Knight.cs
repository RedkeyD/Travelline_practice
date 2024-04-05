namespace Fighters.Models.Classes;

public class Knight : IClass
{
    public string Name { get; } = "Knight";
    public int Health { get; } = 150;
    public int Damage { get; } = 20;
}