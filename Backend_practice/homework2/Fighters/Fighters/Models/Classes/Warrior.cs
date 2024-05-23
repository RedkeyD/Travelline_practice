namespace Fighters.Models.Classes;

public class Warrior : IClass
{
    public string Name { get; } = "Warrior";
    public int Health { get; } = 100;
    public int Damage { get; } = 30;
}