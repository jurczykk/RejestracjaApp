using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejestracjaApp
{
    public class Pacjent : Osoba
    {
        // Specyficzna właściwość dla pacjenta
        public string Pesel { get; set; }

        // Konstruktor klasy Pacjent, który wywołuje konstruktor klasy Osoba
        public Pacjent(string imie, string nazwisko, string dataUrodzenia, string pesel)
        : base(imie, nazwisko, dataUrodzenia)  // Przekazanie danych do konstruktora klasy bazowej (Osoba)
        {
            Pesel = pesel;
        }

        // Można dodać specyficzne metody dla pacjenta, np. wyświetlanie pełnych danych pacjenta
        public void WyswietlDanePacjenta()
        {
            WyswietlDane();  // Wywołanie metody z klasy bazowej Osoba
            Console.WriteLine($"PESEL: {Pesel}");
        }
    }
}
