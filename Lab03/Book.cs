using System;
public class Book
{
    protected string title { get; set; }
    protected Person author { get; set; }
    protected string releaseDate { get; set; }
    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    public Person Author
    {
        get { return author; }
        set { author = value; }
    }
    public string ReleaseDate
    {
        get { return releaseDate; }
        set { releaseDate = value; }
    }
    public Book(string title, Person author, string releaseDate)
    {
        this.title = title;
        this.author = author;
        this.releaseDate = releaseDate;
    }
    public virtual void View()
    {
        Console.WriteLine($"Książka: {Title}, Autor: {Author.FirstName} {Author.LastName}, Data wydania: {ReleaseDate}");
    }
}