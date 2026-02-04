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
    public partial class FormAddDocente : Form
    {
        public FormAddDocente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Il nome del docente non può essere vuoto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (string.IsNullOrWhiteSpace(txtCognome.Text))
            {
                MessageBox.Show("Il cognome del docente non può essere vuoto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (string.IsNullOrWhiteSpace(txtTitoloDiStudio.Text))
            {
                MessageBox.Show("L'email del docente non può essere vuota.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var docente = new Docente
            {
                Nome = txtNome.Text,
                Cognome = txtCognome.Text,
                TitoloDiStudio = txtTitoloDiStudio.Text
            };
        }
    }
}
