namespace CarFactory.Models.Engines;

public class Gasoline : IEngine
{
    public int Speed { get; } = 190;
    public string Name { get; } = "Бензиновый";
}