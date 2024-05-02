using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareMemorieParticipanti
    {
        private const int NR_MAX_PARTICIPANTI = 50;

        private Participant[] participanti;
        private int nrParticipanti;

        public AdministrareMemorieParticipanti()
        {
            participanti = new Participant[NR_MAX_PARTICIPANTI];
            nrParticipanti = 0;
        }

        public void AddParticipanti(Participant participant)
        {
            participanti[nrParticipanti] = participant;
            nrParticipanti++;
        }

        public Participant[] GetParticipanti(out int nrParticipanti)
        {
            nrParticipanti = this.nrParticipanti;
            return participanti;
        }

        
    }
}