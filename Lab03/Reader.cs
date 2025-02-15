using System;
public class Reader : Person
{
    public List<Book> ReadBooks { get; set; }
    public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
        ReadBooks = new List<Book>();
    }
    public override void View()
    {
        base.View();
        ViewBooks();
    }
    public void ViewBooks()
    {
        Console.WriteLine($"\n{FirstName} {LastName} przeczytał(a) następujące książki:");
        foreach (var book in ReadBooks)
        {
            Console.WriteLine($"- {book.Title}");
        }
    }
    public void ViewDetailedBooks()
    {
        Console.WriteLine($"{FirstName} {LastName} - Przegląd książek:");
        foreach (var book in ReadBooks)
        {
            book.View();
            Console.WriteLine();
        }
    }
}