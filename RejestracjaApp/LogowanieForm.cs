using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RejestracjaApp
{
    public partial class LogowanieForm : Form
    {

        // Przechowywanie nazwy użytkownika i hasła bezpośrednio w kodzie
        private string poprawnyLogin = "admin";
        private string poprawneHaslo = "admin";

        public LogowanieForm()
        {
            InitializeComponent();
        }

        private void btnLogowanie_Click(object sender, EventArgs e)
        {

            // Pobranie danych wprowadzonych przez użytkownika
            string nazwaUzytkownika = txtLogin.Text;
            string haslo = txtHaslo.Text;

            // Sprawdzanie poprawności danych logowania
            if (nazwaUzytkownika == poprawnyLogin && haslo == poprawneHaslo)
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
