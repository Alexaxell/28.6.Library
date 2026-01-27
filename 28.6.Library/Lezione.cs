using System;

namespace _28._6.Library
{
    public class Lezione
    {
        public string Descrizione { get; set; }
        public DateTime Data { get; set; }
        public DateTime OrarioDiInizio { get; set; }
        public int Durata { get; set; }
        public Docente Docente { get; set; }
        public Aula Aula { get; set; }
        public int Presenti { get; set; }

        public int GetAssentiAllaLezione()
        {
            if (Presenti == Aula.Capienza)
                return Presenti;
            else if (Presenti < Aula.Capienza)
                return Aula.Capienza - Presenti;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"Descrizione: {Descrizione} | Data: {Data} | Orario di inizio: {OrarioDiInizio} | " +
                   $"Durata: {Durata} | Docente: {Docente} | Aula: {Aula} | Presenti: {Presenti}";
        }
    }
}