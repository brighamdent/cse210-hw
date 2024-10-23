class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        Menu menu = new Menu(user);
        menu.ShowMenu();
    }
}

