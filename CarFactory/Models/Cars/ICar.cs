using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Models.Colours;
using CarFactory.Models.Engines;
using CarFactory.Models.Transmissions;
using CarFactory.Models.WheelPosition;

namespace CarFactory.Models.Cars;
public interface ICar
{
    public string Name { get; }
    public int Speed { get; }
    public int NumberOfGears { get; }

    public IColour Colour { get; }
    public IWheelPosition WheelPosition { get; }
    public IEngine Engine { get; } 
    public ITransmission Transmission { get; }

}