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
    public partial class FormAddCorso : Form
    {
        public FormAddCorso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listCorsi = new List<Corso>();

            while (string.IsNullOrWhiteSpace(txtNomeCorso.Text))
            {
                MessageBox.Show("Il nome del corso non può essere vuoto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("L'id del corso non può essere vuoto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (cbxStudenti.SelectedItem == null)
            {
                MessageBox.Show("Devi selezionare uno studente.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (cbxLezioni.SelectedItem == null)
            {
                MessageBox.Show("Devi selezionare una lezione.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listCorsi.Add(new Corso
            {
                Nome = txtNomeCorso.Text,
                Id = int.Parse(txtId.Text),
                Studenti = { (Studente)cbxStudenti.SelectedItem },
                Lezioni = { (Lezione)cbxLezioni.SelectedItem }
            });
        }

        private void btnAddStudente_Click(object sender, EventArgs e)
        {
            cbxStudenti.Text = cbxStudenti.SelectedItem.ToString();
        }

        private void btnAddLezione_Click(object sender, EventArgs e)
        {
            cbxLezioni.Text = cbxLezioni.SelectedItem.ToString();
        }
    }
}
