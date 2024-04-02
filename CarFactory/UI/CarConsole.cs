using CarFactory.Models.Body;
using CarFactory.Models.Colours;
using CarFactory.Models.Engines;
using CarFactory.Models.Transmissions;
using CarFactory.Models.WheelPosition;

namespace CarFactory.UI;
public class CarConsole : IUserInterface
{
    public BodyFabric BodyFabric { get; private set; }
    public ColourFabric ColourFabric { get; private set; }
    public EngineFabric EngineFabric { get; private set; }
    public TransmissionFabric TransmissionFabric { get; private set; }
    public WheelPositionFabric WheelPositionFabric { get; private set; }

    public CarConsole()
    {

        BodyFabric = new BodyFabric();
        ColourFabric = new ColourFabric();
        EngineFabric = new EngineFabric();
        TransmissionFabric = new TransmissionFabric();
        WheelPositionFabric = new WheelPositionFabric();
    }

    public string GetName()
    {
        string promptCarName = "Enter car name: ";
        string carName = GetInput(promptCarName);

        return carName;
    }

    public IBody GetBody()
    {
        string promptCarBody = "Currently we have these body types: \n1.Coupe \n2.Minivan \n3.Sedan \n\nEnter the type you like from these body types: ";
        string carBodyStr = GetInput(promptCarBody);

        return BodyFabric.ChooseBody(carBodyStr);
    }

    public IColour GetColour()
    {
        string promptCarColour = "Currently we have these colours: \n1.Blue \n2.Black \n3.Red \n\n Enter the colour you like from these colours: ";
        string carColourStr = GetInput(promptCarColour);

        return ColourFabric.ChooseColour(carColourStr);
    }

    public IEngine GetEngine()
    {
        string promptCarEngine = "Currently we have these engines: \n1.Diesel \n2.Gasoline \n3.ElectricMotor \n\n Enter the engine you like from these engines: ";
        string carEngineStr = GetInput(promptCarEngine);

        return EngineFabric.ChooseEngine(carEngineStr);
    }

    public ITransmission GetTransmission()
    {
        string promptCarTransmission = "Currently we have these transmissions: \n1.Manual \n2.Automatic \n3.Semiautomatic \n\nEnter the transmission you like from these transmissions: ";
        string carTransmissionStr = GetInput(promptCarTransmission);

        return TransmissionFabric.ChooseTransmission(carTransmissionStr);
    }

    public IWheelPosition GetWheelPosition()
    {
        string promptCarWheelPosition = "Currently we have these wheel positions: \n1.Left \n2.Right \n\nEnter the wheel position you like from these positions: ";
        string carWheelPositionStr = GetInput(promptCarWheelPosition);

        return WheelPositionFabric.ChooseWheelPosition(carWheelPositionStr);
    }

    public string GetInput(string promptMessage)
    {
        Console.WriteLine(promptMessage);
        string input = Console.ReadLine();

        while (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Error: Input cannot be empty. Please enter a valid value.");
            input = Console.ReadLine();
        }

        Console.Clear();
        return input.ToLower();
    }
}