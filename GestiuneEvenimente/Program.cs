using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using LibrarieModele;
using NivelStocareDate;
using System.Runtime.InteropServices;
using GestiuneEvenimente;
using LibrarieModele.Enumerari;
using System.IO;

namespace GestiuneEvenimente
{
    class Program
    {
        static void Main()
        {
            AdministrareMemorieEvenimente adminEvenimente = new AdministrareMemorieEvenimente();
            Eveniment eveniment_nou = new Eveniment();

            AdministrareMemorieParticipanti adminParticipanti =  new AdministrareMemorieParticipanti(); 
            Participant participant_nou = new Participant();
            string numeFisierP = ConfigurationManager.AppSettings["NumeFisierP"];
            string numeFisierE = ConfigurationManager.AppSettings["NumeFisierE"];

         
            string locatieFisierSolutieP = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierP = locatieFisierSolutieP + "\\" + numeFisierP;

            string locatieFisierSolutieE = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierE = locatieFisierSolutieE + "\\" + numeFisierE;


            AdministrareMemorieParticipanti_Fisier adminParticipantif = new AdministrareMemorieParticipanti_Fisier(caleCompletaFisierP);
            AdministrareMemorieEvenimente_Fisier adminEvenimentef = new AdministrareMemorieEvenimente_Fisier(caleCompletaFisierE);


            List<Eveniment> evenimente = adminEvenimentef.GetEvenimente();
           
            int nrParticipanti1 = 0;
            string optiune;
            do
            {

                Console.WriteLine("\nP Participant -- A Administrator");
                Console.WriteLine("Introduceti optiunea: ");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "A":

                        string optiuneE;
                        do
                        {

                            Console.WriteLine("\nC. Citire informatii eveniment de la tastatura");
                            Console.WriteLine("I. Afisarea informatiilor despre ultimul eveniment introdus");
                            Console.WriteLine("A. Afisare eveniment din vector de obiecte");
                            Console.WriteLine("S. Salvare eveniment in vector de obiecte");
                            Console.WriteLine("AF. Afisare eveniment din fisier");
                            Console.WriteLine("SF. Salvare eveniment in fisier");
                            Console.WriteLine("X. Iesire catre meniul principal\n");
                            Console.WriteLine("Introduceti optiunea la eveniment: ");
                            optiuneE = Console.ReadLine();

                            switch (optiuneE.ToUpper())
                            {

                                case "C":
                                    eveniment_nou = CitireEveniment();
                                    break;
                                case "I":
                                    AfisareEveniment(eveniment_nou);
                                    break;
                                case "A":
                                    evenimente = adminEvenimente.GetEvenimente();
                                    AfisareEvenimente(evenimente);
                                    break;

                                case "S":
                                    adminEvenimente.AddEveniment(eveniment_nou);
                                    Console.WriteLine("Eveniment adaugat cu succes in vectorul de obiecte!");
                                    break;
                                case "SF":
                                    Console.WriteLine("Salvare in fisier cu succes!!");
                                    adminEvenimentef.AddEveniment(eveniment_nou);
                                    break;
                                case "AF":
                                   evenimente= adminEvenimentef.GetEvenimente();
                                    AfisareEvenimente(evenimente);
                                    break;
                                case "X":
                                    break;
                                default:
                                    Console.WriteLine("Optiunea nu exista!");
                                    break;
                            }



                        } while (optiuneE.ToUpper() != "X");
                        if (optiuneE.ToUpper() != "X")
                        {
                            Console.WriteLine("Introduceti optiunea: ");
                            Console.ReadKey();
                        }
                        break;
                    case "P":
                        string optiuneP;
                        do
                        {
                            Console.WriteLine("\nC. Citire informatii participanti de la tastatura");
                            Console.WriteLine("I. Afisarea informatiilor despre ultimul participant introdus");
                            Console.WriteLine("A. Afisare participant din vector de obiecte");
                            Console.WriteLine("S. Salvare participant in vector de obiecte");
                            Console.WriteLine("SF. Salvare in fisier");
                            Console.WriteLine("AF. Afisare din fisier");
                            Console.WriteLine("E. Cautare participant dupa eveniment");
                            Console.WriteLine("X. Iesire catre meniul principal\n");
                            Console.WriteLine("Introduceti optiunea la participant: ");
                            optiuneP = Console.ReadLine();
                            switch (optiuneP.ToUpper())
                            {

                                case "C":
                                    participant_nou = CitireParticipant();
                                    break;
                                case "I":
                                    AfisareParticipant(participant_nou);
                                    break;
                                case "S":
                                    adminParticipanti.AddParticipant(participant_nou);
                                    nrParticipanti1 += 1;
                                    Console.WriteLine("Participant adaugat cu succes in vectorul de obiecte!");
                                    break;

                                case "A":
                                    List<Participant> participanti = adminParticipanti.GetParticipanti();
                                    AfisareParticipanti(participanti);
                                    break;
                                case "SF":
                                    Console.WriteLine("Salvare in fisier cu succes!!");
                                    adminParticipantif.AddParticipant(participant_nou);
                                    break;
                                case "AF":
                                    List<Participant> participanti5= adminParticipantif.GetParticipanti();
                                    AfisareParticipanti(participanti5);
                                    break;
                                 
                                case "E":

                                    int ok8 = 0;
                                    Console.WriteLine("\nIntroduceti evenimentul la care participantul va lua parte: ");
                                    string eveniment1 = Console.ReadLine();
                                    List<Participant> participantiGasiti4 = adminParticipantif.GetParticipantEveniment(eveniment1);
                                    foreach (Participant participant in participantiGasiti4)
                                    {
                                        ok8++;
                                        Console.WriteLine($"Participantul {participant.nume} {participant.prenume}, varsta de {participant.varsta} ani va participa la evenimentul {participant.eveniment}");

                                    }
                                    if (ok8 == 0)
                                        Console.WriteLine("Participantul nu a fost gasit!");

                                    break;

                                
                                case "X":
                                    break;
                                default:
                                    Console.WriteLine("Optiunea nu exista!");
                                    break;
                            }

                        } while (optiuneP.ToUpper() != "X");
                        if (optiuneP.ToUpper() != "X")
                        {
                            Console.WriteLine("Introduceti optiunea: ");
                            Console.ReadKey();
                        }
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiunea nu exista!");
                        break;

                }
            } while (optiune.ToUpper() != "X");
            Console.WriteLine("Introduecti optinunea: ");
            Console.ReadKey();
        }




        public static Eveniment CitireEveniment()
        {
            Console.WriteLine("Introdu denumirea evenimentului: ");
            string denumire = Console.ReadLine();

            Console.WriteLine("Introdu data evenimentului:  ");
            string data = Console.ReadLine();

            Console.WriteLine("Introdu ora evenimentului: ");
            string ora = Console.ReadLine();

            Console.WriteLine("Introdu locatia evenimentului: ");
            string locatie = Console.ReadLine();

            Eveniment eveniment = new Eveniment(denumire,data,locatie,ora);

            

            Console.WriteLine("Alegeti tipul evenimentului: ");
            Console.WriteLine("1 - Corporativ\n" +
                "2 - Social\n" +
                "3 - Cultural\n" +
                "4 - Sportiv\n" +
                "5 - Educational\n" +
                "6 - Caritabil\n" +
                "7 - Politic\n" +
                "8 - Religios\n" +
                "9 - Networking\n" +
                "10 -Virtual\n");
            Console.WriteLine("Alegeti tipul evenimentului: ");
            int optiune = Convert.ToInt32(Console.ReadLine());
            eveniment.tip = (TipEveniment)optiune;
            return eveniment;
        }
            

            
  
        
        public static void AfisareEveniment(Eveniment eveniment)
        {
            string infoEveniment = string.Format("Evenimentul {0}, va avea loc pe data de {1} la ora {3} in {2}. Tipul evenimentului: {4}",
            eveniment.denumire ?? "NECUNOSCUT",
            eveniment.data ?? "NECUNOSCUT",
            eveniment.locatie ?? "NECUNOSCUT",
            eveniment.ora ?? "NECUNOSCUT",
            eveniment.tip);
            Console.WriteLine(infoEveniment);
        }

        public static Participant CitireParticipant()
        {
            Console.Write("Introdu numele participantului: ");
            string nume = Console.ReadLine();

            Console.Write("Introdu prenumele participantului:  ");
            string prenume = Console.ReadLine();

            Console.Write("Introdu varsta participantului: ");
            int varsta = Int32.Parse(Console.ReadLine());

            Console.Write("Introdu numele evenimentului: ");
            string eveniment = Console.ReadLine();

            Participant participant = new Participant(nume, prenume, varsta, eveniment);
            return participant;
        }



        public static void AfisareParticipant(Participant participant)
        {
            string infoParticipant = string.Format("Participantul {0} {1} cu varsta de {3} ani va lua parte la evenimnetul {2}",
                participant.nume ?? "NECUNOSCUT",
                participant.prenume ?? "NECUNOSCUT",
                participant.eveniment ?? "NECUNOSCUT",
                participant.varsta);
            Console.WriteLine(infoParticipant);

        }
        public static void AfisareEvenimente(List<Eveniment> evenimente)
        {
            Console.WriteLine("\nEvenimentele sunt:");
            foreach(Eveniment eveniment in evenimente)
            {
                string infoEveniment = eveniment.Info();
                Console.WriteLine(infoEveniment);
            }
        }
        public static void AfisareParticipanti(List<Participant> participanti)
        {
            Console.WriteLine("\nParticipantii sunt:");
            foreach (Participant participant in participanti)
            {
                string infoParticipant = participant.Info();
                Console.WriteLine(infoParticipant);
            }
        }

        

    }

}