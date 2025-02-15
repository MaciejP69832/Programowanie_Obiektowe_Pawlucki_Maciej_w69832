using System;
public class Student
{
    private string imie;
    private string nazwisko;
    private int[] oceny;
    public Student(string imie, string nazwisko)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        oceny = [];
    }
    public double SredniaOcen
    {
        get
        {
            if (oceny.Length == 0)
            {
                return 0;
            }
            return oceny.Average();
        }
    }
    public void DodajOcene(int ocena)
    {
        if (ocena >= 2 && ocena <= 5)
        {
            int[] nowaTablica = new int[oceny.Length + 1];
            for (int i = 0; i < oceny.Length; i++)
            {
                nowaTablica[i] = oceny[i];
            }
            nowaTablica[oceny.Length] = ocena;
            oceny = nowaTablica;
        }
        else
        {
            Console.WriteLine("Ocena musi być w zakresie od 2 do 5.");
        }
    }
    public void WyswietlDane()
    {
        Console.WriteLine($"Student: {imie} {nazwisko}");
        Console.WriteLine($"Średnia ocen: {SredniaOcen:F2}");
        Console.WriteLine("Oceny: " + string.Join(", ", oceny));
    }
}