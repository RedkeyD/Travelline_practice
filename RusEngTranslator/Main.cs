FileReader fileReader = new FileReader();

// Dicitionaries
Dictionary<string, string> englishToRussianDictionary = new Dictionary<string, string>();
Dictionary<string, string> russianToEnglishDictionary = new Dictionary<string, string>();

// File path
string filePath = "WordsTranslations.txt";

//Prompts
string errorMessage;
string translationMessage = "Enter a word to translate (Type exit to leave a program): ";
string exitMessage = "exit";
string farewellWords = "Bye, have a good day";

//exit loop
bool exit = false;

// Initialize dictionaries
fileReader.ReadFile( filePath, englishToRussianDictionary, russianToEnglishDictionary );

<<<<<<< HEAD
//check dictionaries for input errors
=======
//check dictionaries for errors
>>>>>>> 969d71d90b5482da3df10b4c0e9e08daaf6284d9
InputValidator inputValidator = new InputValidator( englishToRussianDictionary, russianToEnglishDictionary );

TranslationLoop( translationMessage, exitMessage, farewellWords, englishToRussianDictionary, russianToEnglishDictionary );

static void TranslationLoop( string translationMessage, string exitMessage, string farewellWords, Dictionary<string, string> englishToRussianDictionary, Dictionary<string, string> russianToEnglishDictionary )
{
    InputValidator inputValidator = new InputValidator( englishToRussianDictionary, russianToEnglishDictionary );
    bool exit = false;

    while ( !exit )
    {
        Console.WriteLine( translationMessage );
        string wordToTranslate = Console.ReadLine().Trim().ToLower();

        exit = HandleExit( wordToTranslate, exitMessage, farewellWords );

        if ( !exit )
            TranslateWord( wordToTranslate, englishToRussianDictionary, russianToEnglishDictionary, inputValidator );
    }
}

static bool HandleExit( string userInput, string exitMessage, string farewellWords )
{
    if ( userInput == exitMessage )
    {
        Console.WriteLine( farewellWords );
        return true; // Exit loop
    }
    return false; // Continue loop
}

static void TranslateWord( string wordToTranslate, Dictionary<string, string> englishToRussianDictionary, Dictionary<string, string> russianToEnglishDictionary, InputValidator inputValidator )
{
    string errorMessage;
    if ( inputValidator.ValidateInput( wordToTranslate, out errorMessage ) )
    {
        PerformTranslation( wordToTranslate, englishToRussianDictionary, russianToEnglishDictionary );
    }
    else
    {
        Console.WriteLine( errorMessage ); // Handle input errors
    }
}

static void PerformTranslation( string wordToTranslate, Dictionary<string, string> englishToRussianDictionary, Dictionary<string, string> russianToEnglishDictionary )
{
    if ( englishToRussianDictionary.ContainsKey( wordToTranslate ) )
    {
        string russianTranslation = englishToRussianDictionary[ wordToTranslate ];
        Console.WriteLine( $"{wordToTranslate} in Russian is {russianTranslation}" );
    }
    else if ( russianToEnglishDictionary.ContainsKey( wordToTranslate ) )
    {
        string englishTranslation = russianToEnglishDictionary[ wordToTranslate ];
        Console.WriteLine( $"{wordToTranslate} на английском это {englishTranslation}" );
    }
    else
    {
        Console.WriteLine( $"Translation not found for '{wordToTranslate}'" );
    }
}


