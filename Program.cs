using System;
using System.Xml.Serialization;
namespace Programowanie_obiektowe_w69832
{
    internal class RozwiazaniaLab
    {
        private static void Main()
        {
            Lab01 labZadania = new();
            Lab02 labZadania2 = new();
            Lab03 labZadania3 = new();
            Lab04 labZadania4 = new();
            Lab05 labZadania5 = new();
            Lab06 labZadania6 = new();

            // main
            while (true)
            {
                Console.WriteLine("Wybierz Laboratorium do uruchomienia:");
                Console.WriteLine("1: Lab 1");
                Console.WriteLine("2: Lab 2");
                Console.WriteLine("3: Lab 3");
                Console.WriteLine("4: Lab 4");
                Console.WriteLine("5: Lab 5");
                Console.WriteLine("6: Lab 6");
                Console.WriteLine("0: Wyjście");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        labZadania.Lab1Menu();
                        break;
                    case "2":
                        labZadania2.Lab2Menu();
                        break;
                    case "3":
                        labZadania3.Lab3Menu();
                        break;
                    case "4":
                        labZadania4.Lab4Menu();
                        break;
                    case "5":
                        labZadania5.Lab5Menu();
                        break;
                    case "6":
                        labZadania6.Lab6Menu();
                        break;
                    case "0":
                        Console.WriteLine("Zakończono program.");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                        break;
                }
                Console.WriteLine();
            }
            // koniec main
        }
    }
}