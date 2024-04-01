public class TextFileReader
{
    public void ReadFile( 
        string filePath,
        Dictionary<string, string> englishToRussianDictionary,
        Dictionary<string, string> russianToEnglishDictionary  )
    {
        try
        {
            if ( !File.Exists( filePath ) )
            {
                Console.WriteLine( "File not found." );
                throw new FileNotFoundException( $"File not found: {filePath}" );
            }

            string[] lines = File.ReadAllLines( filePath );

            PopulateDictionaries( lines, englishToRussianDictionary, russianToEnglishDictionary );

            Console.WriteLine( "Dictionaries were created, now you can use the program!" );
        }
        catch ( Exception ex )
        {
            Console.WriteLine( $"Error reading file: {ex.Message}" );
        }
    }

    private void PopulateDictionaries( 
        string[] lines, 
        Dictionary<string, string> englishToRussianDictionary, 
        Dictionary<string, string> russianToEnglishDictionary )
    {
        foreach ( string line in lines )
        {
            string[] words = line.Split( ':' );
            if ( words.Length == 2 )
            {
                string englishWord = words[ 0 ].Trim();
                string russianWord = words[ 1 ].Trim();

                englishToRussianDictionary[ englishWord ] = russianWord;
                russianToEnglishDictionary[ russianWord ] = englishWord;
            }
        }
    }
}