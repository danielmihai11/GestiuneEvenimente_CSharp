using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareMemorieEvenimente
    {
        private const int NR_MAX_EVENIMENTE = 100;

        private Eveniment[] evenimente;
        private int nrEvenimente;

        public AdministrareMemorieEvenimente()
        {
            evenimente = new Eveniment[NR_MAX_EVENIMENTE];
            nrEvenimente = 0;
        }

        public void AddEvenimente(Eveniment eveniment)
        {
            evenimente[nrEvenimente] = eveniment;
            nrEvenimente++;
        }

        public Eveniment[] GetEvenimente(out int nrEvenimente)
        {
            nrEvenimente = this.nrEvenimente;
            return evenimente;
        }
    }
}