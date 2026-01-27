using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _28._6.Library;

namespace _28._6.Library.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            GestoreCorsi gestoreCorsi = new GestoreCorsi
            {
                Corsi = new List<Corso>
                {
                    new Corso()
                    {
                        Id = 1,
                        Nome = "Corso di Informatica",
                        Lezioni = new List<Lezione>()
                        {
                            new Lezione()
                            {
                                Descrizione = "Hardware e Software",
                                Docente = new Docente()
                                {
                                    Nome = "Mario",
                                    Cognome = "Rossi",
                                    TitoloDiStudio = "Informatica"
                                },
                                Data = new DateTime(2024, 6, 1),
                                OrarioDiInizio = new DateTime(DateTime.Today.Hour),
                                Durata = 2,
                                Aula = new Aula()
                                {
                                    Capienza = 30,
                                    Nome = "Aula di informatica",
                                    Risorse = new List<string>()
                                    {
                                        "Computer",
                                        "Virtual Machine",
                                        "Visual Studio",
                                        "Excel"
                                    }
                                },
                                Presenti = 24
                            },
                            new Lezione()
                            {
                                Descrizione = "Sistemi e reti",
                                Docente = new Docente()
                                {
                                    Nome = "Luigi",
                                    Cognome = "Bianchi",
                                    TitoloDiStudio = "Informatica"
                                },
                                Data = new DateTime(2024, 6, 3),
                                OrarioDiInizio = new DateTime(DateTime.Today.Hour),
                                Durata = 2,
                                Aula = new Aula()
                                {
                                    Capienza = 30,
                                    Nome = "Aula di informatica",
                                    Risorse = new List<string>()
                                    {
                                        "Computer",
                                        "Virtual Machine",
                                        "Visual Studio",
                                        "Excel"
                                    }
                                },
                                Presenti = 22
                            }
                        },
                        Studenti = new List<Studente>()
                        {
                            new Studente() { Nome = "Luca", Cognome = "Bianchi", Matricola = 11111 },
                            new Studente() { Nome = "Giulia", Cognome = "Verdi", Matricola = 22222 }
                        }
                    },
                    new Corso()
                    {
                        Id = 1,
                        Nome = "Corso di lingue",
                        Lezioni = new List<Lezione>()
                        {
                            new Lezione()
                            {
                                Descrizione = "Inglese",
                                Docente = new Docente()
                                {
                                    Nome = "Giuseppe",
                                    Cognome = "Verdi",
                                    TitoloDiStudio = "Lingue"
                                },
                                Data = new DateTime(2024, 6, 1),
                                OrarioDiInizio = new DateTime(DateTime.Today.Hour),
                                Durata = 2,
                                Aula = new Aula()
                                {
                                    Capienza = 30,
                                    Nome = "Madrelingua inglese",
                                    Risorse = new List<string>()
                                    {
                                        "Libri",
                                        "Vocabolari",
                                        "Tablet",
                                        "Lim"
                                    }
                                },
                                Presenti = 26
                            },
                            new Lezione()
                            {
                                Descrizione = "Spagnolo",
                                Docente = new Docente()
                                {
                                    Nome = "Ciro",
                                    Cognome = "Esposito",
                                    TitoloDiStudio = "Lingue"
                                },
                                Data = new DateTime(2024, 6, 3),
                                OrarioDiInizio = new DateTime(DateTime.Today.Hour),
                                Durata = 2,
                                Aula = new Aula()
                                {
                                    Capienza = 30,
                                    Nome = "Madrelingua spagnolo",
                                    Risorse = new List<string>()
                                    {
                                        "Libri",
                                        "Vocabolari",
                                        "Tablet",
                                        "Lim"
                                    }
                                },
                                Presenti = 20
                            }
                        },
                        Studenti = new List<Studente>()
                        {
                            new Studente() { Nome = "Marco", Cognome = "Ferrari", Matricola = 33333 },
                            new Studente() { Nome = "Sara", Cognome = "Fabbri", Matricola = 44444 }
                        }
                    }
                }
            };

            string scelta;
            string corsoInput = null;
            Corso corsoScelto = null;
            string lezioneInput = null;
            Lezione lezioneScelta = null;
            int presentiTotali = 0;

            while (true)
            {
                System.Console.WriteLine("1. Elenco corsi.");
                System.Console.WriteLine("2. Elenco lezioni di un corso.");
                System.Console.WriteLine("3. Elenco iscritti ad un corso.");
                System.Console.WriteLine("4. Scheda riassuntiva di una lezione.");
                System.Console.WriteLine("5. Elenco presenti ad una lezione");
                // System.Console.WriteLine("6. Media Presenti ad una lezione.");
                System.Console.WriteLine("7. Media presenti ad un corso.");

                scelta = System.Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        foreach (var corso in gestoreCorsi.Corsi)
                        {
                            System.Console.WriteLine(corso);
                        }
                        break;
                    case "2":
                        while (string.IsNullOrWhiteSpace(corsoInput))
                        {
                            System.Console.WriteLine("Inserisci il nome del corso: ");
                            corsoInput = System.Console.ReadLine();
                        }

                        foreach (var corso in gestoreCorsi.Corsi)
                        {
                            if (corsoInput == corso.Nome)
                                corsoScelto = corso;
                            else
                                System.Console.WriteLine("Il corso non esiste");
                        }

                        foreach (var lezione in corsoScelto.Lezioni)
                        {
                            System.Console.WriteLine(lezione);
                        }
                        break;
                    case "3":
                        while (string.IsNullOrWhiteSpace(corsoInput))
                        {
                            System.Console.WriteLine("Inserisci il nome del corso: ");
                            corsoInput = System.Console.ReadLine();
                        }

                        foreach (var corso in gestoreCorsi.Corsi)
                        {
                            if (corsoInput == corso.Nome)
                                corsoScelto = corso;
                            else
                                System.Console.WriteLine("Il corso non esiste");
                        }

                        foreach (var iscritti in corsoScelto.Studenti)
                        {
                            System.Console.WriteLine(iscritti);
                        }
                        break;
                    case "4":
                        while (string.IsNullOrWhiteSpace(lezioneInput))
                        {
                            System.Console.WriteLine("Inserisci il nome della lezione: ");
                            lezioneInput = System.Console.ReadLine();
                        }

                        foreach (var corso in gestoreCorsi.Corsi)
                        {
                            foreach (var lezione in corso.Lezioni)
                            {
                                if (lezione.Descrizione == lezioneInput)
                                    System.Console.WriteLine(lezione);
                                else
                                    System.Console.WriteLine("La lezione inserita non esiste.");
                            }
                        }
                        break;
                    case "5":
                        while (string.IsNullOrWhiteSpace(lezioneInput))
                        {
                            System.Console.WriteLine("Inserisci il nome del corso: ");
                            lezioneInput = System.Console.ReadLine();
                        }

                        foreach (var corso in gestoreCorsi.Corsi)
                        {
                            foreach (var lezione in corso.Lezioni)
                            {
                                if (lezione.Descrizione == lezioneInput)
                                    System.Console.WriteLine(lezione.Presenti);
                                else
                                    System.Console.WriteLine("La lezione inserita non esiste.");
                            }
                        }
                        break;
                    case "6":
                        break;
                    case "7":
                        while (string.IsNullOrWhiteSpace(corsoInput))
                        {
                            System.Console.WriteLine("Inserisci il nome del corso: ");
                            corsoInput = System.Console.ReadLine();
                        }

                        foreach (var corso in gestoreCorsi.Corsi)
                        {
                            if (corsoInput == corso.Nome)
                                corsoScelto = corso;
                            else
                                System.Console.WriteLine("Il corso non esiste");
                        }

                        foreach (var lezione in corsoScelto.Lezioni)
                        {
                            presentiTotali += lezione.Presenti;
                        }

                        System.Console.WriteLine(presentiTotali.ToString());
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
