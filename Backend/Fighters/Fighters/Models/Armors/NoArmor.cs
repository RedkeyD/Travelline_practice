namespace Fighters.Models.Armors;

public class NoArmor : IArmor
{
    public string Name { get; } = "No Armor";
    public int Armor { get; } = 0;
}