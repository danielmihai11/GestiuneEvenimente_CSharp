using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareMemorieEvenimente_Fisier
    {
        private const int NR_MAX_EVENIMENTE = 100;
        private string numeFisierE;

        public AdministrareMemorieEvenimente_Fisier(string numeFisierE)
        {
            this.numeFisierE = numeFisierE;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisierE, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }


        /*public int GetLastId()
        {
            int lastID = 0;
            using (StreamReader streamReader = new StreamReader(numeFisierE))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    lastID++;
                }
            }
            return lastID;
        }*/
        public Eveniment[] GetEvenimente(out int nrEvenimente)
        {
            Eveniment[] evenimente = new Eveniment[NR_MAX_EVENIMENTE];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisierE))
            {
                string linieFisier;
                nrEvenimente = 0;

                // citeste cate o linie si creaza un obiect de tip Participant
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    evenimente[nrEvenimente++] = new Eveniment(linieFisier);
                }
            }

            return evenimente;
        }
      
        public void AddEvenimente(Eveniment eveniment)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisierE, true))
            {
                streamWriterFisierText.WriteLine(eveniment.ConversieLaSir_PentruFisierE());
            }
        }



        public Eveniment[] CautareDupaDenumire(string denumireCautata, int nrEvenimente)
        {
            List<Eveniment> evenimenteGasite = new List<Eveniment>();

            // deschide fisierul si citeste fiecare linie
            using (StreamReader streamReader = new StreamReader(numeFisierE))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Eveniment eveniment = new Eveniment(linieFisier);
                    if (eveniment.denumire == denumireCautata)
                    {
                        // adauga evenimentul gasit in lista
                        evenimenteGasite.Add(eveniment);
                    }
                }
            }

            // converteste lista de evenimente gasite in vector de evenimente si returneaza
            return evenimenteGasite.ToArray();
        }

        public Eveniment[] CautareDupaData(string dataCautata, int nrEvenimente)
        {
            List<Eveniment> evenimenteGasite = new List<Eveniment>();

            // deschide fisierul si citeste fiecare linie
            using (StreamReader streamReader = new StreamReader(numeFisierE))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Eveniment eveniment = new Eveniment(linieFisier);
                    if (eveniment.data == dataCautata)
                    {
                        // adauga evenimentul gasit in lista
                        evenimenteGasite.Add(eveniment);
                    }
                }
            }

            // converteste lista de evenimente gasite in vector de evenimente si returneaza
            return evenimenteGasite.ToArray();
        }

        public Eveniment[] CautareDupaLocatie(string locatieCautata, int nrEvenimente)
        {
            List<Eveniment> evenimenteGasite = new List<Eveniment>();

            // deschide fisierul si citeste fiecare linie
            using (StreamReader streamReader = new StreamReader(numeFisierE))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Eveniment eveniment = new Eveniment(linieFisier);
                    if (eveniment.locatie == locatieCautata)
                    {
                        // adauga evenimentul gasit in lista
                        evenimenteGasite.Add(eveniment);
                    }
                }
            }

            // converteste lista de evenimente gasite in vector de evenimente si returneaza
            return evenimenteGasite.ToArray();
        }

        public Eveniment[] CautareDupaOra(string oraCautata, int nrEvenimente)
        {
            List<Eveniment> evenimenteGasite = new List<Eveniment>();

            // deschide fisierul si citeste fiecare linie
            using (StreamReader streamReader = new StreamReader(numeFisierE))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Eveniment eveniment = new Eveniment(linieFisier);
                    if (eveniment.ora == oraCautata)
                    {
                        // adauga evenimentul gasit in lista
                        evenimenteGasite.Add(eveniment);
                    }
                }
            }

            // converteste lista de evenimente gasite in vector de evenimente si returneaza
            return evenimenteGasite.ToArray();
        }




    }
}
