using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Models.Colours;
public class ColourFabric
{
    public IColour ChooseColour(string colour)
    {
        switch (colour)
        {
            case "red": return new Red();
            case "black": return new Black();
            case "blue": return new Blue();
            default: return new Red();
        }
    }
}