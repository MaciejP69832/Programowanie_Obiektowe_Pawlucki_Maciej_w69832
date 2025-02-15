using System;
public class Licz
{
    private int value;
    private string nazwa;
    public Licz(string nazwa, int initialValue)
    {
        this.nazwa = nazwa;
        value = initialValue;
    }
    public void Dodaj(int liczba)
    {
        value += liczba;
    }
    public void Odejmij(int liczba)
    {
        value -= liczba;
    }
    public void WypiszStan()
    {
        Console.WriteLine($"Aktualna wartość dla {nazwa}: {value}");
    }
}