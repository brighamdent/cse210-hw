public class Menu
{
    private User user;

    public Menu(User user)
    {
        this.user = user;
    }

    public void ShowMenu()
    {
        user.ShowProgress();

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.WriteLine();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Prompt for duration
                    Console.WriteLine(
                        "Enter the duration (in seconds) for the breathing activity:"
                    );
                    if (int.TryParse(Console.ReadLine(), out int duration))
                    {
                        BreathingActivity breathingActivity = new BreathingActivity(user, duration);
                        breathingActivity.PerformActivity();
                    }
                    else
                    {
                        Console.WriteLine("Invalid duration. Please enter a number.");
                    }
                    break;

                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity(user);
                    reflectionActivity.PerformActivity();
                    break;

                case "3":
                    ListingActivity listingActivity = new ListingActivity(user);
                    listingActivity.PerformActivity();
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }
}
