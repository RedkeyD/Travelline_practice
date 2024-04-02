using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Models.Body;
using CarFactory.Models.Colours;
using CarFactory.Models.Engines;
using CarFactory.Models.Transmissions;
using CarFactory.Models.WheelPosition;

namespace CarFactory.Models.Cars;
public class Car : ICar
{
    public string Name { get; }
    public int Speed => Engine.Speed;
    public int NumberOfGears => Transmission.NumberOfGears;

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
        return $"Машина : {Name}\nКоробка передач : {Transmission.Name}\nКоличество передач : {NumberOfGears}\nДвигатель : {Engine.Name}\nКузов : {Body.Name}" +
                $"\nМаксимальная скорость : {Speed}\nЦвет : {Colour.Name}\nПозиция руля : {WheelPosition.Name}";
    }
}