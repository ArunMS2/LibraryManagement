namespace LibraryManagement;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author )
    {
        Title=title;
        Author=author;
    }

    public void DisplayDetails()
{
    Console.WriteLine($"Title:{Title}");
    Console.WriteLine($"Author:{Author}");
    Console.WriteLine($"$ISBN:{ISBN}");
}
}