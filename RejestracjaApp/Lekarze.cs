using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejestracjaApp
{
    public class Lekarze : Osoba
    {
        // Specyficzna właściwość dla lekarza
        public string Specjalizacja { get; set; }

        // Konstruktor klasy Lekarz, który wywołuje konstruktor klasy Osoba
        public Lekarze(string imie, string nazwisko, string dataUrodzenia, string specjalizacja)
        : base(imie, nazwisko, dataUrodzenia)  // Przekazanie danych do konstruktora klasy bazowej (Osoba)
        {
            Specjalizacja = specjalizacja;
        }

        // Można dodać specyficzne metody dla lekarza, np. wyświetlanie pełnych danych lekarza
        public void WyswietlDaneLekarza()
        {
            WyswietlDane();  // Wywołanie metody z klasy bazowej Osoba
            Console.WriteLine($"Specjalizacja: {Specjalizacja}");
        }
    }
}
