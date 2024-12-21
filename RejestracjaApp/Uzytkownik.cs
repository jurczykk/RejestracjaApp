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
        public string Login { get; set; }
        public string Haslo { get; set; }

        // Konstruktor, który inicjalizuje użytkownika
        public Uzytkownik(string login, string haslo)
        {
            Login = login;
            Haslo = haslo;
        }
    }


}
