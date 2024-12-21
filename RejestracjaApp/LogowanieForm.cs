using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RejestracjaApp
{
    public partial class LogowanieForm : Form
    {

        public LogowanieForm()
        {
            InitializeComponent();
        }

        private void btnLogowanie_Click(object sender, EventArgs e)
        {

            // Pobranie danych wprowadzonych przez użytkownika
            string login = txtLogin.Text;
            string haslo = txtHaslo.Text;

            // Tworzenie obiektu użytkownika
            Uzytkownik uzytkownik = new Uzytkownik(login, haslo);

            // Tworzymy obiekt klasy BazaDanych
            BazaDanych baza = new BazaDanych();

            // Sprawdzanie poprawności danych logowania
            if (baza.Zaloguj(uzytkownik))
            {
                MessageBox.Show("Zalogowano pomyślnie!");
                this.Hide();

                // Otwieranie głównego okna aplikacji po zalogowaniu
                Form1 mainForm = new Form1();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Błędna nazwa użytkownika lub hasło.");
            }
        }


    }
}
