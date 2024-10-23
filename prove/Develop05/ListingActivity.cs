public class ListingActivity : Activity
{
    private User user;

    public ListingActivity(User user)
    {
        this.user = user;
    }

    public override void PerformActivity()
    {
        StartMessage(
            "Listing",
            "This activity will help you list things that are important to you."
        );

        Console.WriteLine(
            "Think of as many things as you can that are important to you. Press Enter when you are ready."
        );
        Console.ReadLine();

        Console.WriteLine("You can start listing now...");
        ShowAnimation();

        Console.WriteLine("List your important things below:");
        string items = Console.ReadLine();

        Console.WriteLine("Thank you for sharing your list.");
        EndMessage("Listing");
        user.ListingCount++;
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
