namespace CarFactory.Models.Transmissions;

public class Automatic : ITransmission
{
    public int NumberOfGears { get; } = 8;
    public string Name { get; } = "Автоматическая";
}