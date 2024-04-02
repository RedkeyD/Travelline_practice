using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Models.Colours;
using CarFactory.Models.Transmissions;

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