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

    static void TranslationLoop( Translator translator )
    {
        Console.WriteLine( "Enter a word to translate (Type exit to leave a program): " );

        string wordToTranslate = Console.ReadLine().Trim().ToLower();

        if ( wordToTranslate.Length == 0 )
        {
            Console.WriteLine( "Oops, seems like you forgot to enter word. Don't worry, we will not punish you for it, just don't make this mistake again :)" );
            TranslationLoop( translator );
        }
        
        if ( wordToTranslate == "exit" )
        {
            Console.WriteLine( "Bye, have a good day" );
            return;
        }            

        string translatedWord = translator.TranslateWord( wordToTranslate );

        Console.WriteLine( $"Tranlated word: { translatedWord}" );

        TranslationLoop( translator );
    }
}