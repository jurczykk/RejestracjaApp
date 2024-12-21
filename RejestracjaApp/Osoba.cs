using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejestracjaApp
{
    public class Osoba
    {
        // Wspólne właściwości dla wszystkich osób
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string DataUrodzenia { get; set; }

        // Konstruktor klasy Osoba
        public Osoba(string imie, string nazwisko, string dataUrodzenia)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            DataUrodzenia = dataUrodzenia;
        }

        // Przykładowa metoda wspólna, która może być użyta przez klasy dziedziczące
        public void WyswietlDane()
        {
            Console.WriteLine($"Imię: {Imie}, Nazwisko: {Nazwisko}, Data Urodzenia: {DataUrodzenia}");
        }
    }
}
