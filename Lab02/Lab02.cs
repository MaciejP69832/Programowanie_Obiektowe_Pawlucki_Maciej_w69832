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
    }
}