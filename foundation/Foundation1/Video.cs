public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    public int Views { get; private set; }
    public int Likes { get; private set; }
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Views = 0;
        Likes = 0;
        Comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        Comments.Add(new Comment(name, text));
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void IncrementViews()
    {
        Views++;
    }

    public void IncrementLikes()
    {
        Likes++;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Views: {Views}");
        Console.WriteLine($"Likes: {Likes}");
        Console.WriteLine($"Comments ({GetCommentCount()}):");

        foreach (var comment in Comments)
        {
            Console.WriteLine($"{comment.Name}: {comment.Text}");
        }
        Console.WriteLine();
    }
}
