using System;
using System.Xml.Serialization;
using Programowanie_obiektowe_w69832;
namespace Programowanie_obiektowe_w69832
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Lab01 labZadania = new();
            Lab02 labZadania2= new();
            // main
            while (true)
            {
                Console.WriteLine("Wybierz Laboratorium do uruchomienia:");
                Console.WriteLine("1: Lab 1");
                Console.WriteLine("2: Lab 2");
                Console.WriteLine("3: Lab 3");
                Console.WriteLine("4: Lab 4");
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
                        break;
                    case "4":
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
            

