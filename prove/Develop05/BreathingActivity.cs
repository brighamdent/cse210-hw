public class BreathingActivity : Activity
{
    private User user;
    private int duration;

    public BreathingActivity(User user, int duration)
    {
        this.user = user;
        this.duration = duration;
    }

    public override void PerformActivity()
    {
        StartMessage("Breathing", "This activity will help you relax by pacing your breathing.");

        for (int i = 0; i < duration; i += 5)
        {
            Console.WriteLine("Breathe in...");
            ShowAnimation();
            Console.WriteLine("Breathe out...");
            ShowAnimation();
        }

        EndMessage("Breathing");
        user.BreathingCount++;
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
