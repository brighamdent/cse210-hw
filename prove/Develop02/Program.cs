// I implemented functionality to save journal entries in JSON format using the Newtonsoft.Json library.
using System;

public class Program
{
    private static Journal journal = new Journal();

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    private static void WriteNewEntry()
    {
        Console.WriteLine("You will be prompted with a question. Please respond:");
        var random = new Random();
        var prompt = journal.Prompts[random.Next(journal.Prompts.Count)];
        Console.WriteLine(prompt);
        var response = Console.ReadLine();
        journal.AddEntry(response);
        Console.WriteLine("Entry added successfully!");
    }

    private static void SaveJournal()
    {
        Console.Write("Enter filename to save journal: ");
        var filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved successfully!");
    }

    private static void LoadJournal()
    {
        Console.Write("Enter filename to load journal: ");
        var filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded successfully!");
    }
}
