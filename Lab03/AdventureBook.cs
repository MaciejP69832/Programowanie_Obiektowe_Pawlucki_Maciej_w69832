using System;
public class AdventureBook : Book
{
    private string difficultyLevel;
    public string DifficultyLevel
    {
        get { return difficultyLevel; }
        set { difficultyLevel = value; }
    }
    public AdventureBook(string title, Person author, string releaseDate, string difficultyLevel)
        : base(title, author, releaseDate)
    {
        this.difficultyLevel = difficultyLevel;
    }
    public override void View()
    {
        base.View();
        Console.WriteLine($"Poziom trudności: {DifficultyLevel}");
    }
}