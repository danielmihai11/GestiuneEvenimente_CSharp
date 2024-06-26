﻿using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelStocareDate
{
    public interface IStocareDataParticipanti
    {
        void AddParticipant(Participant participant);
        List<Participant> GetParticipanti();
        List<Participant> GetParticipantEveniment(string eveniment);
        bool UpdateParticipant(Participant p);

    }
}
