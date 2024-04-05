namespace CarFactory.Models.Transmissions;

public interface ITransmission
{
    public int NumberOfGears { get; }
    public string Name { get; } 
}