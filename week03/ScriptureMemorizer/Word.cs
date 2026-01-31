// This class represents a SINGLE word in the scripture
// It knows whether it is hidden or visible
public class Word
{
    private string _text;     // The actual word text
    private bool _isHidden;   // Whether the word is hidden

    // Constructor: creates a visible word
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hides the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Shows the word again (not required, but good design)
    public void Show()
    {
        _isHidden = false;
    }

    // Returns whether the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Returns what should be displayed on the screen
    public string GetDisplayText()
    {
        // If hidden, replace letters with underscores
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }

        // Otherwise, show the word
        return _text;
    }
}
