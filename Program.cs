using LibraryManagement;

//version 1
Book b1 = new Book { Title = "PS1", Author = "Mani", ISBN = "1234" };
Book b2 = new Book { Title = "PS2", Author = "Ratnam", ISBN = "4321" };
Book b3 = new Book ( "Pride and Prejudice", "J Austin");
b1.DisplayDetails();
b2.DisplayDetails();
b3.DisplayDetails();
b1.Showinfo();
Magazine M1 = new Magazine(123, "Cassanda", 124);
M1.Showinfo();
// b2.DisplayDetails();
FineCalculator f1 = new FineCalculator();
f1.CalculateFine(1);
