using Fighters.Models.Fighters;

namespace Fighters.UI;

public interface IFighterUserInterface
{
    public List<IFighter> CreateFighters( int numFighters );
    public IFighter CreateFighter();
    public void DetailsOfFighters( List<IFighter> fighters );
    public void Print(string promptMessage );
    public string Input(string promptMessage );
    public int IntInput( string promptMessage );
}