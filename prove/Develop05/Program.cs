// As my creative addition I user and progress tracking.

class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        Menu menu = new Menu(user);
        menu.ShowMenu();
    }
}

