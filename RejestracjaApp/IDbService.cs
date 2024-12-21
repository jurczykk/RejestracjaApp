using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejestracjaApp
{
    public interface IDbService
    {
        bool Zaloguj(Uzytkownik uzytkownik);    // Metoda logowania
        bool Zarejestruj(Uzytkownik uzytkownik); // Metoda rejestracji
    }

}
