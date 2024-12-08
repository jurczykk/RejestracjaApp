using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejestracjaApp
{
    // Klasa reprezentująca użytkownika
    public class Uzytkownik
    {
        // Właściwości klasy
        public string Login { get; set; }
        public string Haslo { get; set; }

        // Konstruktor klasy Uzytkownik, który inicjalizuje login i hasło
        public Uzytkownik(string login, string haslo)
        {
            Login = login;
            Haslo = haslo;
        }
    }
}
