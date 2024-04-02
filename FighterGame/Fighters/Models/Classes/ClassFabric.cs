using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Classes;
public class ClassFabric
{
    public IClass ChooseFighterClass( string fighterClass )
    {
         switch ( fighterClass )
        {
            case "warrior":
                return new Warrior();

            case "knight":
                return new Knight();

            default:
                return new Warrior();
}
    }
}