using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
          // Create Journal instance
        Console.WriteLine("Welcome to Journally!!!!");
        int option;

        do
        {
            Console.WriteLine("\nPlease select an option below:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            
            string number = Console.ReadLine();
            option = int.Parse(number);

            if (option == 1)
            {
                Entry newEntry = new Entry();
                newEntry.CreateNewEntry();
                journal.AddEntry(newEntry);   // Add it to the journal
            }
            else if (option == 2)
            {
                journal.DisplayAll();
            }
            else if (option == 3)
            {
                Console.Write("Enter filename (must be .csv) to load: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
                Console.WriteLine("Journal loaded successfully. To view content of loaded file press 2.");
            }
            else if (option == 4)
            {
                Console.Write("Enter filename (must be .csv) to save: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
                Console.WriteLine("Journal saved successfully.");
            }

        } while (option != 5);

        Console.WriteLine("Goodbye!");
    }
}