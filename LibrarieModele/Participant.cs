using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele.Enumerari;

namespace LibrarieModele
{

    
    public class Participant
    {

        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int NUME = 0;
        private const int PRENUME = 1;
        private const int VARSTA = 2;
        private const int EVENIMENT = 3;


        public string nume { get; set; }
        public string prenume { get; set; }
        public string eveniment { get; set; }
        public int varsta { get; set; }
      
     

        public Participant()
        {
            nume = string.Empty;
            prenume = string.Empty;
            eveniment = string.Empty;
            varsta = 0;

        }

       
        public Participant(string _nume, string _prenume, int _varsta, string _eveniment)
        {
            nume = _nume;
            prenume = _prenume;
            varsta = _varsta;
            eveniment = _eveniment;

        }


        public Participant(string linieFisier)
        {

            var dateFisier1 = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            this.nume = dateFisier1[NUME];
            this.prenume = dateFisier1[PRENUME];
            this.varsta = Convert.ToInt32(dateFisier1[VARSTA]);
            this.eveniment = dateFisier1[EVENIMENT];
        }


        public string Major_Minor()
        {
            if (varsta == 0)
                return "Varsta participantului nu a fost setata";
            if (varsta < 18)
                return "Participantul este minor!";
            return "Participantul este major";


        }

        public string GetVarstaAsString()
        {
            string sVarsta = string.Empty;
            if (varsta != null)
            {
                sVarsta = string.Join(SEPARATOR_PRINCIPAL_FISIER.ToString(), varsta);
            }
            return sVarsta;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectParticipantiPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                (nume ?? " NECUNOSCUT "),
                (prenume ?? "NECUNOSCUT"),
                (varsta.ToString() ?? " NECUNOSCUT "),
                (eveniment ?? "NECUNOSCUT"));

            return obiectParticipantiPentruFisier;
        }
   
        public string Info()
        {
            if (nume == string.Empty)
                return $"PARTICIPANT NEEXISTENT";
            else
                return $"Nume:{nume}\nPrenume:{prenume}\nVarsta:{varsta}\nEveniment:{eveniment}\n";


        }
        public override string ToString()
        {
            return Info();
        }


    }
}