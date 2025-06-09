namespace LibraryManagement;

public class Libraryitem
{
    public int id;
    public string Title;

    public Libraryitem(string title)
    {
       
        Title = title;
    }
    public Libraryitem(){}
    public void Showinfo()
    {
        Console.WriteLine($"The item is {Title}");
    }
}