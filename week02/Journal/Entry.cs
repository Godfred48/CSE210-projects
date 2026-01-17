using System;

public class Entry
{
    PromptGenerator prompt1 = new PromptGenerator();
    public string _date;
    public string _promptText; 
    public string _entryText;
    public DateTime theCurrentTIme;

    //method capturing all user input
    public Entry()
    {

    }

    public void CreateNewEntry()
    {
        theCurrentTIme = DateTime.Now;
        _date = theCurrentTIme.ToShortDateString();

        _promptText = prompt1.GetRandomPrompt();
        Console.WriteLine($"Prompt: {_promptText}");

        Console.Write("Your entry: ");
        _entryText = Console.ReadLine();
    }

    //This display every thing user enters.
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}