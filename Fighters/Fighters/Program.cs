using Fighters.Models.Fighters;
using Fighters.UI;

namespace Fighters;

public class Program
{
    public static void Main()
    {
        IFighterUserInterface fighterConsoleUI = new FighterConsoleUI();

        int numOfFighters = fighterConsoleUI.IntInput( Messages.AskNumOfFighters );

        List<IFighter> fighters = fighterConsoleUI.CreateFighters( numOfFighters );

        fighterConsoleUI.DetailsOfFighters( fighters );

        GameMaster gameMaster = new GameMaster( fighterConsoleUI );
        gameMaster.PlayAndGetWinner( fighters );
    }
}