namespace LibraryManagement;

public class Book:Libraryitem
{
    // public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author):base(title)
    {
        Title=title;
        Author=author;
    }

    public Book(string title, string author, string isbn) {
        Title = title;
        Author = author;
        if (isbn.Length != 16)
        {
            throw new InvalidBookException("ISBN shoulb be 16 digit");
        }
        else
        {
        ISBN = isbn;
            
        }
        
    }
    public Book(){}
    

    public void DisplayDetails()
    {
        Console.WriteLine($"Title:{Title}");
        Console.WriteLine($"Author:{Author}");
        Console.WriteLine($"$ISBN:{ISBN}");
    }
}