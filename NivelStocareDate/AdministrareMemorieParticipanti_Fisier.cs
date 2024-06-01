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
    public class AdministrareMemorieParticipanti_Fisier : IStocareDataParticipanti
    {
        private string numeFisierP;

        public AdministrareMemorieParticipanti_Fisier(string numeFisierP)
        {
            this.numeFisierP = numeFisierP;
            Stream streamFisierText = File.Open(numeFisierP, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

    

        public List<Participant> GetParticipanti()
        {
            List<Participant> participanti = new List<Participant>();
            using (StreamReader streamReader = new StreamReader(numeFisierP))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    participanti.Add(new Participant(linieFisier));
                }
            }

            return participanti;
        }
        
        public void AddParticipant(Participant participant)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisierP, true))
            {
                streamWriterFisierText.WriteLine(participant.ConversieLaSir_PentruFisier());
            }
        }

        public List<Participant> GetParticipantEveniment(string eveniment)
        {
            List<Participant> participanti = new List<Participant>();
            using (StreamReader streamReader = new StreamReader(numeFisierP))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Participant participant = new Participant(linieFisier);
                    if (participant.eveniment == eveniment)
                    {
                        participanti.Add(participant);
                    }
                }
            }
            return participanti;

            
        }
        public bool UpdateParticipant(Participant participantActualizat)
        {
            throw new Exception("Optiunea UpdateParticipant nu este implementata");
        }
    }
}
