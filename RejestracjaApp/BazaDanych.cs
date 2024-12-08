using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace RejestracjaApp
{
    public class BazaDanych
    {
        // Ścieżka do bazy danych
        private string connectionString = "Data Source=Uzytkownicy.db;Version=3;";


        // Funkcja logowania użytkownika
        public bool Zaloguj(Uzytkownik uzytkownik)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Zapytanie SQL w celu pobrania hasła na podstawie loginu
                string query = "SELECT Haslo FROM Uzytkownicy WHERE Login = @login";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@login", uzytkownik.Login);

                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Porównanie wprowadzonego hasła z tym w bazie
                    string storedHaslo = reader["Haslo"].ToString();
                    return storedHaslo == uzytkownik.Haslo;
                }
                return false;
            }
        }

        // Funkcja rejestracji nowego użytkownika
        public bool Zarejestruj(Uzytkownik uzytkownik)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Sprawdzenie, czy użytkownik o tym loginie już istnieje
                string query = "SELECT COUNT(*) FROM Uzytkownicy WHERE Login = @login";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@login", uzytkownik.Login);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    return false; // Użytkownik już istnieje
                }

                // Jeśli użytkownik nie istnieje, wykonujemy zapytanie INSERT
                query = "INSERT INTO Uzytkownicy (Login, Haslo) VALUES (@login, @haslo)";
                cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@login", uzytkownik.Login);
                cmd.Parameters.AddWithValue("@haslo", uzytkownik.Haslo); // Dodajemy nowe hasło do bazy
                cmd.ExecuteNonQuery();

                return true; // Zarejestrowano nowego użytkownika
            }
        }
    }


}
