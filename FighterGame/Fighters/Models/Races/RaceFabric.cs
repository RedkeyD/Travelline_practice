using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Races;
public class RaceFabric
{
    public IRace ChooseRace( string race )
    {
        switch ( race )
        {
            case "human":
                return new Human();

            case "dwarf":
                return new Dwarf();

            case "angel":
                return new Angel();

            case "demon":
                return new Demon();

            case "werewolf":
                return new Werewolf();

            case "vampire":
                return new Vampire();

            default:
                return new Human();
        }
    }
}
