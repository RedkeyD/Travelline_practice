using Fighters.Models.Fighters;

namespace Fighters;

public class Program
{
    public static void Main()
    {
        FighterConsoleUI fighterConsoleUI = new FighterConsoleUI();

        int numOfFighters = fighterConsoleUI.GetNumInput( Messages.AskNumOfFighters );

        List<IFighter> fighters = fighterConsoleUI.CreateFighters( numOfFighters );

        fighterConsoleUI.DetailsOfFighters( fighters );

        GameMaster gameMaster = new GameMaster();
        gameMaster.PlayAndGetWinner( fighters );
    }
}