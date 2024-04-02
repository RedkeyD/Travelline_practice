using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Armors;
public class ArmorFabric
{
    public IArmor ChooseQualityOfArmor( string qualityOfArmor )
    {
        switch ( qualityOfArmor )
        {
            case "low":
                return new LowQualityArmor();

            case "average":
                return new AverageQualityArmor();

            case "high":
                return new HighQualityArmor();

            default:
                return new LowQualityArmor();
        }
    }
}
