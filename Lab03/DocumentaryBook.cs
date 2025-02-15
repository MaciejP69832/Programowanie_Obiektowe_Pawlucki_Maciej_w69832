using System;
public class DocumentaryBook : Book
{
    private string documentaryType;
    public string DocumentaryType
    {
        get { return documentaryType; }
        set { documentaryType = value; }
    }
    public DocumentaryBook(string title, Person author, string releaseDate, string documentaryType)
        : base(title, author, releaseDate)
    {
        this.documentaryType = documentaryType;
    }
    public override void View()
    {
        base.View();
        Console.WriteLine($"Typ dokumentu: {DocumentaryType}");
    }
}