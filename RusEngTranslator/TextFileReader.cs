public class TextFileReader
{
    public string[] ReadDictionaryFile( string filePath )
    {
        if ( !File.Exists( filePath ) )
        {
            throw new FileNotFoundException( $"File not found: {filePath}" );
        }

        string[] lines = File.ReadAllLines( filePath );

        return lines;
    }
}