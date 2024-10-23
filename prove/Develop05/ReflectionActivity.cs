public class ReflectionActivity : Activity
{
    private User user;

    public ReflectionActivity(User user)
    {
        this.user = user;
    }

    public override void PerformActivity()
    {
        StartMessage("Reflection", "This activity will help you reflect on your thoughts.");

        Console.WriteLine(
            "Think about a time you faced a challenge. Press Enter when you are ready."
        );
        Console.ReadLine();

        Console.WriteLine("You can start reflecting now...");
        ShowAnimation();

        Console.WriteLine("What did you learn from this experience?");
        string reflection = Console.ReadLine();

        Console.WriteLine("Thank you for sharing your reflection.");
        EndMessage("Reflection");
        user.ReflectionCount++;
        user.SaveProgress();
    }

    protected new void StartMessage(string title, string description)
    {
        Console.WriteLine($"{title}: {description}");
        Console.WriteLine("Let's begin...");
    }

    protected new void EndMessage(string title)
    {
        Console.WriteLine($"End of {title}. Thank you for participating.");
    }
}
