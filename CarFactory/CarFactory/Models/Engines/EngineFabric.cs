namespace CarFactory.Models.Engines;

public class EngineFabric
{
    public IEngine ChooseEngine( string engine )
    {
        switch ( engine )
        {
            case "gasoline": return new Gasoline();
            case "diesel": return new Diesel();
            case "electricmotor": return new BatteryElectricMotor();
            default: return new Gasoline();
        }
    }
}