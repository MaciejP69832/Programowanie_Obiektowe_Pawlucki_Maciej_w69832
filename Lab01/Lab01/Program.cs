// main
zadanie1();
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
}
double DoubleInput()
{
    Console.WriteLine("Podaj liczbę: ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

