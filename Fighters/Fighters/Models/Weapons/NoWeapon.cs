namespace Fighters.Models.Weapons;

public class NoWeapon : IWeapon
{
    public string Name { get; } = "No Weapon";
    public int Damage { get; } = 1;
    public int CriticalHitChance { get; } = 0;
}
