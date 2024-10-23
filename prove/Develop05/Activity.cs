public abstract class Activity
{
    public abstract void PerformActivity();

    protected virtual void StartMessage(string title, string description)
    {
        Console.WriteLine($"{title}: {description}");
    }

    protected virtual void EndMessage(string title)
    {
        Console.WriteLine($"End of {title}. Thank you for participating.");
    }

    protected void ShowAnimation()
    {
        Console.WriteLine("......");
        System.Threading.Thread.Sleep(3000);
    }
}
