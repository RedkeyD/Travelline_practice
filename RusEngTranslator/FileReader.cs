public class FileReader
{
    public void ReadFile( string filePath, Dictionary<string, string> englishToRussianDictionary, Dictionary<string, string> russianToEnglishDictionary )
    {
        try
        {
            CheckIfFileExists( filePath );

            string[] lines = File.ReadAllLines( filePath );

            PopulateDictionaries( lines, englishToRussianDictionary, russianToEnglishDictionary );

            Console.WriteLine( "Dictionaries were created, now you can use the program!" );
        }
        catch ( Exception ex )
        {
            Console.WriteLine( $"Error reading file: {ex.Message}" );
        }
    }

    private void CheckIfFileExists( string filePath )
    {
        if ( !File.Exists( filePath ) )
        {
            Console.WriteLine( "File not found." );
            throw new FileNotFoundException( $"File not found: {filePath}" );
        }
    }

    private void PopulateDictionaries( string[] lines, Dictionary<string, string> englishToRussianDictionary, Dictionary<string, string> russianToEnglishDictionary )
    {
        foreach ( string line in lines )
        {
            string[] parts = line.Split( ':' );
            if ( parts.Length == 2 )
            {
                string englishWord = parts[ 0 ].Trim();
                string russianWord = parts[ 1 ].Trim();

                englishToRussianDictionary[ englishWord ] = russianWord;
                russianToEnglishDictionary[ russianWord ] = englishWord;
            }
        }
    }
}

