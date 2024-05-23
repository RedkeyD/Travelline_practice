namespace CarFactory.Models.Engines;

public class Diesel : IEngine
{
    public int Speed { get; } = 250;
    public string Name { get; } = "Дизельный";
}