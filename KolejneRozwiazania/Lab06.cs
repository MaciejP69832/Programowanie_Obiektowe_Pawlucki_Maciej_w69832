using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie_obiektowe_w69832
{
    public class Lab06
    {
        public void Lab6Menu()
        {
            while (true)
            {
                Console.WriteLine("Lab 6 - wybierz zadanie do uruchomienia.");
                Console.WriteLine("1. Zadanie 1.");
                Console.WriteLine("2. Zadanie 2.");
                Console.WriteLine("3. Zadanie 3.");
                Console.WriteLine("0. Powrót.");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Lab6Zadanie1();
                        break;
                    case "2":
                        Lab6Zadanie2();
                        break;
                    case "3":
                        Lab6Zadanie3();
                        break;
                    case "4":
                        break;
                    case "5":
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
        public void Lab6Zadanie1()
        {
            Console.Write("Podaj nazwę pliku (bez rozszerzenia): ");
            string nazwaPliku = Console.ReadLine() + ".txt";

            Console.Write("Podaj numer albumu: ");
            string nrAlbumu = Console.ReadLine();

            try
            {
                File.WriteAllText(nazwaPliku, nrAlbumu);
                Console.WriteLine($"Numer albumu {nrAlbumu} zapisano do pliku {nazwaPliku}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Błąd podczas zapisu do pliku: {e.Message}");
            }
        }
        public void Lab6Zadanie2()
        {
            Console.Write("Podaj nazwę pliku (bez rozszerzenia): ");
            string nazwaPliku = Console.ReadLine() + ".txt";

            try
            {
                string zawartosc = File.ReadAllText(nazwaPliku);
                Console.WriteLine($"Zawartość pliku {nazwaPliku}:\n{zawartosc}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Błąd: Plik nie istnieje.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Błąd podczas odczytu pliku: {e.Message}");
            }
        }

        static Random rand = new Random();

        public static void Lab6Zadanie3()
        {
            string nazwaPliku = "pesels.txt";

            List<string> peselsToWrite = new List<string>();
            int ileMezczyzn = 10;
            int ileKobiet = 8;

            for (int i = 0; i < ileMezczyzn; i++)
            {
                peselsToWrite.Add(GenerujPesel(isMale: true));
            }
            for (int i = 0; i < ileKobiet; i++)
            {
                peselsToWrite.Add(GenerujPesel(isMale: false));
            }

            File.WriteAllLines(nazwaPliku, peselsToWrite);

            try
            {
                List<string> pesels = File.ReadAllLines(nazwaPliku).ToList();
                int liczbaZenskichPeseli = pesels.Count(pesel => IsFemalePesel(pesel));

                Console.WriteLine($"Liczba żeńskich PESELi w pliku: {liczbaZenskichPeseli}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Błąd: Plik nie istnieje.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Błąd podczas odczytu pliku: {e.Message}");
            }
        }

        static bool IsFemalePesel(string pesel)
        {
            if (pesel.Length != 11 || !pesel.All(char.IsDigit))
                return false;

            int genderDigit = int.Parse(pesel[9].ToString());
            return genderDigit % 2 == 0;
        }

        static string GenerujPesel(bool isMale)
        {
            DateTime start = new DateTime(1900, 1, 1);
            DateTime end = new DateTime(1999, 12, 31);
            int dni = (end - start).Days;
            DateTime dataUrodzenia = start.AddDays(rand.Next(dni + 1));

            string rok = dataUrodzenia.ToString("yy");
            string miesiac = dataUrodzenia.ToString("MM");
            string dzien = dataUrodzenia.ToString("dd");
            string czescDaty = rok + miesiac + dzien;

            int numerSeryjny = rand.Next(0, 1000);
            string seryjny = numerSeryjny.ToString("D3");

            int cyfraPlci;
            if (isMale)
            {
                int[] cyfryMezczyzn = { 1, 3, 5, 7, 9 };
                cyfraPlci = cyfryMezczyzn[rand.Next(cyfryMezczyzn.Length)];
            }
            else
            {
                int[] cyfryKobiet = { 0, 2, 4, 6, 8 };
                cyfraPlci = cyfryKobiet[rand.Next(cyfryKobiet.Length)];
            }

            string pierwsze10 = czescDaty + seryjny + cyfraPlci.ToString();
            int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                int cyfra = int.Parse(pierwsze10[i].ToString());
                suma += cyfra * wagi[i];
            }
            int modulo = suma % 10;
            int cyfraKontrolna = (10 - modulo) % 10;

            return pierwsze10 + cyfraKontrolna.ToString();
        }
    }
}