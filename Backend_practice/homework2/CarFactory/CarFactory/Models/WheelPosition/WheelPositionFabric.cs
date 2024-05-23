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