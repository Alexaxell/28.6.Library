using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28._6.Library.Winform
{
    public partial class FormAddLezionialCorso : Form
    {
        public FormAddLezionialCorso()
        {
            InitializeComponent();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            var formoAddDocente = new FormAddDocente();
            formoAddDocente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formAddAula = new FormAddAula();
            formAddAula.ShowDialog();
        }

        private void btnAddLezione_Click(object sender, EventArgs e)
        {
            var listaLezioni = new List<Lezione>();

            while (string.IsNullOrWhiteSpace(txtDescrizione.Text))
            {
                MessageBox.Show("La descrizione non può essere vuota.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (string.IsNullOrWhiteSpace(txtOrarioDiInizio.Text))
            {
                MessageBox.Show("L'orario di inizio non può essere vuoto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (string.IsNullOrWhiteSpace(txtDurata.Text))
            {
                MessageBox.Show("La durata non può essere vuota.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (string.IsNullOrWhiteSpace(txtDocente.Text))
            {
                MessageBox.Show("Il docente non può essere vuoto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (string.IsNullOrWhiteSpace(txtAula.Text))
            {
                MessageBox.Show("L'aula non può essere vuota.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (string.IsNullOrWhiteSpace(txtPresenti.Text))
            {
                MessageBox.Show("I presenti non possono essere vuoti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listaLezioni.Add(new Lezione
            {
                Descrizione = txtDescrizione.Text,
                Data = dtpData.Value,
                OrarioDiInizio = DateTime.Parse(txtOrarioDiInizio.Text),
                Durata = int.Parse(txtDurata.Text),
                Docente = new Docente { Nome = txtDocente.Text },
                Aula = new Aula { Nome = txtAula.Text },
                Presenti = int.Parse(txtPresenti.Text)
            });
        }
    }
}
