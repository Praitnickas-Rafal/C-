using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace M.M_Va
{
    public partial class Form1 : Form
    {
        private List<string> listaDanych = new List<string>(); // utworzenie listy
        public Form1()
        {
            InitializeComponent();
        }
        private void groupRules_Enter(object sender, EventArgs e)
        {

        }

        private void InButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InTextBox.Text))
            {
                string tekst = InTextBox.Text; // pobranie tekstu z pola tekstowego
                listaDanych.Add(tekst); // dodanie tekstu do listy

                // wyczyszczenie pola tekstowego
                // wyświetlenie danych z listy w drugim polu tekstowym
                string tekstDoWyswietlenia = "";
                foreach (string dane in listaDanych)
                {
                    tekstDoWyswietlenia += dane + "\r\n"; // dodanie każdego elementu z listy i nowej linii
                }
                AlfabetTextBox.Text = tekstDoWyswietlenia;
            }
            else
            {
                MessageBox.Show("Proszę coś wpisać", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InTextBox.Clear();
        }

        private void InTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            AlfabetTextBox.Clear();
            listaDanych.Clear();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            bool error = false; // zmienna przechowująca informację o wystąpieniu błędu

            // Sprawdzenie wybranych reguł
            if (FirstCheck())
            {
                MessageBox.Show("Lista musi mieć dokładnie trzy elementy", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            if (SecondCheck())
            {
                MessageBox.Show("To nie jest Dana", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            if (ThirdCheck() && R1R2CheckBox.Checked)
            {
                MessageBox.Show("To nie jest Dana1", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            // Jeśli nie ma błędów, wykonaj pozostałe działania
            if (!error)
            {
                // kod, który ma być wykonany, jeśli nie ma błędów
            }
        }

        bool FirstCheck()
        {
           if (TrzyZnakoweCheckBox.Checked && listaDanych.Count != 3)
            {
                return true;
            }
           return false;
        }

        bool SecondCheck()
        {
           if (PierwszymZnakiemCheckBox.Checked && !listaDanych[0].StartsWith(listaDanych[1]))
            {
                return true;
            }
           return false;
        }
        bool ThirdCheck()
        {
            if(R1R2CheckBox.Checked && FirstCheck() && SecondCheck())
            {
                return true;
            }
            return false;
        }

        
    }
}
