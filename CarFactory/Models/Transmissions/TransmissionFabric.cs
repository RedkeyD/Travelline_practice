using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Models.Colours;

namespace CarFactory.Models.Transmissions;
public class TransmissionFabric
{
    public ITransmission ChooseTransmission( string transmission )
    {
        switch ( transmission )
        {
            case "manual":
                return new Manual();
            case "automatic":
                return new Automatic();
            case "semiautomatic":
                return new SemiAutomatic();
            default:
                return new Manual();
        }
    }
}