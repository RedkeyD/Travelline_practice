using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters.UI;

public interface IFighterUserUnterface
{
    string GetName();

    IArmor GetArmor();
    IWeapon GetWeapon();
    IRace GetRace();
    IClass GetClass();
}