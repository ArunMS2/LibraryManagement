using System.Net;

namespace LibraryManagement;

public class Libraryitem
{
    public int Id;
    public string Title;
    public string Author;

    // public Libraryitem(string title, string author, string isbn)
    // {

    //     Title = title;
    //     Author = author;
    //     ISBN = isbn;

    // }
    public Libraryitem() { }

    public Libraryitem( int id, string title,string author)
    {
        Id = id;
        Title = title;
        Author = author;

    }

    public void Showinfo()
    {
        Console.WriteLine($"Title:{Title}");
        Console.WriteLine($"Author:{Author}");
        Console.WriteLine($"ID:{Id}");
       
    }
}