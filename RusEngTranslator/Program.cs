class Programm
{
    static void Main( string[] args )
    {
        string filePath = "WordsTranslations.txt";

        Translator translator = new Translator( filePath );
        translator.TakeDataFromTextFile();
        translator.FillRussianDictionary();
        translator.FillEnglishDictionary();

        TranslationLoop( translator );
    }

    static void TranslationLoop(Translator translator)
    {
        Console.WriteLine( "Enter a word to translate (Type exit to leave a program): " );

        string wordToTranslate = Console.ReadLine().Trim().ToLower();

        if ( wordToTranslate.Length == 0 )
        {
            Console.WriteLine( "Oops, seems like you forgot to enter word" );
            TranslationLoop( translator );
        }
        
        if ( wordToTranslate == "exit" )
        {
            Console.WriteLine( "Bye, have a good day" );
            return;
        }            

        string translatedWord = translator.TranslateWord( wordToTranslate );

        if ( translatedWord == null )
            Console.WriteLine( "Translations not found" );
        else
            Console.WriteLine( $"Tranlated word: { translatedWord}" );

        TranslationLoop( translator );
    }
}