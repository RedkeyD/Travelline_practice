public class Translator
{
    private Dictionary<string, string> _englishToRussianDictionary = new Dictionary<string, string>();
    private Dictionary<string, string> _russianToEnglishDictionary = new Dictionary<string, string>();
    private TextFileReader _textFileReader = new TextFileReader();
    private string[] _lines = null;
    private string _filePath = null;

    public Translator(string filePath) 
    {
        _filePath = filePath;
    }

    public void TakeDataFromTextFile()
    {
        try
        { 
            _lines = _textFileReader.ReadDictionaryFile( _filePath ); 
        }
        catch(FileNotFoundException)
        {
            _lines = null;
        }
         
    }
    public void FillEnglishDictionary()
    {
        foreach ( string line in _lines )
        {
            string[] words = line.Split( ':' );
            if ( words.Length == 2 )
            {
                string englishWord = words[ 0 ].Trim();
                string russianWord = words[ 1 ].Trim();

                _englishToRussianDictionary[ englishWord ] = russianWord;
            }
        }
    }

    public void FillRussianDictionary()
    {
        foreach ( string line in _lines )    
        {
            string[] words = line.Split( ':' );
            if ( words.Length == 2 )
            {
                string englishWord = words[ 0 ].Trim();
                string russianWord = words[ 1 ].Trim();

                _russianToEnglishDictionary[ russianWord ] = englishWord;
            }
        }
    }

    public string TranslateWord( string wordToTranslate )
    {
        string translatedWord = null;

        if ( _englishToRussianDictionary.ContainsKey( wordToTranslate ) )
        {
            translatedWord = _englishToRussianDictionary[ wordToTranslate ];
        }

        if ( _russianToEnglishDictionary.ContainsKey( wordToTranslate ) )
        {
            translatedWord = _russianToEnglishDictionary[ wordToTranslate ];
        }

        return translatedWord;
    }
}