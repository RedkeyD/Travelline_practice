using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Weapons;
public class WeaponFabric
{
    public IWeapon ChooseQualityOfWeapon( string qualityOfWeapon )
    {
        switch ( qualityOfWeapon )
        {
            case "low":
                return new LowQualityWeapon();

            case "average":
                return new AverageQualityWeapon();

            case "high":
                return new HighQualityWeapon();

            default:
                return new LowQualityWeapon();
        }
    }
}
