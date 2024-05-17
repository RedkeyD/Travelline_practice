namespace CarFactory.Models.Transmissions;

public class SemiAutomatic : ITransmission
{
    public int NumberOfGears { get; } = 6;
    public string Name { get; } = "Полуавтоматическая";
}