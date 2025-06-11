using LibraryManagement;
using System;
//version 1
// Book b1 = new Book { Title = "PS1", Author = "Mani", ISBN = "1234" };
// Book b2 = new Book { Title = "PS2", Author = "Ratnam", ISBN = "4321" };
Library library = new Library();
try
{
    // Book b3 = new Book("Pride and Prejudice", "J Austin", "12345");
    Console.WriteLine("Welcome");
    Libraryitem b2 = new Book(1, "The great", "F.Scott", "1234567890123456");
    library.AddItem(b2);
    Libraryitem b3 = new Book(2, "The great", "F.Scott", "1234567890123456");
    library.AddItem(b3);
    library.ListItems();

    Book b = new Book(3, "The great", "F.Scott", "1234567890123456");
    library.AddBook(b);
    library.ListBook();
    Magazine b1 = new Magazine(4, "The great", 1234567);
    library.AddMagazine(b1);
    library.ListMagazine();

    
    // b3.DisplayDetails();
}
catch (InvalidBookException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
// b1.DisplayDetails();
// b2.DisplayDetails();
// b1.Showinfo();
// Magazine M1 = new Magazine(123, "Cassanda", 124);
// M1.Showinfo();
// // b2.DisplayDetails();
// FineCalculator f1 = new FineCalculator();
// f1.CalculateFine(1);