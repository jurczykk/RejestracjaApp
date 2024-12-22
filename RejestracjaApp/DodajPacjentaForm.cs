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
    public partial class DodajPacjentaForm : MetroFramework.Forms.MetroForm
    {
        private readonly BazaDanych bazaDanych;

        public DodajPacjentaForm(BazaDanych bazaDanych)
        {
            this.bazaDanych = bazaDanych;
            InitializeComponent();
        }


        private void btnDodajPacjenta_Click(object sender, EventArgs e)
        {
            // Pobieramy dane z pól tekstowych
            string imie = txtImie.Text;
            string nazwisko = txtNazwisko.Text;
            string dataUrodzenia = txtDataUrodzenia.Text;
            string pesel = txtPesel.Text;

            // Tworzymy nowy obiekt Pacjent
            Pacjent pacjent = new Pacjent(imie, nazwisko, dataUrodzenia, pesel);

            // Dodajemy pacjenta do bazy danych
            if (bazaDanych.DodajPacjenta(pacjent))
            {
                MessageBox.Show("Pacjent został dodany pomyślnie!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nie udało się dodać pacjenta.");
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }






    }
}
