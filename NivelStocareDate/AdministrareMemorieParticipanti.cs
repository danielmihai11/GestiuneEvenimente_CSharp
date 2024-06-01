using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareMemorieParticipanti : IStocareDataParticipanti
    {


        private List<Participant> participanti;

        public AdministrareMemorieParticipanti()
        {
            participanti = new List<Participant>();
        }

        public void AddParticipant(Participant participant)
        {
            participanti.Add(participant);
        }
      
        public List<Participant> GetParticipanti()
        {
            return participanti;
        }

        public List<Participant> GetParticipantEveniment(string eveniment)
        {
            throw new Exception("Optiunea GetParticipantEveniment nu este implementata");
        }

        public bool UpdateParticipant(Participant p)
        {
            throw new Exception("Optiunea UpdateParticipant nu este implementata");
        }


    }

        
    
}