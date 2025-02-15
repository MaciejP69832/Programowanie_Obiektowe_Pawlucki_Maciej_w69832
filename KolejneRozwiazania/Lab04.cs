using System;
using System.Collections.Generic;
using System.Linq;
using static Programowanie_obiektowe_w69832.Lab04;

namespace Programowanie_obiektowe_w69832
{
    public static class ListaOsobExtensions
    {
        public static void WypiszOsoby(this List<IOsoba> lista)
        {
            foreach (var osoba in lista)
            {
                Console.WriteLine(osoba.ZwrocPelnaNazwe());
            }
        }

        public static void PosortujOsobyPoNazwisku(this List<IOsoba> lista)
        {
            lista.Sort((x, y) => string.Compare(x.Nazwisko, y.Nazwisko));
        }
    }
    public class Lab04
    {
        public class Shape
        {
            public int X
            {
                get;
                set;
            }
            public int Y
            {
                get;
                set;
            }
            public int Height
            {
                get;
                set;
            }
            public int Width
            {
                get;
                set;
            }
            public virtual void Draw()
            {
                Console.WriteLine("Rysowanie figury");
            }
        }
        public class Triangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Rysowanie trójkąta");
            }
        }
        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Rysowanie koła");
            }
        }
        public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Rysowanie prostokąta");
            }
        }
        public abstract class Osoba
        {
            public string Imie
            {
                get;
                set;
            }
            public string Nazwisko
            {
                get;
                set;
            }
            public string Pesel
            {
                get;
                set;
            }

            public void SetFirstName(string imie) => Imie = imie;
            public void SetLastName(string nazwisko) => Nazwisko = nazwisko;
            public void SetPesel(string pesel) => Pesel = pesel;

            public int GetAge()
            {
                int rok = int.Parse(Pesel.Substring(0, 2));
                int miesiac = int.Parse(Pesel.Substring(2, 2));

                if (miesiac > 20) rok += 2000;
                else rok += 1900;

                return DateTime.Now.Year - rok;
            }

            public string GetGender()
            {
                int genderDigit = int.Parse(Pesel[9].ToString());
                return (genderDigit % 2 == 0) ? "Kobieta" : "Mężczyzna";
            }

            public abstract string GetEducationInfo();
            public abstract string GetFullName();
            public abstract bool CanGoAloneToHome();
        }
        public class Uczen : Osoba
        {
            public string Szkola
            {
                get;
                set;
            }
            public bool MozeSamWracacDoDomu
            {
                get;
                set;
            }

            public void SetSchool(string szkola) => Szkola = szkola;
            public void ChangeSchool(string nowaSzkola) => Szkola = nowaSzkola;
            public void SetCanGoHomeAlone(bool canGoHome) => MozeSamWracacDoDomu = canGoHome;

            public override string GetEducationInfo() => $"Uczeń szkoły: {Szkola}";

            public override string GetFullName() => $"{Imie} {Nazwisko}";

            public override bool CanGoAloneToHome() => GetAge() >= 12 || MozeSamWracacDoDomu;
        }
        public class Nauczyciel : Uczen
        {
            public string TytulNaukowy
            {
                get;
                set;
            }
            public List<Uczen> PodwladniUczniowie
            {
                get;
                set;
            } = new List<Uczen>();

            public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
            {
                Console.WriteLine("Uczniowie mogący samodzielnie wracać do domu:");
                foreach (var uczen in PodwladniUczniowie)
                {
                    if (uczen.CanGoAloneToHome())
                    {
                        Console.WriteLine(uczen.GetFullName());
                    }
                }
            }
        }

        public interface IOsoba
        {
            string Imie
            {
                get;
                set;
            }
            string Nazwisko
            {
                get;
                set;
            }
            string ZwrocPelnaNazwe();
        }

        public class Osobaa : IOsoba
        {
            public string Imie
            {
                get;
                set;
            }
            public string Nazwisko
            {
                get;
                set;
            }

            public string ZwrocPelnaNazwe() => $"{Imie} {Nazwisko}";
        }

        

        public interface IStudent : IOsoba
        {
            string Uczelnia
            {
                get;
                set;
            }
            string Kierunek
            {
                get;
                set;
            }
            int Rok
            {
                get;
                set;
            }
            int Semestr
            {
                get;
                set;
            }
            string WypiszPelnaNazweIUczelnie();
        }

        public class Student : IStudent
        {
            public string Imie
            {
                get;
                set;
            }
            public string Nazwisko
            {
                get;
                set;
            }
            public string Uczelnia
            {
                get;
                set;
            }
            public string Kierunek
            {
                get;
                set;
            }
            public int Rok
            {
                get;
                set;
            }
            public int Semestr
            {
                get;
                set;
            }

            public string ZwrocPelnaNazwe() => $"{Imie} {Nazwisko}";
            public string WypiszPelnaNazweIUczelnie() => $"{Imie} {Nazwisko} - {Semestr}{Kierunek} {Rok} {Uczelnia}";
        }

        public class StudentWSIiZ : Student { }

        public void Lab4Menu()
        {
            while (true)
            {
                Console.WriteLine("Lab 4 - wybierz zadanie do uruchomienia.");
                Console.WriteLine("1. Zadanie 1.");
                Console.WriteLine("2. Zadanie 2.");
                Console.WriteLine("3. Zadanie 3.");
                Console.WriteLine("0. Powrót.");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Lab4Zadanie1();
                        break;
                    case "2":
                        Lab4Zadanie2();
                        break;
                    case "3":
                        Lab4Zadanie3();
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
        public void Lab4Zadanie1()
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rectangle
            {
                X = 10,
                Y = 10,
                Height = 5,
                Width = 7
            });
            shapes.Add(new Triangle
            {
                X = 15,
                Y = 20,
                Height = 6,
                Width = 8
            });
            shapes.Add(new Circle
            {
                X = 20,
                Y = 25,
                Height = 4,
                Width = 4
            });
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
        static void Lab4Zadanie2()
        {

            Uczen uczen1 = new Uczen
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Pesel = "09123112345",
                Szkola = "SP1",
                MozeSamWracacDoDomu = false
            };
            Uczen uczen2 = new Uczen
            {
                Imie = "Anna",
                Nazwisko = "Nowak",
                Pesel = "11051267890",
                Szkola = "SP1",
                MozeSamWracacDoDomu = true
            };

            Nauczyciel nauczyciel = new Nauczyciel
            {
                Imie = "Piotr",
                Nazwisko = "Wiśniewski",
                Pesel = "85010134567",
                TytulNaukowy = "Magister"
            };
            nauczyciel.PodwladniUczniowie.Add(uczen1);
            nauczyciel.PodwladniUczniowie.Add(uczen2);

            nauczyciel.WhichStudentCanGoHomeAlone(DateTime.Now);
        }
        static void Lab4Zadanie3()
        {
            List<IOsoba> osoby = new List<IOsoba> {
        new Osobaa {
          Imie = "Jan",
          Nazwisko = "Kowalski"
        },
        new Osobaa {
          Imie = "Anna",
          Nazwisko = "Nowak"
        }
      };

            osoby.WypiszOsoby();
            osoby.PosortujOsobyPoNazwisku();
            osoby.WypiszOsoby();

            List<IStudent> studenci = new List<IStudent> {
        new StudentWSIiZ {
          Imie = "Piotr",
          Nazwisko = "Wiśniewski",
          Uczelnia = "WSIiZ",
          Kierunek = "IID-P",
          Rok = 2018,
          Semestr = 4
        },
        new StudentWSIiZ {
          Imie = "Karolina",
          Nazwisko = "Nowak",
          Uczelnia = "WSIiZ",
          Kierunek = "IT",
          Rok = 2019,
          Semestr = 3
        }
      };

            foreach (var student in studenci)
            {
                Console.WriteLine(student.WypiszPelnaNazweIUczelnie());
            }
        }
    }
}