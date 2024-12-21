using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;


namespace RejestracjaApp
{
    public class BazaDanych
    {
        // Ścieżka do bazy danych
        private string connectionString = "Data Source=Uzytkownicy.db;Version=3;";





        // Funkcja logowania użytkownika
        public bool Zaloguj(Uzytkownik uzytkownik)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Zapytanie SQL sprawdzające login i hasło
                    string query = "SELECT COUNT(1) FROM Uzytkownicy WHERE Login = @login AND Haslo = @haslo";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", uzytkownik.Login);
                        command.Parameters.AddWithValue("@haslo", uzytkownik.Haslo);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count == 1; // Zwraca true, jeśli użytkownik istnieje
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas logowania: {ex.Message}");
                return false;
            }
        }

        // Funkcja rejestracji nowego użytkownika
        public bool Zarejestruj(Uzytkownik uzytkownik)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Uzytkownicy (Login, Haslo) VALUES (@login, @haslo)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", uzytkownik.Login);
                        command.Parameters.AddWithValue("@haslo", uzytkownik.Haslo);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // Zwraca true, jeśli użytkownik został dodany
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas rejestracji: {ex.Message}");
                return false;
            }
        }

        // Funkcja dodawania nowego pacjenta
        public bool DodajPacjenta(Pacjent pacjent)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Pacjenci (Imie, Nazwisko, DataUrodzenia, Pesel) VALUES (@imie, @nazwisko, @dataUrodzenia, @pesel)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@imie", pacjent.Imie);
                        command.Parameters.AddWithValue("@nazwisko", pacjent.Nazwisko);
                        command.Parameters.AddWithValue("@dataUrodzenia", pacjent.DataUrodzenia);
                        command.Parameters.AddWithValue("@pesel", pacjent.Pesel);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // Zwraca true, jeśli pacjent został dodany
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas dodawania pacjenta: {ex.Message}");
                return false;
            }
        }


        // Funkcja pobierania listy pacjentów
        public List<Pacjent> PobierzPacjentow()
        {
            List<Pacjent> pacjenci = new List<Pacjent>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Imie, Nazwisko, DataUrodzenia, Pesel FROM Pacjenci";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Pacjent pacjent = new Pacjent(
                                    reader["Imie"].ToString(),
                                    reader["Nazwisko"].ToString(),
                                    reader["DataUrodzenia"].ToString(),
                                    reader["Pesel"].ToString()
                                );
                                pacjenci.Add(pacjent);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas pobierania pacjentów: {ex.Message}");
            }

            return pacjenci;
        }



        // Funkcja wyszukiwania pacjenta po nazwisku
        public Pacjent WyszukajPacjentaPoNazwisku(string nazwisko)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Zapytanie SQL, które wyszukuje pacjenta po nazwisku
                    string query = "SELECT * FROM Pacjenci WHERE Nazwisko = @nazwisko";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nazwisko", nazwisko);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Jeśli pacjent został znaleziony
                            {
                                // Tworzymy obiekt pacjenta i przekazujemy dane do konstruktora klasy Pacjent
                                Pacjent pacjent = new Pacjent(
                                    reader["Imie"].ToString(),
                                    reader["Nazwisko"].ToString(),
                                    reader["DataUrodzenia"].ToString(),
                                    reader["Pesel"].ToString() // Pesel to specyficzne dla pacjenta
                                );
                                return pacjent;
                            }
                            else
                            {
                                return null; // Pacjent nie znaleziony
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas wyszukiwania pacjenta: {ex.Message}");
                return null;
            }
        }


        // Funkcja wyszukiwania lekarza po specjalizacji
        public List<Lekarze> WyszukajLekarzyPoSpecjalizacji(string specjalizacja)
        {
            List<Lekarze> lekarze = new List<Lekarze>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Zapytanie SQL, które wyszukuje lekarzy po specjalizacji
                    string query = "SELECT * FROM Lekarze WHERE Specjalizacja = @specjalizacja";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@specjalizacja", specjalizacja);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read()) // Iterujemy przez wszystkich lekarzy o danej specjalizacji
                            {
                                Lekarze lekarz = new Lekarze(
                                    reader["Imie"].ToString(),
                                    reader["Nazwisko"].ToString(),
                                    reader["DataUrodzenia"].ToString(),
                                    reader["Specjalizacja"].ToString() // Specjalizacja to specyficzne dla lekarza
                                );
                                lekarze.Add(lekarz);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas wyszukiwania lekarzy: {ex.Message}");
            }

            return lekarze; // Zwracamy listę znalezionych lekarzy
        }




    }
}
