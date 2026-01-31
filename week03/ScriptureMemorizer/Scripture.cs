using System;
using System.Collections.Generic;
using System.Linq;

// This class represents the scripture itself
// It contains a Reference and a list of Word objects
public class Scripture
{
    private Reference _reference;      // Scripture reference
    private List<Word> _words;         // List of words in the scripture
    private Random _random;            // Used for random hiding

    // Constructor
    // Takes a Reference and the scripture text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _random = new Random();

        // Split the text into words and convert each into a Word object
        _words = text
            .Split(' ')
            .Select(word => new Word(word))
            .ToList();
    }

    // Hides a given number of random words
    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    // Returns the full scripture text for display
    public string GetDisplayText()
    {
        string wordsText = string.Join(
            " ",
            _words.Select(word => word.GetDisplayText())
        );

        return $"{_reference.GetDisplayText()}\n{wordsText}";
    }

    // Checks if ALL words are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
