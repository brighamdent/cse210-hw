using System;
using System.IO;

public class User
{
    public string Name { get; set; }
    private string progressFile = "progress.txt";
    public int BreathingCount { get; set; }
    public int ReflectionCount { get; set; }
    public int ListingCount { get; set; }

    public User()
    {
        Console.WriteLine("Enter your name:");
        Name = Console.ReadLine();
        LoadProgress();
    }

    public void SaveProgress()
    {
        using (StreamWriter writer = new StreamWriter(progressFile))
        {
            writer.WriteLine(BreathingCount);
            writer.WriteLine(ReflectionCount);
            writer.WriteLine(ListingCount);
        }
    }

    private void LoadProgress()
    {
        if (File.Exists(progressFile))
        {
            string[] lines = File.ReadAllLines(progressFile);
            BreathingCount = int.Parse(lines[0]);
            ReflectionCount = int.Parse(lines[1]);
            ListingCount = int.Parse(lines[2]);
        }
        else
        {
            BreathingCount = 0;
            ReflectionCount = 0;
            ListingCount = 0;
        }
    }

    public void ShowProgress()
    {
        Console.WriteLine($"Hello {Name}, here's your progress:");
        Console.WriteLine($"- Breathing Activity: {BreathingCount} times");
        Console.WriteLine($"- Reflection Activity: {ReflectionCount} times");
        Console.WriteLine($"- Listing Activity: {ListingCount} times");
    }
}
