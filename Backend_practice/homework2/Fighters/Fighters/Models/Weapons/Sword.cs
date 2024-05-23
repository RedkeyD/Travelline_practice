namespace Fighters.Models.Weapons;

public class Sword : IWeapon
{
    public string Name { get; } = "Sword";
    public int Damage { get; } = 20;
    public int CriticalHitChance { get; } = 20;
}