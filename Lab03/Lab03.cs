using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie_obiektowe_w69832
{
    public class Lab03
    {
        public void Lab3Menu()
        {
            Lab3Zadanie1 Zadania = new Lab3Zadanie1();
            Type typ = typeof(Lab3Zadanie1);
            MethodInfo[] metody = typ.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            while (true)
            {
                Console.WriteLine("Lab 3 - wybierz zadanie do uruchomienia.");
                Console.WriteLine("1. Zadanie 1.");
                Console.WriteLine("2. Zadanie 2.");
                Console.WriteLine("0. Powrót.");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        foreach (var metoda in metody)
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine($"Wywoływanie metody: {metoda.Name}");
                            Console.WriteLine();
                            metoda.Invoke(Zadania, null);
                        }
                        break;
                    case "2":
                        Lab3Zadanie2();
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
        public class Lab3Zadanie1
        {
            public void Lab3Zadanie1a()
            {
                Person author1 = new Person("Adam", "Mickiewicz", 56);
                Person author2 = new Person("Henryk", "Sienkiewicz", 60);
                author1.View();
                author2.View();
                Book book1 = new Book("Pan Tadeusz", author1, "1834");
                Book book2 = new Book("Quo Vadis", author2, "1896");
                book1.View();
                book2.View();
            }
            public void Lab3Zadanie1b()
            {
                Person author1 = new Person("Adam", "Mickiewicz", 56);
                Person author2 = new Person("Henryk", "Sienkiewicz", 60);
                Person author3 = new Person("Juliusz", "Słowacki", 50);
                Reader reader1 = new Reader("Jan", "Kowalski", 30);
                Reader reader2 = new Reader("Anna", "Nowak", 25);
                Reader reader3 = new Reader("Piotr", "Zieliński", 40);
                Book book1 = new Book("Pan Tadeusz", author1, "1834");
                Book book2 = new Book("Quo Vadis", author2, "1896");
                Book book3 = new Book("Balladyna", author3, "1839");
                Book book4 = new Book("Lalka", new Person("Bolesław", "Prus", 65), "1890");
                Book book5 = new Book("Faraon", new Person("Bolesław", "Prus", 65), "1895");
                reader1.ReadBooks.Add(book1);
                reader1.ReadBooks.Add(book2);
                reader2.ReadBooks.Add(book3);
                reader2.ReadBooks.Add(book4);
                reader2.ReadBooks.Add(book5);
                reader3.ReadBooks.Add(book1);
                reader3.ReadBooks.Add(book3);
                reader1.ViewBooks();
                reader2.ViewBooks();
                reader3.ViewBooks();
            }
            public void Lab3Zadanie1cd()
            {
                Person author1 = new Person("Adam", "Mickiewicz", 56);
                Person author2 = new Person("Henryk", "Sienkiewicz", 60);
                Person author3 = new Person("Juliusz", "Słowacki", 50);
                Reader reader1 = new Reader("Jan", "Kowalski", 30);
                Reader reader2 = new Reader("Anna", "Nowak", 25);
                Reader reader3 = new Reader("Piotr", "Zieliński", 40);
                Book book1 = new Book("Pan Tadeusz", author1, "1834");
                Book book2 = new Book("Quo Vadis", author2, "1896");
                Book book3 = new Book("Balladyna", author3, "1839");
                Book book4 = new Book("Lalka", new Person("Bolesław", "Prus", 65), "1890");
                Book book5 = new Book("Faraon", new Person("Bolesław", "Prus", 65), "1895");
                reader1.ReadBooks.Add(book1);
                reader1.ReadBooks.Add(book2);
                reader2.ReadBooks.Add(book3);
                reader2.ReadBooks.Add(book4);
                reader2.ReadBooks.Add(book5);
                reader3.ReadBooks.Add(book1);
                reader3.ReadBooks.Add(book3);
                reader1.View();
                Console.WriteLine();
                reader2.View();
                Console.WriteLine();
                reader3.View();
                Console.WriteLine();
            }
            public void Lab3zadanie1f()
            {
                Person author1 = new Person("George", "Orwell", 71);
                Book book1 = new Book("1984", author1, "1949");
                Book book2 = new Book("Animal Farm", author1, "1945");

                Reviewer reviewer1 = new Reviewer("Anna", "Kowalska", 30);
                reviewer1.ReadBooks.Add(book1);
                reviewer1.ReadBooks.Add(book2);

                Reviewer reviewer2 = new Reviewer("Jan", "Nowak", 40);
                reviewer2.ReadBooks.Add(book1);
                reviewer2.ReadBooks.Add(book2);

                reviewer1.Wypisz();
                Console.WriteLine();
                Console.WriteLine();
                reviewer2.Wypisz();
                Console.WriteLine();
                Console.WriteLine();
            }
            public void Lab3Zadanie1g()
            {
                List<Person> persons = new List<Person>();

                Person author1 = new Person("George", "Orwell", 71);
                Book book1 = new Book("1984", author1, "1949");
                Book book2 = new Book("Animal Farm", author1, "1945");

                Reader reader1 = new Reader("Anna", "Kowalska", 30);
                reader1.ReadBooks.Add(book1);
                reader1.ReadBooks.Add(book2);

                Reviewer reviewer1 = new Reviewer("Jan", "Nowak", 40);
                reviewer1.ReadBooks.Add(book1);
                reviewer1.ReadBooks.Add(book2);

                persons.Add(reader1);
                persons.Add(reviewer1);

                foreach (Person person in persons)
                {
                    person.View();
                    Console.WriteLine();
                }
            }
            public void Lab3Zadanie1ij()
            {
                Person author1 = new Person("George", "Orwell", 71);
                Person author2 = new Person("J.K.", "Rowling", 59);
                AdventureBook book1 = new AdventureBook("The Hobbit", author2, "1937", "Średni");
                DocumentaryBook book2 = new DocumentaryBook("In Cold Blood", author1, "1966", "Biograficzny");

                Reader reader1 = new Reader("Anna", "Kowalska", 30);
                reader1.ReadBooks.Add(book1);
                reader1.ReadBooks.Add(book2);

                reader1.ViewDetailedBooks();
            }
        }
        public void Lab3Zadanie2()
        {
            Console.WriteLine("Tworzenie obiektu klasy SamochodOsobowy:");
            SamochodOsobowy osobowy = new SamochodOsobowy();

            Console.WriteLine("\nTworzenie obiektu klasy Samochod z domyślnego konstruktora:");
            Samochod samochod1 = new Samochod();

            Console.WriteLine("\nTworzenie obiektu klasy Samochod z konstruktora parametryzowanego:");
            Samochod samochod2 = new Samochod("Toyota", "Corolla", "Sedan", "Czarny", 2020, 45000);

            Console.WriteLine("\nInformacje o samochodach:");
            osobowy.WyswietlInformacje();
            samochod1.WyswietlInformacje();
            samochod2.WyswietlInformacje();
        }
    }
}
