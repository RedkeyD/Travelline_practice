public class Translator
{
    private Dictionary<string, string> englishToRussianDictionary;
    private Dictionary<string, string> russianToEnglishDictionary;

    // Constructor to initialize dictionaries
    public Translator( Dictionary<string, string> engToRusDict, Dictionary<string, string> rusToEngDict )
    {
        englishToRussianDictionary = engToRusDict;
        russianToEnglishDictionary = rusToEngDict;
    }

    public string TranslateToRussian( string word )
    {
        if ( englishToRussianDictionary.ContainsKey( word ) )
        {
            return englishToRussianDictionary[ word ];
        }
        else
        {
            return "Translation not found";
        }
    }

    public string TranslateToEnglish( string word )
    {
        if ( russianToEnglishDictionary.ContainsKey( word ) )
        {
            return russianToEnglishDictionary[ word ];
        }
        else
        {
            return "Translation not found";
        }
    }
}

