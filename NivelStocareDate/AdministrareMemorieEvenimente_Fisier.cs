using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;

namespace NivelStocareDate
{
    public class AdministrareMemorieEvenimente_Fisier : IStocareDataEvenimente
    {
        private string numeFisierE;

        public AdministrareMemorieEvenimente_Fisier(string numeFisierE)
        {
            this.numeFisierE = numeFisierE;
            Stream streamFisierText = File.Open(numeFisierE, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public List<Eveniment> GetEvenimente()
        {
            List<Eveniment> evenimente = new List<Eveniment>();

           
            using (StreamReader streamReader = new StreamReader(numeFisierE))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    evenimente.Add(new Eveniment(linieFisier));
                   
                }
            }

            return evenimente;
        }

        public void AddEveniment(Eveniment eveniment)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisierE, true))
            {
                streamWriterFisierText.WriteLine(eveniment.ConversieLaSir_PentruFisierE());
            }
       
        }

        public List<Eveniment> GetEvenimentDenumire(string denumire)
        {
            List<Eveniment> evenimente = new List<Eveniment>();
            using (StreamReader streamReader = new StreamReader(numeFisierE))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Eveniment eveniment = new Eveniment(linieFisier);
                    if (eveniment.denumire.Equals(denumire, StringComparison.OrdinalIgnoreCase))
                    {
                        evenimente.Add(eveniment);
                    }
                }
            }
            return evenimente;
        }
        public List<Eveniment> GetEvenimentData(string data)
        {
            List<Eveniment> evenimente = new List<Eveniment>();
            using (StreamReader streamReader = new StreamReader(numeFisierE))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Eveniment eveniment = new Eveniment(linieFisier);
                    if (eveniment.data.Equals(data))
                    {
                        evenimente.Add(eveniment);
                    }
                }
            }
            return evenimente;


        }

        public List<Eveniment> GetEvenimentLocatie(string locatie)
        {
            List<Eveniment> evenimente = new List<Eveniment>();
            using (StreamReader streamReader = new StreamReader(numeFisierE))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Eveniment eveniment = new Eveniment(linieFisier);
                    if (eveniment.locatie.Equals(locatie))
                    {
                        evenimente.Add(eveniment);
                    }
                }
            }
            return evenimente;


        }


        public List<Eveniment> GetEvenimentTip(string tip)
        {
            List<Eveniment> evenimente = new List<Eveniment>();
            using (StreamReader streamReader = new StreamReader(numeFisierE))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Eveniment eveniment = new Eveniment(linieFisier);
                    if (eveniment.tip.ToString().Equals(tip, StringComparison.OrdinalIgnoreCase))
                    {
                        evenimente.Add(eveniment);
                    }
                }
            }
            return evenimente;
        }

        public void StergeEveniment(string denumire)
        {
            List<Eveniment> evenimente = GetEvenimente();
            evenimente.RemoveAll(e => e.denumire == denumire);
            SaveEvenimente(evenimente);
        }
        public void UpdateEveniment(Eveniment eveniment)
        {
            List<Eveniment> evenimente = GetEvenimente();
            int index = evenimente.FindIndex(e => e.denumire == eveniment.denumire);
            if (index >=0)
            {
                evenimente[index] = eveniment;
                SaveEvenimente(evenimente);
            }
        }

        private void SaveEvenimente(List<Eveniment> evenimente)
        {
            using (StreamWriter sw = new StreamWriter(numeFisierE, false))
            {
                foreach (Eveniment eveniment in evenimente)
                {
                    sw.WriteLine(eveniment.ConversieLaSir_PentruFisierE());
                }
            }
        }


    }
}
