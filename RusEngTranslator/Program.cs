class Programm
{
    static void Main( string[] args )
    {
        FileReader fileReader = new FileReader();
        Dictionary<string, string> englishToRussianDictionary = new Dictionary<string, string>();
        Dictionary<string, string> russianToEnglishDictionary = new Dictionary<string, string>();

        string filePath = "WordsTranslations.txt";
        string errorMessage;

        bool exit = false;

        fileReader.ReadFile( filePath, englishToRussianDictionary, russianToEnglishDictionary );

        InputValidator inputValidator = new InputValidator( englishToRussianDictionary, russianToEnglishDictionary );

        while ( !exit )
        {
            Console.WriteLine( "Enter a word to translate (Type exit to leave a program): " );

            string wordToTranslate = Console.ReadLine().Trim().ToLower();


            if ( wordToTranslate == "exit" )
            {
                Console.WriteLine( "Bye, have a good day" );

                exit =  true; 
            }
            else
            {
                if ( inputValidator.ValidateInput( wordToTranslate, out errorMessage ) )
                {
                    TranslateWord( wordToTranslate, englishToRussianDictionary, russianToEnglishDictionary );
                }
                else
                {
                    Console.WriteLine( errorMessage ); // Handle input errors
                }
            }
        }
    }


    static void TranslateWord( string wordToTranslate, Dictionary<string, string> englishToRussianDictionary, Dictionary<string, string> russianToEnglishDictionary )
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
}
    


