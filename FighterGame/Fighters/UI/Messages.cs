namespace Fighters;

public class Messages
{
    public string CreateFighterNameMessage { get; } = "Enter your fighter name, Milord: ";
    public string ChooseFighterRaceMessage { get; } = "Enter your fighter race, Milord: ";
    public string ChooseFighterWeaponMessage { get; } = "\nEnter your fighter quality of weapon, Milord: ";
    public string ChooseFighterArmorMessage { get; } = "\nEnter your fighter quality of armor, Milord: ";
    public string AvailableRacesMessage { get; } = "\nNow choose fighter race Milord. \nCurrently available races: \n1.Human \n2.Angel \n3.Demon \n4.Dwarf \n5.Werewolf \n6.Vampire ";
    public string AvailableWeaponsQualityMessage { get; } = "\nNow choose fighter weapon Milord. \nCurrently available qualites for weapoms: \n1.Low \n2.Average \n3.High";
    public string AvailableArmorsQualityMessage { get; } = "\nNow choose fighter armor Milord. \nCurrently available qualites for armors: \n1.Low \n2.Average \n3.High";
    public string NullOrEmptyNameErrorMessage { get; } = "Milord, your forgot to name your fighter.";
    public string NullOrEmptyWeaponErrorMessage { get; } = "Milord, your forgot to choose a weapon for your fighter.";
    public string NullOrEmptyArmorErrorMessage { get; } = "Milord, your forgot to choose an armor for your fighter.";
    public string NullOrEmptyRaceErrorMessage { get; } = "Milord, your forgot to choose a race for your fighter.";
    public string FighterCreatedMessage { get; } = "Your fighter was created Milord! Now we can create another fighter, it's opponent!";
    public string StartFightMessage { get; } = "Now they can fight Milord!";

}
