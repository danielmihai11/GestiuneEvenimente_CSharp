using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele.Enumerari;

namespace LibrarieModele
{
   
    public class Eveniment
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';


       //private const int ID = 0;
        private const int DENUMIRE = 0;
        private const int DATA = 1;
        private const int LOCATIE = 2;
        private const int ORA = 3;
        private const int TIPEVENIMENT = 4;
       

        public string denumire { get; set; }

        public TipEveniment tip { get; set; }
        public string data { get; set; }
        public string locatie { get; set; }

        public string ora { get; set; }
       
       
      





        //Constructor fara parametri
        public Eveniment()
        {
            denumire = string.Empty;
            data = string.Empty;
            locatie = string.Empty;
            ora = string.Empty;
           
        }

        //Constructor cu parametri
        public Eveniment(string _denumire, string _data, string _locatie,string _ora)
        {
            denumire = _denumire;
            data = _data;
            locatie = _locatie;
            ora= _ora;
            


        }
        public string Info()
        {
            if (denumire == string.Empty)
                return $"EVENIMENT NEEXISTENT";
            else
                return $"Denumire: {denumire}\nData:{data}\nOra:{ora}\nLocatie:{locatie}\nTip eveniment: {tip}";


        }

        public Eveniment(string linieFisier)
        {

            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            ///this.id_eveniment = Convert.ToInt32(dateFisier[ID]);
            this.denumire = dateFisier[DENUMIRE];
            this.data = dateFisier[DATA];
            this.locatie = dateFisier[LOCATIE];
            this.ora = dateFisier[ORA];
            this.tip = (TipEveniment)Enum.Parse(typeof(TipEveniment), dateFisier[TIPEVENIMENT]);


        }
        public string ConversieLaSir_PentruFisierE()
        {
            string obiectEvenimentePentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                // id_eveniment.ToString(),
                (denumire ?? " NECUNOSCUT "),
                (data ?? "NECUNOSCUT"),
                (locatie ?? "NECUNOSCUT"),
                (ora ?? "NECUNOSCUT"),
                tip);

            return obiectEvenimentePentruFisier;
        }
    }
}