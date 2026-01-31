using System;
using System.IO;

class Program
{
    static void Main()
    {
        /*
         * EXCEEDING REQUIREMENTS:
         * 1. Scripture text is loaded from an external file (scripture.txt)
         * 2. Program hides multiple words at a time
         * 3. Program automatically ends when all words are hidden
         */

        // Create the scripture reference (1 John 2:15–16)
        Reference reference = new Reference("1 John", 2, 15, 16);

        // Read the scripture text from a file
        // This allows easy changes without modifying code
        string scriptureText = File.ReadAllText("scripture.txt");

        // Create the Scripture object
        Scripture scripture = new Scripture(reference, scriptureText);

        // Main program loop
        while (true)
        {
            // Clear the console for a clean display
            Console.Clear();

            // Display the scripture
            Console.WriteLine(scripture.GetDisplayText());

            // Prompt the user
            Console.WriteLine("\nPress ENTER to continue or type 'quit' to exit.");

            string input = Console.ReadLine();

            // If user types quit, exit program
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide a few random words
            scripture.HideRandomWords(3);

            // If all words are hidden, show final state and exit
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}
