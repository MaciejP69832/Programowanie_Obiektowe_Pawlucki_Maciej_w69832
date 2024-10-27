// main
while (true)
{
    Console.WriteLine("Wybierz zadanie do uruchomienia:");
    Console.WriteLine("1: Zadanie 1");
    Console.WriteLine("2: Zadanie 2");
    Console.WriteLine("3: Zadanie 3");
    Console.WriteLine("0: Wyjście");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            zadanie1();
            break;
        case "2":
            zadanie2();
            break;
        case "3":
            zadanie3();
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
// koniec main

void zadanie1()
{
    double a = DoubleInput();
    double b = DoubleInput();
    double c = DoubleInput();

    double delta, x1, x2;

    if (a == 0) Console.WriteLine("To nie jest równanie kwadratowe");
    else
    {
        delta = (Math.Pow(b, 2)) - (4 * a * c);
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
            x1 = (-b / (2 * a));
            Console.WriteLine($"Jedno rozwiązanie x1 = {x1}");
        }
    } //koniec else
    double DoubleInput()
    {
        Console.WriteLine("Podaj liczbę: ");
        double value = Convert.ToDouble(Console.ReadLine());
        return value;
    }
}
void zadanie2()
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

        Console.WriteLine(); // Pusta linia dla lepszej czytelności
    }
}
void zadanie3()
{
    double a = DoubleInput();
    double b = DoubleInput();
    double c = DoubleInput();

    double delta, x1, x2;

    if (a == 0) Console.WriteLine("To nie jest równanie kwadratowe");
    else
    {
        delta = (Math.Pow(b, 2)) - (4 * a * c);
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
            x1 = (-b / (2 * a));
            Console.WriteLine($"Jedno rozwiązanie x1 = {x1}");
        }
    } //koniec else
    double DoubleInput()
    {
        Console.WriteLine("Podaj liczbę: ");
        double value = Convert.ToDouble(Console.ReadLine());
        return value;
    }

}