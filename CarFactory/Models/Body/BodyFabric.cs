namespace CarFactory.Models.Body;

public class BodyFabric
{
    public IBody ChooseBody( string body )
    {
        switch ( body )
        {
            case "coupe": return new Coupe();
            case "minivan": return new Minivan();
            case "sedan": return new Sedan();
            default: return new Coupe();
        }
    }
}