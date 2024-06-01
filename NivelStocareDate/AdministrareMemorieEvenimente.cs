using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareMemorieEvenimente : IStocareDataEvenimente
    {
        private List<Eveniment> evenimente;


        public AdministrareMemorieEvenimente()
        {
            evenimente = new List<Eveniment>();
        }

        public void AddEveniment(Eveniment eveniment)
        {
            evenimente.Add(eveniment);
        }

        public List<Eveniment> GetEvenimente()
        {
            return evenimente;
        }
        
        public List<Eveniment> GetEvenimentDenumire(string denumire)
        {
            throw new Exception("Optiunea GetEvenimentDenumire nu este implementata");
        }

        public List<Eveniment> GetEvenimentData(string data)
        {
            throw new Exception("Optiunea GetEvenimentData nu este implementata");
        }

        public List<Eveniment> GetEvenimentLocatie(string locatie)
        {
            throw new Exception("Optiunea GetEvenimentLocatie nu este implementata");
        }
        public void UpdateEveniment(Eveniment e)
        {
            throw new Exception("Optiunea UpdateEveniment nu este implementata");
        }
        public void StergeEveniment(string denumire)
        {
            throw new Exception("Optiunea StergeEveniment nu este implementata");
        }

        public List<Eveniment> GetEvenimentTip(string tip)
        {
            throw new Exception("Optiunea GetEveniment nu este implementata");
        }


    }
}
