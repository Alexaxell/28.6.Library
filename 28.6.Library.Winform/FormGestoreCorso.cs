namespace _28._6.Library.Winform
{
    public partial class FormGestoreCorso : Form
    {
        public FormGestoreCorso()
        {
            InitializeComponent();
        }

        private void btnAddCorso_Click(object sender, EventArgs e)
        {
            var formAddCorso = new FormAddCorso();
            formAddCorso.ShowDialog();
        }

        private void btnAddLezioniAlCorso_Click(object sender, EventArgs e)
        {
            var formAddLezioniAlCorso = new FormAddLezionialCorso();
            formAddLezioniAlCorso.ShowDialog();
        }

        private void btnAddStudentiAlCorso_Click(object sender, EventArgs e)
        {
            var formAddStudentiAlCorso = new FormAddStudentiAlCorso();
            formAddStudentiAlCorso.ShowDialog();
        }

        private void btnGetAssentiAllaLezione_Click(object sender, EventArgs e)
        {
            var formGetAssentiAllaLezione = new FormGetAssentiAllaLezione();
            formGetAssentiAllaLezione.ShowDialog();
        }
    }
}
