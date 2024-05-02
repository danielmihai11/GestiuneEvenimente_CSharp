using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;
using LibrarieModele.Enumerari;

namespace NivelStocareDate
{
    public class AdministrareMemorieParticipanti_Fisier
    {
        private const int NR_MAX_PARTICIPANTI = 50;
        private string numeFisierP;

        public AdministrareMemorieParticipanti_Fisier(string numeFisierP)
        {
            this.numeFisierP = numeFisierP;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisierP, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

    

        public Participant[] GetParticipanti(out int nrParticipanti)
        {
            Participant[] participanti = new Participant[NR_MAX_PARTICIPANTI];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisierP))
            {
                string linieFisier;
                nrParticipanti = 0;

                // citeste cate o linie si creaza un obiect de tip Participant
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    participanti[nrParticipanti++] = new Participant(linieFisier);
                }
            }

            return participanti;
        }
        /*public int GetLastId()
        {
            int lastID = 0;
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    lastID++;
                }
            }
            return lastID;
        }
        */
        public void AddParticipanti(Participant participant)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisierP, true))
            {
                streamWriterFisierText.WriteLine(participant.ConversieLaSir_PentruFisier());
            }
        }


        public Participant[] CautareDupaNume(string numeCautat)
        {
            List<Participant> participantiGasiti = new List<Participant>();

            // deschide fisierul si citeste fiecare linie
            using (StreamReader streamReader = new StreamReader(numeFisierP))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Participant participant = new Participant(linieFisier);
                    if (participant.nume == numeCautat)
                    {
                        // adauga evenimentul gasit in lista
                        participantiGasiti.Add(participant);
                    }
                }
            }

            // converteste lista de evenimente gasite in vector de evenimente si returneaza
            return participantiGasiti.ToArray();
        }

        public Participant[] CautareDupaPrenume(string prenumeCautat, int nrParticipanti)
        {
            List<Participant> participantiGasiti = new List<Participant>();

            // deschide fisierul si citeste fiecare linie
            using (StreamReader streamReader = new StreamReader(numeFisierP))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Participant participant = new Participant(linieFisier);
                    if (participant.prenume == prenumeCautat)
                    {
                        // adauga evenimentul gasit in lista
                        participantiGasiti.Add(participant);
                    }
                }
            }

            // converteste lista de evenimente gasite in vector de evenimente si returneaza
            return participantiGasiti.ToArray();
        }

        public Participant[] CautareDupaVarsta(int varstaCautata, int nrParticipanti)
        {
            List<Participant> participantiGasiti = new List<Participant>();

            // deschide fisierul si citeste fiecare linie
            using (StreamReader streamReader = new StreamReader(numeFisierP))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Participant participant = new Participant(linieFisier);
                    if (participant.varsta == varstaCautata)
                    {
                        // adauga evenimentul gasit in lista
                        participantiGasiti.Add(participant);
                    }
                }
            }

            // converteste lista de evenimente gasite in vector de evenimente si returneaza
            return participantiGasiti.ToArray();
        }

        public Participant[] CautareDupaEveniment(string evenimentCautat)
        {
            List<Participant> participantiGasiti = new List<Participant>();

            // deschide fisierul si citeste fiecare linie
            using (StreamReader streamReader = new StreamReader(numeFisierP))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Participant participant = new Participant(linieFisier);
                    if (participant.eveniment == evenimentCautat)
                    {
                        // adauga evenimentul gasit in lista
                        participantiGasiti.Add(participant);
                    }
                }
            }

            // converteste lista de evenimente gasite in vector de evenimente si returneaza
            return participantiGasiti.ToArray();
        }
    }
}
