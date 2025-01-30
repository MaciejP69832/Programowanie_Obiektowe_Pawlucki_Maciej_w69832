using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie_obiektowe_w69832
{
    public class Lab02
    {
        public void Lab2Menu()
        {
            while (true)
            {
                Console.WriteLine("Lab 2 - wybierz zadanie do uruchomienia.");
                Console.WriteLine("1. Zadanie 1.");
                Console.WriteLine("2. Zadanie 2.");
                Console.WriteLine("3. Zadanie 3.");
                Console.WriteLine("4. Zadanie 4.");
                Console.WriteLine("5. Zadanie 5.");
                Console.WriteLine("0. Powrót.");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Lab2Zadanie1();
                        break;
                    case "2":
                        Lab2Zadanie2();
                        break;
                    case "3":
                        Lab2Zadanie3();
                        break;
                    case "4":
                        Lab2Zadanie4();
                        break;
                    case "5":
                        Lab2Zadanie5();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                        break;
                }
                Console.WriteLine();
            }
        }
        static void Lab2Zadanie1()
        {
            Osoba osoba = new("Jan", "Kowalski", 30);
            Osoba osoba2 = new("Maciej", "Pawłucki", 26);
            osoba.WyswietlInformacje();
            osoba2.WyswietlInformacje();
        }
        static void Lab2Zadanie2()
        {
            BankAccount konto = new("Jan Kowalski", 1000);
            Console.WriteLine($"Saldo: {konto.Saldo}");
            Console.WriteLine("Wybierz operacje:");
            Console.WriteLine("1. Wplata");
            Console.WriteLine("2. Wyplata");
            string wybor = Console.ReadLine();
            if (wybor == "1")
            {
                Console.WriteLine("Podaj kwotę wpłaty");
                int kwotawplaty = int.Parse(Console.ReadLine());
                konto.Wplata(kwotawplaty);
            }
            else if (wybor == "2")
            {
                Console.WriteLine("Podaj kwote wyplaty: ");
                int kwotawyplaty = int.Parse(Console.ReadLine());
                konto.Wyplata(kwotawyplaty);
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór.");
                return;
            }
            Console.WriteLine($"Saldo: {konto.Saldo}");
        }
        static void Lab2Zadanie3()
        {
            Student student = new("Jan", "Kowalski");

            student.DodajOcene(4);
            student.DodajOcene(5);
            student.DodajOcene(3);

            student.WyswietlDane();

            student.DodajOcene(5);

            student.WyswietlDane();
        }
        static void Lab2Zadanie4()
        {
            Licz liczba1 = new Licz("liczba1", 10);
            Licz liczba2 = new Licz("liczba2", 20);
            liczba1.Dodaj(5);   
            liczba1.WypiszStan(); 

            liczba1.Odejmij(3);
            liczba1.WypiszStan(); 

            liczba2.Dodaj(10);
            liczba2.WypiszStan();

            liczba2.Odejmij(15);
            liczba2.WypiszStan();
        }
        static void Lab2Zadanie5()
        {
            int[] dane = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Sumator sumator = new Sumator(dane);

            sumator.WypiszElementy();
            Console.WriteLine($"Suma wszystkich elementów: {sumator.Suma()}");
            Console.WriteLine($"Suma elementów podzielnych przez 2: {sumator.SumaPodziel2()}");
            Console.WriteLine($"Liczba elementów w tablicy: {sumator.IleElementów()}");

            Console.WriteLine("\nWypisanie elementów w zakresie indeksów (3, 7):");
            sumator.WypiszElementyZakres(3, 7);

            Console.WriteLine("\nPróba wypisania elementów spoza zakresu (0, 20):");
            sumator.WypiszElementyZakres(0, 20);
        }
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
        public class Osoba
        {
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public int Wiek { get; set; }

            public Osoba(string imie, string nazwisko, int wiek)
            {
                Imie = imie;
                Nazwisko = nazwisko;
                Wiek = wiek;
            }

            public void WyswietlInformacje()
            {
                Console.WriteLine($"Imię: {Imie}, Nazwisko: {Nazwisko}, Wiek: {Wiek}");
            }
        }
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
    }
}
