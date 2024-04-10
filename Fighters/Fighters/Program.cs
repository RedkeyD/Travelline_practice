using Fighters.Models.Fighters;
using Fighters.UI;

namespace Fighters;

public class Program
{
    public static void Main()
    {
        IFighterUserInterface fighterConsoleUI = new FighterConsoleUI();

        int numOfFighters = fighterConsoleUI.GetNumOfFightersInput( Messages.AskNumOfFighters );

        List<IFighter> fighters = fighterConsoleUI.CreateFighters( numOfFighters );

        fighterConsoleUI.DetailsOfFighters( fighters );

        Random random = new Random();

        GameMaster gameMaster = new GameMaster( random, fighterConsoleUI );
        gameMaster.PlayAndGetWinner( fighters );
    }
}