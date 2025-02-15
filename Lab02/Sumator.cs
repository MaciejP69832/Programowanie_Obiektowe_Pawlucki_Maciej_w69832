using System;
public class Sumator
{
    private int[] liczby;
    public Sumator(int[] liczby)
    {
        this.liczby = liczby ?? new int[0];
    }
    public int Suma()
    {
        int suma = 0;
        foreach (int liczba in liczby)
        {
            suma += liczba;
        }
        return suma;
    }
    public int SumaPodziel2()
    {
        int suma = 0;
        foreach (int liczba in liczby)
        {
            if (liczba % 2 == 0)
            {
                suma += liczba;
            }
        }
        return suma;
    }
    public int IleElementów()
    {
        return liczby.Length;
    }

    public void WypiszElementy()
    {
        Console.WriteLine("Elementy tablicy: " + string.Join(", ", liczby));
    }
    public void WypiszElementyZakres(int lowIndex, int highIndex)
    {
        Console.WriteLine($"Elementy między indeksami {lowIndex} a {highIndex}:");

        for (int i = Math.Max(0, lowIndex); i <= Math.Min(highIndex, liczby.Length - 1); i++)
        {
            Console.WriteLine($"Indeks {i}: {liczby[i]}");
        }
    }
}