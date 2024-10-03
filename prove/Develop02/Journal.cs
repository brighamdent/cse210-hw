using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    private List<JournalEntry> entries;
    private List<string> prompts;

    public Journal()
    {
        entries = new List<JournalEntry>();
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
        };
    }

    // Add this property to expose the prompts
    public List<string> Prompts
    {
        get { return prompts; }
    }

    public void AddEntry(string response)
    {
        var random = new Random();
        var prompt = prompts[random.Next(prompts.Count)];
        var entry = new JournalEntry(prompt, response);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        File.WriteAllLines(filename, entries.Select(e => $"{e.Date}|{e.Prompt}|{e.Response}"));
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        var lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
            {
                var entry = new JournalEntry(parts[1], parts[2]) { Date = parts[0] };
                entries.Add(entry);
            }
        }
    }
}
