
using System.Collections;
using System.Runtime.CompilerServices;

namespace LibraryManagement;

public class Library
{
    private List<Libraryitem> libraryitems;
    private List<Book> Books;
    private List<Magazine> Magazines;
    NotificationService notificationService;

    public Library()
    {
        libraryitems = new List<Libraryitem>();
        Books = new List<Book>();
        Magazines = new List<Magazine>();
        notificationService = new NotificationService();
        notificationService.OnNotify += notificationService.SendEmailNotification;

    }
    public void AddItem(Libraryitem item)
    {
        libraryitems.Add(item);
        notificationService.Notify($"A new book '{item.Title}' has added");
    }
    public void RemoveItem(Libraryitem item) => libraryitems.Remove(item);
    public void ListItems()
    {
        foreach( var item in libraryitems)
        {
            item.Showinfo();
        }
    }
    public void AddBook(Book item) => Books.Add(item);

    public void RemoveBook(Book item) => Books.Remove(item);
    public void ListBook()
    {
        foreach( var item in Books)
        {
            item.Showinfo();
        }
    }
    public void AddMagazine(Magazine item) => Magazines.Add(item);
    public void RemoveMagazine(Magazine item) => Magazines.Remove(item);
    public void ListMagazine()
    {
        foreach( var item in Magazines)
        {
            item.Showinfo();
        }
    }

}