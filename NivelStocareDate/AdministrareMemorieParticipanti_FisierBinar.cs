using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NivelStocareDate
{
    public class AdministrareMemorieParticipanti_FisierBinar : IStocareDataParticipanti
    {
        

        string NumeFisierP { get; set; }
        public AdministrareMemorieParticipanti_FisierBinar(string numeFisier)
        {
            this.NumeFisierP = numeFisier;
            Stream sBinFile = File.Open(NumeFisierP, FileMode.OpenOrCreate);
            sBinFile.Close();
        }

        public void AddParticipant(Participant p)
        {

            try
            {
                BinaryFormatter b = new BinaryFormatter();

               
                using (Stream sBinFile = File.Open(NumeFisierP, FileMode.Append, FileAccess.Write))
                {
                    b.Serialize(sBinFile, p);
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

        public List<Participant> GetParticipanti()
        {
            List<Participant> participanti = new List<Participant>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                using (Stream sBinFile = File.Open(NumeFisierP, FileMode.Open))
                {

                    while (sBinFile.Position < sBinFile.Length)
                    {
                       
                        participanti.Add((Participant)b.Deserialize(sBinFile));
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

            return participanti;
        }

        public List<Participant> GetParticipantEveniment(string eveniment)
        {
            List<Participant> participanti= new List<Participant>();
            BinaryFormatter b = new BinaryFormatter();
            using (Stream sBinFile = File.Open(NumeFisierP, FileMode.Open))
            {

                while (sBinFile.Position < sBinFile.Length)
                {
                    Participant participant = (Participant)b.Deserialize(sBinFile);
                    if (participant.eveniment.Equals(eveniment))
                        participanti.Add(participant);
                }
            }

            return participanti;
        }

        

        

        public bool UpdateParticipant(Participant p)
        {
            throw new Exception("Optiunea UpdateParticipant nu este implementata");
        }
       
    }

}
