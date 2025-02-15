using System;
public class BankAccount
{
    private decimal saldo;
    public string Wlasciciel { get; private set; }
    public BankAccount(string wlasciciel, decimal poczatkoweSaldo)
    {
        Wlasciciel = wlasciciel;
        saldo = poczatkoweSaldo;
    }
    public decimal Saldo
    {
        get { return saldo; }
    }
    public void Wplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Kwota wpłaty musi być większa niż 0.");
            return;
        }
        saldo += kwota;
    }
    public void Wyplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Kwota wypłaty musi być większa niż 0.");
            return;
        }
        if (kwota > saldo)
        {
            Console.WriteLine("Brak wystarczających środków na koncie.");
        }
        else
        {
            saldo -= kwota;
        }
    }
}
