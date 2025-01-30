using System;
using System.Security.Cryptography;
namespace Programowanie_obiektowe_w69832
{
    public class Lab01
    {
        public void Lab1Menu()
        {
            while (true)
            {
                Console.WriteLine("Lab 1 - Wybierz Zadanie:");
                Console.WriteLine("1: Zadanie 1");
                Console.WriteLine("2: Zadanie 2");
                Console.WriteLine("3: Zadanie 3");
                Console.WriteLine("4: Zadanie 4");
                Console.WriteLine("5: Zadanie 5");
                Console.WriteLine("6: Zadanie 6");
                Console.WriteLine("7: Zadanie 7");
                Console.WriteLine("0: Powrót do głównego menu");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Lab1zadanie1();
                        break;
                    case "2":
                        Lab1zadanie2();
                        break;
                    case "3":
                        Lab1zadanie3();
                        break;
                    case "4":
                        Lab1zadanie4();
                        break;
                    case "5":
                        Lab1zadanie5();
                        break;
                    case "6":
                        Lab1zadanie6();
                        break;
                    case "7":
                        Lab1zadanie7();
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

        static void Lab1zadanie1()
        //  Napisz program obliczający wyróżnik delta i pierwiastki trójmianu kwadratowego.
        {
            double a = DoubleInput();
            double b = DoubleInput();
            double c = DoubleInput();

            double delta, x1, x2;

            if (a == 0) Console.WriteLine("To nie jest równanie kwadratowe");
            else
            {
                delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0) Console.WriteLine("Brak rozwiązania w zbiorze liczb rzeczywistych");
                else if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"x1 = {x1}, \tx2 = {x2}");
                    Console.WriteLine("x1 = " + x1.ToString("F3") + "\tx2 = " + x2.ToString("F3"));
                    Console.WriteLine($"x1 = {x1:F3}, \tx2 = {x2:F3}");


                }
                else
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine($"Jedno rozwiązanie x1 = {x1}");
                }
            }
            static double DoubleInput()
            {
                Console.WriteLine("Podaj liczbę: ");
                double value = Convert.ToDouble(Console.ReadLine());
                return value;
            }
        }

        static void Lab1zadanie2()
        // Napisz kalkulator obliczający: sumę, różnicę, iloczyn, iloraz, potęgę, pierwiastek,
        // oraz wartości funkcji trygonometrycznych dla zadanego kąta.Użyj biblioteki Math np.Math.Sin(2.5).
        // Proszę pamiętać, że wartości kąta podawane do funkcji mierzone są miarą łukową.
        // Wyniki działania algorytmów wyświetlaj na konsoli.
        // Do obsługi menu proszę użyć konstrukcji switch-case oraz pętli while.
        {
            while (true)
            {
                Console.WriteLine("Wybierz operację:");
                Console.WriteLine("1: Suma");
                Console.WriteLine("2: Różnica");
                Console.WriteLine("3: Iloczyn");
                Console.WriteLine("4: Iloraz");
                Console.WriteLine("5: Potęga");
                Console.WriteLine("6: Pierwiastek");
                Console.WriteLine("7: Sinus");
                Console.WriteLine("8: Cosinus");
                Console.WriteLine("9: Tangens");
                Console.WriteLine("0: Wyjście");

                string choice = Console.ReadLine();
                double a, b;

                switch (choice)
                {
                    case "1":
                        Console.Write("Podaj pierwszą liczbę: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj drugą liczbę: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Wynik: {a + b}");
                        break;
                    case "2":
                        Console.Write("Podaj pierwszą liczbę: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj drugą liczbę: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Wynik: {a - b}");
                        break;
                    case "3":
                        Console.Write("Podaj pierwszą liczbę: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj drugą liczbę: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Wynik: {a * b}");
                        break;
                    case "4":
                        Console.Write("Podaj pierwszą liczbę: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj drugą liczbę: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        if (b != 0)
                            Console.WriteLine($"Wynik: {a / b}");
                        else
                            Console.WriteLine("Błąd: Dzielenie przez zero!");
                        break;
                    case "5":
                        Console.Write("Podaj podstawę: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj wykładnik: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Wynik: {Math.Pow(a, b)}");
                        break;
                    case "6":
                        Console.Write("Podaj liczbę: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        if (a >= 0)
                            Console.WriteLine($"Wynik: {Math.Sqrt(a)}");
                        else
                            Console.WriteLine("Błąd: Nie można pierwiastkować liczby ujemnej!");
                        break;
                    case "7":
                        Console.Write("Podaj kąt w radianach: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Wynik: {Math.Sin(a)}");
                        break;
                    case "8":
                        Console.Write("Podaj kąt w radianach: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Wynik: {Math.Cos(a)}");
                        break;
                    case "9":
                        Console.Write("Podaj kąt w radianach: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Wynik: {Math.Tan(a)}");
                        break;
                    case "0":
                        Console.WriteLine("Zakończono program.");
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void Lab1zadanie3()
        // Napisz program umożliwiający wprowadzanie 10-ciu liczb rzeczywistych do tablicy.
        // Następnie utwórz następujące funkcjonalności używając pętli for:
        // • Wyświetlanie tablicy od pierwszego do ostatniego indeksu.
        // • Wyświetlanie tablicy od ostatniego do pierwszego indeksu.
        // • Wyświetlanie elementów o nieparzystych indeksach.
        // • Wyświetlanie elementów o parzystych indeksach.
        // Wyniki działania algorytmów wyświetlaj na konsoli. Dla wyboru powyższych funkcjonalności programu 
        // utwórz odpowiednie menu. Do obsługi menu użyć rozbudowanej konstrukcji else-if oraz pętli do-while.
        {
            const int size = 10;
            double[] liczby = new double[size];

            Console.WriteLine("Wprowadź 10 liczb rzeczywistych:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out liczby[i]))
                {
                    Console.WriteLine("Nieprawidłowa wartość. Spróbuj ponownie.");
                    Console.Write($"Podaj liczbę {i + 1}: ");
                }
            }
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Wyświetl tablicę od początku");
                Console.WriteLine("2. Wyświetl tablicę od końca");
                Console.WriteLine("3. Wyświetl elementy o nieparzystych indeksach");
                Console.WriteLine("4. Wyświetl elementy o parzystych indeksach");
                Console.WriteLine("0. Wyjście");
                Console.Write("Wybierz opcję: ");

                string wybor = Console.ReadLine();

                if (wybor == "1")
                {
                    Console.WriteLine("\nTablica od początku:");
                    for (int i = 0; i < liczby.Length; i++)
                    {
                        Console.WriteLine($"Index {i}: {liczby[i]}");
                    }
                }
                else if (wybor == "2")
                {
                    Console.WriteLine("\nTablica od końca:");
                    for (int i = liczby.Length - 1; i >= 0; i--)
                    {
                        Console.WriteLine($"Index {i}: {liczby[i]}");
                    }
                }
                else if (wybor == "3")
                {
                    Console.WriteLine("\nElementy o nieparzystych indeksach:");
                    for (int i = 1; i < liczby.Length; i += 2)
                    {
                        Console.WriteLine($"Index {i}: {liczby[i]}");
                    }
                }
                else if (wybor == "4")
                {
                    Console.WriteLine("\nElementy o parzystych indeksach:");
                    for (int i = 0; i < liczby.Length; i += 2)
                    {
                        Console.WriteLine($"Index {i}: {liczby[i]}");
                    }
                }
                else if (wybor == "0")
                {
                    Console.WriteLine("Koniec programu.");
                    break;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                }

                Console.WriteLine();
            }
            while (true);
        }
        static void Lab1zadanie4()
        // Napisz program umożliwiający wprowadzanie 10-ciu liczb. Dla wprowadzonych liczb wykonaj odpowiednie algorytmy:
        // • oblicz sumę elementów tablicy,
        // • oblicz iloczyn elementów tablicy,
        // • wyznacz wartość średnią,
        // • wyznacz wartość minimalną,
        // • wyznacz wartość maksymalną
        // Wyniki działania algorytmów wyświetlaj na konsoli.
        {
            const int size = 10;
            double[] numbers = new double[size];

            Console.WriteLine("Wprowadź 10 liczb:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Nieprawidłowy format. Spróbuj ponownie.");
                    Console.Write($"Podaj liczbę {i + 1}: ");
                }
            }


            double suma = numbers.Sum();


            double iloczyn = numbers.Aggregate(1.0, (acc, val) => acc * val);


            double srednia = suma / size;


            double min = numbers.Min();
            double max = numbers.Max();


            Console.WriteLine("\nWyniki:");
            Console.WriteLine($"Suma elementów: {suma}");
            Console.WriteLine($"Iloczyn elementów: {iloczyn}");
            Console.WriteLine($"Średnia wartość: {srednia}");
            Console.WriteLine($"Minimalna wartość: {min}");
            Console.WriteLine($"Maksymalna wartość: {max}");
        }
        static void Lab1zadanie5()
        //  Napisz program wyświetlający liczby od 20-0, z wyłączeniem liczb {2,6,9,15,19}.
        //  Do realizacji zadania wyłączenia użyj instrukcji continue;
        {
            for (int i = 20; i >= 0; i--)
            {
                if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        static void Lab1zadanie6()
        // Napisz program, który w nieskończoność pyta użytkownika o liczby całkowite.
        // Pętla nieskończona powinna się zakończyć gdy użytkownik wprowadzi liczbę mniejszą od zera.
        // Do opuszczenia pętli nieskończonej użyj instrukcji break.
        {
            while (true)
            {
                Console.Write("Podaj liczbę całkowitą: ");

                if (int.TryParse(Console.ReadLine(), out int liczba))
                {
                    if (liczba < 0)
                    {
                        break;
                    }

                    Console.WriteLine($"Wprowadzona liczba to: {liczba}");
                }
                else
                {
                    Console.WriteLine("Proszę podać poprawną liczbę całkowitą.");
                }
            }

            Console.WriteLine("Koniec programu. Wprowadzono liczbę mniejszą od zera.");
        }
        static void Lab1zadanie7()
        //  Napisz program umożliwiający wprowadzanie n liczb oraz sortujący te liczby metodą bąbelkową lub wstawiania.Wyniki wyświetlaj na konsoli.
        {
            Console.Write("Ile liczb chcesz wprowadzić? ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[] liczby = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Podaj liczbę {i + 1}: ");
                    liczby[i] = int.Parse(Console.ReadLine());
                }

                Array.Sort(liczby);

                Console.WriteLine("Posortowane liczby: ");
                foreach (int liczba in liczby)
                    Console.WriteLine(liczba);
            }
            else
            {
                Console.WriteLine("Podaj poprawną liczbę.");
            }
        }
    }
}