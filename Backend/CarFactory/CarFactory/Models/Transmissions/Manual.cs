namespace CarFactory.Models.Transmissions;

public class Manual : ITransmission
{
    public int NumberOfGears { get; } = 4;
    public string Name { get; } = "Механическая";
}