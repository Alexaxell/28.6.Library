using System.Collections.Generic;

namespace _28._6.Library
{
    public class Corso
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public List<Studente> Studenti { get; set; }
        public List<Lezione> Lezioni { get; set; }

        public void AddLezioniAlCorso(Lezione lezione)
        {
            Lezioni.Add(lezione);
        }

        public void AddStudentiAlCorso(Studente studente)
        {
            Studenti.Add(studente);
        }

        public override string ToString()
        {
            return $"Nome: {Nome} | Id: {Id} | Studenti: {Studenti} | Lezioni: {Lezioni}";
        }
    }
}