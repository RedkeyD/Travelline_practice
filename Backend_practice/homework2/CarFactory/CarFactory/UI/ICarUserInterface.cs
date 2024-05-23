using CarFactory.Models.Body;
using CarFactory.Models.Colours;
using CarFactory.Models.Engines;
using CarFactory.Models.Transmissions;
using CarFactory.Models.WheelPosition;

namespace CarFactory.UI;

public interface ICarUserInterface
{
    string GetName();

    IBody GetBody();
    IColour GetColour();
    IEngine GetEngine();
    ITransmission GetTransmission();
    IWheelPosition GetWheelPosition();
}