using CarFactory.Models.Body;
using CarFactory.Models.Colours;
using CarFactory.Models.Engines;
using CarFactory.Models.Transmissions;
using CarFactory.Models.WheelPosition;

namespace CarFactory.Models.Cars;

public class Car : ICar
{
    public string Name { get; }
    private int speed => Engine.Speed;
    private int numberOfGears => Transmission.NumberOfGears;

    public IColour Colour { get; }
    public IWheelPosition WheelPosition { get; }
    public IEngine Engine { get; }
    public ITransmission Transmission { get; }
    public IBody Body { get; }

    public Car(
        string name,
        IColour colour,
        IWheelPosition wheelPosition,
        IEngine engine,
        ITransmission transmission,
        IBody body)
    {
        Name = name;
        Colour = colour;
        WheelPosition = wheelPosition;
        Engine = engine;
        Transmission = transmission;
        Body = body;
    }

    public override string ToString()
    {
        return $"Машина: {Name}\nКоробка передач: {Transmission.Name}\nКоличество передач: {numberOfGears}\nДвигатель: {Engine.Name}\nКузов: {Body.Name}" +
                $"\nМаксимальная скорость: {speed}\nЦвет: {Colour.Name}\nПозиция руля: {WheelPosition.Name}";
    }
}