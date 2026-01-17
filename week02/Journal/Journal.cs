using System;
//this system helps in accessing files
using System.IO;

public class Journal
{//list to hold all entries
    public List<Entry> _entries = new List<Entry>();
    //method to add entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries to display.");
            return;
        }
          foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine(); // For spacing between entries
        }

    }

    private string CsvSafe(string value) //make sure that special characters are handled properly
    {
        value = value.Replace("\"", "\"\"");
        return $"\"{value}\"";
    }

    public void SaveToFile(string file)
    {
         using (StreamWriter writer = new StreamWriter(file))
        {
           // CSV header ( good for Excel)
        writer.WriteLine("Date,Prompt,Entry");

        foreach (Entry entry in _entries)
        {
            writer.WriteLine(
                $"{CsvSafe(entry._date)}," +
                $"{CsvSafe(entry._promptText)}," +
                $"{CsvSafe(entry._entryText)}"
            );
        }
        }
    }

   public void LoadFromFile(string file)
{
    _entries.Clear(); // Prevent duplicates

    string[] lines = File.ReadAllLines(file);

    // Skip header row (Date,Prompt,Entry)
    for (int i = 1; i < lines.Length; i++)
    {
        string line = lines[i];

        string[] parts = line.Split("\",\"");

        if (parts.Length == 3)
        {
            Entry entry = new Entry();
            entry._date = parts[0].Trim('"');
            entry._promptText = parts[1];
            entry._entryText = parts[2].Trim('"');

            _entries.Add(entry);
        }
    }
}
}