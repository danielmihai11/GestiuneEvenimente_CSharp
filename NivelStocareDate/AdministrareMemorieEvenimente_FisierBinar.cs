using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NivelStocareDate
{
    
    public class AdministrareMemorieEvenimente_FisierBinar : IStocareDataEvenimente
    {

        string NumeFisierE { get; set; }
        public AdministrareMemorieEvenimente_FisierBinar(string numeFisier)
        {
            this.NumeFisierE = numeFisier;
            Stream sBinFile = File.Open(NumeFisierE, FileMode.OpenOrCreate);
            sBinFile.Close();

            
        }

        public void AddEveniment(Eveniment e)
        {
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                using (Stream sBinFile = File.Open(NumeFisierE, FileMode.Append, FileAccess.Write))
                {
                    b.Serialize(sBinFile, e);
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public List<Eveniment> GetEvenimente()
        {
            List<Eveniment> evenimente = new List<Eveniment>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                using (Stream sBinFile = File.Open(NumeFisierE, FileMode.Open))
                {

                    while (sBinFile.Position < sBinFile.Length)
                    {
                        evenimente.Add((Eveniment)b.Deserialize(sBinFile));
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return evenimente;
        }
       

        public List<Eveniment> GetEvenimentDenumire(string denumire)
        {
            List<Eveniment> evenimente = new List<Eveniment>();

            BinaryFormatter b = new BinaryFormatter();
            using (Stream sBinFile = File.Open(NumeFisierE, FileMode.Open))
            {

                while (sBinFile.Position < sBinFile.Length)
                {
              
                    Eveniment eveniment = (Eveniment)b.Deserialize(sBinFile);
                    if (eveniment.denumire.Equals(denumire))
                        evenimente.Add(eveniment);
                }
            }

            return null;
        }

        public List<Eveniment> GetEvenimentData(string data)
        {
            List<Eveniment> evenimente = new List<Eveniment>();
            BinaryFormatter b = new BinaryFormatter();
            using (Stream sBinFile = File.Open(NumeFisierE, FileMode.Open))
            {

                while (sBinFile.Position < sBinFile.Length)
                {
                    Eveniment eveniment = (Eveniment)b.Deserialize(sBinFile);
                    if (eveniment.data.Equals(data))
                        evenimente.Add(eveniment);
                }
            }

            return null;
        }

        public List<Eveniment> GetEvenimentLocatie(string locatie)
        {
            List<Eveniment> evenimente = new List<Eveniment>();
            BinaryFormatter b = new BinaryFormatter();
            using (Stream sBinFile = File.Open(NumeFisierE, FileMode.Open))
            {

                while (sBinFile.Position < sBinFile.Length)
                {
                    Eveniment eveniment = (Eveniment)b.Deserialize(sBinFile);
                    if (eveniment.locatie.Equals(locatie))
                        evenimente.Add(eveniment);
                }
            }

            return null;
        }

        public List<Eveniment> GetEvenimentTip(string tip)
        {
            List<Eveniment> evenimente = new List<Eveniment>();
            BinaryFormatter b = new BinaryFormatter();
            using (Stream sBinFile = File.Open(NumeFisierE, FileMode.Open))
            {

                while (sBinFile.Position < sBinFile.Length)
                {
                    Eveniment eveniment = (Eveniment)b.Deserialize(sBinFile);
                    if (eveniment.tip.Equals(tip))
                        evenimente.Add(eveniment);
                }
            }

            return null;
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
            if (index != -1)
            {
                evenimente[index] = eveniment;
                SaveEvenimente(evenimente);
            }
        }
        private void SaveEvenimente(List<Eveniment> evenimente)
        {
            using (FileStream fs = new FileStream(NumeFisierE, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, evenimente);
            }
        }
       
    }
    
}
