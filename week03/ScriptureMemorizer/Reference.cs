// This class represents a scripture reference such as:
// "1 John 2:15" or "1 John 2:15-16"
public class Reference
{
    // Private fields (encapsulation)
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor for a SINGLE verse (e.g., 1 John 2:15)
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    // Constructor for a VERSE RANGE (e.g., 1 John 2:15-16)
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Returns the reference as a formatted string
    public string GetDisplayText()
    {
        // If start and end verse are the same, show a single verse
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        // Otherwise, show a verse range
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
