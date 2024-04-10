namespace Fighters.Models.Weapons;

public class Axe : IWeapon
{
    public string Name { get; } = "Axe";
    public int Damage { get; } = 15;
    public int CriticalHitChance { get; } = 15;
}