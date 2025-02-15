using System;
class SamochodOsobowy : Samochod
{
    private double waga;
    public double Waga
    {
        get => waga;
        set
        {
            if (value < 2.0 || value > 4.5)
            {
                Console.WriteLine("Waga musi być z przedziału 2.0 t do 4.5 t. Ustawiono domyślną wartość 2.0 t.");
                waga = 2.0;
            }
            else
            {
                waga = value;
            }
        }
    }
    private double pojemnoscSilnika;
    public double PojemnoscSilnika
    {
        get => pojemnoscSilnika;
        set
        {
            if (value < 0.8 || value > 3.0)
            {
                Console.WriteLine("Pojemność silnika musi być z przedziału 0.8 l do 3.0 l. Ustawiono domyślną wartość 1.0 l.");
                pojemnoscSilnika = 1.0;
            }
            else
            {
                pojemnoscSilnika = value;
            }
        }
    }
    public int IloscOsob { get; set; }
    public SamochodOsobowy() : base()
    {
        Console.Write("Podaj wagę (w tonach): ");
        Waga = double.Parse(Console.ReadLine());

        Console.Write("Podaj pojemność silnika (w litrach): ");
        PojemnoscSilnika = double.Parse(Console.ReadLine());

        Console.Write("Podaj ilość miejsc: ");
        IloscOsob = int.Parse(Console.ReadLine());
    }
    public override void WyswietlInformacje()
    {
        base.WyswietlInformacje();
        Console.WriteLine($"Waga: {Waga} t, Pojemność silnika: {PojemnoscSilnika} l, Ilość miejsc: {IloscOsob}");
    }
}