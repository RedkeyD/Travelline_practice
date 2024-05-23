namespace Fighters.Models.Classes;

public interface IClass
{
    public string Name { get; }
    int Health { get; }
    int Damage { get; }
}