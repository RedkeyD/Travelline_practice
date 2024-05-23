using CarFactory.Models.Colours;
using CarFactory.Models.Engines;
using CarFactory.Models.Transmissions;
using CarFactory.Models.WheelPosition;

namespace CarFactory.Models.Cars;

public interface ICar
{
    public string Name { get; }

    public IColour Colour { get; }
    public IWheelPosition WheelPosition { get; }
    public IEngine Engine { get; } 
    public ITransmission Transmission { get; }
}