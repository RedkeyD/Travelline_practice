using CarFactory.Models.Body;
using CarFactory.Models.Cars;
using CarFactory.Models.Colours;
using CarFactory.Models.Engines;
using CarFactory.Models.Transmissions;
using CarFactory.Models.WheelPosition;

namespace CarFactory;

public class FactoryOfCar
{
    public ICar CreateCar(
        string name,
        IColour colour,
        IWheelPosition wheelPosition,
        IEngine engine,
        ITransmission transmission,
        IBody body
        )
    {
        return new Car(name, colour, wheelPosition, engine, transmission, body);
    }
}