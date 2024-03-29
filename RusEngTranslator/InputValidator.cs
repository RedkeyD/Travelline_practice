public class InputValidator
{
    private Dictionary<string, string> englishToRussianDictionary;
    private Dictionary<string, string> russianToEnglishDictionary;

    public InputValidator( Dictionary<string, string> engToRusDict, Dictionary<string, string> rusToEngDict )
    {
        englishToRussianDictionary = engToRusDict;
        russianToEnglishDictionary = rusToEngDict;
    }

    public bool ValidateInput( string userInput, out string errorMessage )
    {
        errorMessage = "";

        if ( string.IsNullOrWhiteSpace( userInput ) )
        {
            errorMessage = "Input cannot be empty or whitespace.";
            return false;
        }

        if ( !englishToRussianDictionary.ContainsKey( userInput ) && !russianToEnglishDictionary.ContainsKey( userInput ) )
        {
            errorMessage = $"Word {userInput} not found in dictionaries.";
            return false;
        }

        return true;
    }
}

