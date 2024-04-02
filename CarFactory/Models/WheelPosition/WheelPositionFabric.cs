using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Models.Colours;

namespace CarFactory.Models.WheelPosition;
public class WheelPositionFabric
{
    public IWheelPosition ChooseWheelPosition( string wheelposition )
    {
        switch ( wheelposition )
        {
            case "left": return new LeftWheel();
            case "right": return new RightWheel();
            default: return new RightWheel();
        }
    }
}