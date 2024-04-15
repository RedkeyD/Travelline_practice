namespace Fighters.Models.Weapons;

public class Spear : IWeapon
{
    public string Name { get; } = "Spear";
    public int Damage { get; } = 25;
    public int CriticalHitChance { get; } = 25;
}