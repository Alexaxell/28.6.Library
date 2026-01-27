namespace _28._6.Library
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Matricola { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | Cognome: {Cognome} | Matricola: {Matricola}";
        }
    }
}