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
    public partial class Form1 : Form
    {

        private readonly BazaDanych bazaDanych;

        public Form1()
        {
            InitializeComponent();
            bazaDanych = new BazaDanych(); // Tworzymy instancję BazaDanych

        }

        private void btnOtworzDodajPacjentaForm_Click(object sender, EventArgs e)
        {
            // Otwieramy formularz DodajPacjentaForm
            DodajPacjentaForm dodajPacjentaForm = new DodajPacjentaForm(bazaDanych);
            dodajPacjentaForm.ShowDialog();

        }


        private void btnSzukajPacjenta_Click(object sender, EventArgs e)
        {
            string nazwisko = txtSzukajNazwisko.Text; // Pobranie nazwiska z pola tekstowego

            // Wyszukaj pacjenta w bazie danych po nazwisku
            Pacjent pacjent = bazaDanych.WyszukajPacjentaPoNazwisku(nazwisko);

            if (pacjent != null)
            {
                // Jeśli pacjent został znaleziony, wyświetl dane
                MessageBox.Show($"Znaleziono pacjenta:\n\nImię: {pacjent.Imie}\nNazwisko: {pacjent.Nazwisko}\nData Urodzenia: {pacjent.DataUrodzenia}\nPesel: {pacjent.Pesel}");
            }
            else
            {
                // Jeśli pacjent nie został znaleziony
                MessageBox.Show("Pacjent o podanym nazwisku nie został znaleziony.");
            }
        }




        //Szukanie lekarzy po specjalizacji
        private void btnSzukajLekarzy_Click(object sender, EventArgs e)
        {
            // Pobierz specjalizację z pola tekstowego
            string specjalizacja = txtSpecjalizacja.Text;

            if (string.IsNullOrWhiteSpace(specjalizacja))
            {
                MessageBox.Show("Proszę podać specjalizację.");
                return;
            }

            // Wywołaj funkcję wyszukiwania lekarzy z bazy danych
            List<Lekarze> lekarze = bazaDanych.WyszukajLekarzyPoSpecjalizacji(specjalizacja);

            if (lekarze.Count > 0)
            {
                // Jeśli znaleziono lekarzy, przygotuj tekst do wyświetlenia
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Znaleziono {lekarze.Count} lekarzy o specjalizacji '{specjalizacja}':\n");

                foreach (var lekarz in lekarze)
                {
                    sb.AppendLine($"Imię: {lekarz.Imie}, Nazwisko: {lekarz.Nazwisko}");
                }

                MessageBox.Show(sb.ToString(), "Wyniki wyszukiwania");
            }
            else
            {
                // Jeśli nie znaleziono lekarzy
                MessageBox.Show($"Nie znaleziono lekarzy o specjalizacji '{specjalizacja}'.");
            }
        }







        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
