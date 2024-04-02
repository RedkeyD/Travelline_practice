namespace CarFactory.Models.Engines;

public class BatteryElectricMotor : IEngine
{
    public int Speed { get; } = 320;
    public string Name { get; } = "Аккумуляторный электромотор";
}