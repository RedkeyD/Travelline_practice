using CarFactory;
using CarFactory.Models.Body;
using CarFactory.Models.Cars;
using CarFactory.Models.Colours;
using CarFactory.Models.Engines;
using CarFactory.Models.Transmissions;
using CarFactory.Models.WheelPosition;
using CarFactory.UI;

class Program
{
    static void Main( string[] args )
    {
        CarConsoleUI carConsole = new CarConsoleUI();

        string carName = carConsole.GetName();
        IColour carColour = carConsole.GetColour();
        IWheelPosition wheelPosition = carConsole.GetWheelPosition();
        IEngine carEngine = carConsole.GetEngine();
        ITransmission carTransmission = carConsole.GetTransmission();
        IBody carBody = carConsole.GetBody();

        FactoryOfCar carFactory = new FactoryOfCar();
        ICar car = carFactory.CreateCar( carName, carColour, wheelPosition, carEngine, carTransmission, carBody );

        Console.WriteLine( car.ToString() );
    }
}