namespace Programowanie_obiektowe_w69832
{
    public class Lab05
    {
        public void Lab5Menu()
        {
            while (true)
            {
                Console.WriteLine("Lab 5 - wybierz zadanie do uruchomienia.");
                Console.WriteLine("1. Zadanie 1.");
                Console.WriteLine("2. Zadanie 2.");
                Console.WriteLine("3. Zadanie 3.");
                Console.WriteLine("0. Powrót.");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Lab5Zadanie1();
                        break;
                    case "2":
                        Lab5Zadanie2();
                        break;
                    case "3":
                        Lab5Zadanie3();
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
        enum Operacja
        {
            Dodawanie,
            Odejmowanie,
            Mnozenie,
            Dzielenie
        }

        class Kalkulator
        {
            public static List<double> PamiecKalkulatora { get; private set; } = new List<double>();

            public static double WykonajOperacje(double a, double b, Operacja operacja)
            {
                switch (operacja)
                {
                    case Operacja.Dodawanie:
                        return a + b;
                    case Operacja.Odejmowanie:
                        return a - b;
                    case Operacja.Mnozenie:
                        return a * b;
                    case Operacja.Dzielenie:
                        if (b == 0)
                            throw new DivideByZeroException("Nie dzielimy przez zero!");
                        return a / b;
                    default:
                        throw new ArgumentException("Błąd operacji");
                }
            }
        }
        public void Lab5Zadanie1()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Podaj pierwszą liczbę: ");
                    double liczba1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Podaj drugą liczbę: ");
                    double liczba2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Wybierz operację:");
                    Console.WriteLine("0.  Dodawanie.");
                    Console.WriteLine("1.  Odejmowanie.");
                    Console.WriteLine("2.  Mnozenie.");
                    Console.WriteLine("3.  Dzielenie.");
                    Operacja operacja = (Operacja)Enum.Parse(typeof(Operacja), Console.ReadLine());

                    double wynik = Kalkulator.WykonajOperacje(liczba1, liczba2, operacja);
                    Kalkulator.PamiecKalkulatora.Add(wynik);

                    Console.WriteLine($"Wynik: {wynik}");
                    Console.WriteLine("Historia wyników: " + string.Join(", ", Kalkulator.PamiecKalkulatora));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd: Wprowadzono nieprawidłową wartość. Wprowadź liczbę.");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"Błąd: {e.Message}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Nieoczekiwany błąd: {e.Message}");
                }

                Console.Write("Czy chcesz wykonać kolejne obliczenie? (tak/nie): ");
                if (Console.ReadLine().ToLower() != "tak")
                    break;
            }
        }
        enum StatusZamowienia
        {
            Oczekujace,
            Przyjete,
            Zrealizowane,
            Anulowane
        }

        class Sklep
        {
            private Dictionary<int, (StatusZamowienia, List<string>)> zamowienia = new Dictionary<int, (StatusZamowienia, List<string>)>();

            public void DodajZamowienie(int numer, List<string> produkty)
            {
                zamowienia[numer] = (StatusZamowienia.Oczekujace, produkty);
            }

            public void ZmienStatusZamowienia(int numer, StatusZamowienia nowyStatus)
            {
                if (!zamowienia.ContainsKey(numer))
                    throw new KeyNotFoundException("Nie znaleziono zamówienia o podanym numerze.");

                if (zamowienia[numer].Item1 == nowyStatus)
                    throw new ArgumentException("Nowy status jest taki sam jak obecny.");

                zamowienia[numer] = (nowyStatus, zamowienia[numer].Item2);
            }

            public void WyswietlZamowienia()
            {
                foreach (var zamowienie in zamowienia)
                {
                    Console.WriteLine($"Zamówienie {zamowienie.Key}: Status - {zamowienie.Value.Item1}, Produkty: {string.Join(", ", zamowienie.Value.Item2)}");
                }
            }
        }
        public void Lab5Zadanie2()
        {
            Sklep sklep = new Sklep();
            sklep.DodajZamowienie(1, new List<string> { "Mąka", "Jajka" });
            sklep.DodajZamowienie(2, new List<string> { "Mleko", "Bułki" });

            while (true)
            {
                Console.WriteLine("Wybierz operację:");
                Console.WriteLine("1. Wyświetl zamówienia");
                Console.WriteLine("2. Zmień status zamówienia");
                Console.WriteLine("3. Wyjście");
                string wybor = Console.ReadLine();

                if (wybor == "1")
                {
                    sklep.WyswietlZamowienia();
                }
                else if (wybor == "2")
                {
                    try
                    {
                        Console.Write("Podaj numer zamówienia: ");
                        int numer = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Wybierz nowy status:");
                        Console.WriteLine("0.  Oczekujące.");
                        Console.WriteLine("1.  Przyjęte.");
                        Console.WriteLine("2.  Zrealizowane.");
                        Console.WriteLine("3.  Anulowane.");
                        StatusZamowienia nowyStatus = (StatusZamowienia)Enum.Parse(typeof(StatusZamowienia), Console.ReadLine());

                        sklep.ZmienStatusZamowienia(numer, nowyStatus);
                        Console.WriteLine("Status zamówienia został zmieniony.");
                    }
                    catch (KeyNotFoundException e)
                    {
                        Console.WriteLine($"Błąd: {e.Message}");
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine($"Błąd: {e.Message}");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Błąd: Wprowadzono nieprawidłową wartość.");
                    }
                }
                else if (wybor == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nieznana opcja, spróbuj ponownie.");
                }
            }
        }
        enum Kolor
        {
            Rozowy,
            Turkus,
            Bordowy,
            Czarny,
            Fioletowy
        }

        class Gra
        {
            private static List<Kolor> kolory = new List<Kolor> { Kolor.Rozowy, Kolor.Turkus, Kolor.Bordowy, Kolor.Czarny, Kolor.Fioletowy };
            private static Random random = new Random();
            private static Kolor wylosowanyKolor = kolory[random.Next(kolory.Count)];

            public static void Start()
            {
                Console.WriteLine("Zgadywanie kolorów!");
                Console.WriteLine("Wybierz prawidłowy z podanych kolorów: Rozowy, Turkus, Bordowy, Czarny, Fioletowy");

                while (true)
                {
                    try
                    {
                        Console.Write("Zgadnij kolor: ");
                        string input = Console.ReadLine();
                        Kolor zgadnietyKolor = (Kolor)Enum.Parse(typeof(Kolor), input, true);

                        if (zgadnietyKolor == wylosowanyKolor)
                        {
                            Console.WriteLine("Gratulacje! Prawidłowy kolor to " + wylosowanyKolor + "!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Niepoprawny kolor, spróbuj ponownie.");
                        }
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Spróbuj ponownie.");
                    }
                }
            }
        }
        public void Lab5Zadanie3()
        {
            Gra.Start();
        }
    }
}