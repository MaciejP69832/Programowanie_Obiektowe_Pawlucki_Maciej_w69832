using System;
public class Reviewer : Reader
{
    private Random random;
    public Reviewer(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
        random = new Random();
    }
    public void Wypisz()
    {
        Console.WriteLine($"Recenzent: {FirstName} {LastName} ({Age} lat)");
        Console.WriteLine("Przeczytane książki z ocenami:");
        foreach (var book in ReadBooks)
        {
            int rating = random.Next(1, 6);
            Console.WriteLine($"- {book.Title} - Ocena: {rating}/5");
        }
    }
}