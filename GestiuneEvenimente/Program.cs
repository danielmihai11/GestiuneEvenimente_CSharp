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
            int nrEvenimente1 = 0;

            AdministrareMemorieParticipanti adminParticipanti =  new AdministrareMemorieParticipanti(); 
            Participant participant_nou = new Participant();
            string numeFisierP = ConfigurationManager.AppSettings["NumeFisierP"];
            string numeFisierE = ConfigurationManager.AppSettings["NumeFisierE"];

         
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisierP;

            AdministrareMemorieParticipanti_Fisier adminParticipantif = new AdministrareMemorieParticipanti_Fisier(caleCompletaFisier);
            AdministrareMemorieEvenimente_Fisier adminEvenimentef = new AdministrareMemorieEvenimente_Fisier(numeFisierE);

            int nrParticipanti1 = 0;
            string optiune;
            do
            {

                Console.WriteLine("\nE Evenimente -- P Participant");
                Console.WriteLine("Introduceti optiunea: ");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "E":

                        string optiuneE;
                        do
                        {

                            Console.WriteLine("\nC. Citire informatii eveniment de la tastatura");
                            Console.WriteLine("I. Afisarea informatiilor despre ultimul eveniment introdus");
                            Console.WriteLine("A. Afisare eveniment din vector de obiecte");
                            Console.WriteLine("S. Salvare eveniment in vector de obiecte");
                            Console.WriteLine("AF. Afisare eveniment din fisier");
                            Console.WriteLine("SF. Salvare eveniment in fisier");
                            Console.WriteLine("DEN. Cautare eveniment dupa denumire");
                            Console.WriteLine("D. Cautare eveniment dupa data");
                            Console.WriteLine("L. Cautare eveniment dupa locatie");
                            Console.WriteLine("O. Cautare eveniment dupa ora");
                            Console.WriteLine("AA. Afisare evenimente in ordine alfabetica");
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
                                    //afisare evenimente din vectorul de obiecte
                                    Eveniment[] evenimente = adminEvenimente.GetEvenimente(out nrEvenimente1);
                                    AfisareEvenimente(evenimente, nrEvenimente1);
                                    break; 

                                case "S":

                                    //salvare eveniment in vectorul de obiecte
                                    adminEvenimente.AddEvenimente(eveniment_nou);
                                    nrEvenimente1 += 1;
                                    Console.WriteLine("Eveniment adaugat cu succes in vectorul de obiecte!");
                                    break;
                                case "SF":
                                    Console.WriteLine("Salvare in fisier cu succes!!");
                                    adminEvenimentef.AddEvenimente(eveniment_nou);
                                    break;
                                case "AF":
                                    Eveniment[] evenimente5 = adminEvenimentef.GetEvenimente(out nrEvenimente1);
                                    AfisareEvenimente(evenimente5, nrEvenimente1);
                                    break;


                                case "DEN":
                                    int ok1 = 0;
                                    Console.WriteLine("\nIntroduceti denumirea evenimentului: ");
                                    string denumire1 = Console.ReadLine();
                                    Eveniment[] evenimenteGasite1 = adminEvenimentef.CautareDupaDenumire(denumire1, nrEvenimente1);
                                    foreach (Eveniment eveniment in evenimenteGasite1)
                                    {
                                        ok1++;
                                        Console.WriteLine($"Evenimentul cu denumirea {eveniment.denumire} are loc pe data de {eveniment.data},la ora {eveniment.ora} in locatia {eveniment.locatie}");
                                        
                                    }
                                    if (ok1 == 0)
                                        Console.WriteLine("Evenimentul nu a fost gasit!");

                                    break;
                                  
                                  

                                    
                                case "D":

                                    int ok2 = 0;
                                    Console.WriteLine("\nIntroduceti data evenimentului: ");
                                    string data1 = Console.ReadLine();
                                    Eveniment[] evenimenteGasite2 = adminEvenimentef.CautareDupaData(data1, nrEvenimente1);
                                    foreach (Eveniment eveniment in evenimenteGasite2)
                                    {
                                        ok2++;
                                        Console.WriteLine($"Evenimentul cu denumirea {eveniment.denumire} are loc pe data de {eveniment.data},la ora {eveniment.ora} in locatia {eveniment.locatie}");

                                    }
                                    if (ok2 == 0)
                                        Console.WriteLine("Evenimentul nu a fost gasit!");

                                    break;

                                case "L":

                                    int ok3 = 0;
                                    Console.WriteLine("\nIntroduceti locatia evenimentului: ");
                                    string locatia1 = Console.ReadLine();
                                    Eveniment[] evenimenteGasite3 = adminEvenimentef.CautareDupaLocatie(locatia1, nrEvenimente1);
                                    foreach (Eveniment eveniment in evenimenteGasite3)
                                    {
                                        ok3++;
                                        Console.WriteLine($"Evenimentul cu denumirea {eveniment.denumire} are loc pe data de {eveniment.data},la ora {eveniment.ora} in locatia {eveniment.locatie}");

                                    }
                                    if (ok3 == 0)
                                        Console.WriteLine("Evenimentul nu a fost gasit!");

                                    break;

                                case "O":

                                    int ok4 = 0;
                                    Console.WriteLine("\nIntroduceti ora evenimentului: ");
                                    string ora1 = Console.ReadLine();
                                    Eveniment[] evenimenteGasite4 = adminEvenimentef.CautareDupaOra(ora1, nrEvenimente1);
                                    foreach (Eveniment eveniment in evenimenteGasite4)
                                    {
                                        ok4++;
                                        Console.WriteLine($"Evenimentul cu denumirea {eveniment.denumire} are loc pe data de {eveniment.data},la ora {eveniment.ora} in locatia {eveniment.locatie}");

                                    }
                                    if (ok4 == 0)
                                        Console.WriteLine("Evenimentul nu a fost gasit!");

                                    break;
                                case "AA":
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
                            Console.WriteLine("N. Cautare participant dupa nume");
                            Console.WriteLine("P. Cautare participant dupa prenume");
                            Console.WriteLine("E. Cautare participant dupa eveniment");
                            Console.WriteLine("V. Cautare participant dupa varsta");
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
                                    adminParticipanti.AddParticipanti(participant_nou);
                                    nrParticipanti1 += 1;
                                    Console.WriteLine("Participant adaugat cu succes in vectorul de obiecte!");
                                    break;

                                case "A":
                                    Participant[] participanti = adminParticipanti.GetParticipanti(out nrParticipanti1);
                                    AfisareParticipanti(participanti, nrParticipanti1);
                                    break;
                                case "SF":
                                    Console.WriteLine("Salvare in fisier cu succes!!");
                                    adminParticipantif.AddParticipanti(participant_nou);
                                    break;
                                case "AF":
                                    Participant[] participanti5= adminParticipantif.GetParticipanti(out nrParticipanti1 );
                                    AfisareParticipanti(participanti5, nrParticipanti1);
                                    break;

                                case "N":

                                    int ok5 = 0;
                                    Console.WriteLine("\nIntroduceti numele participantului: ");
                                    string nume1 = Console.ReadLine();
                                    Participant[] participantiGasiti1 = adminParticipantif.CautareDupaNume(nume1);
                                    foreach (Participant participant in participantiGasiti1)
                                    {
                                        ok5++;
                                        Console.WriteLine($"Participantul {participant.nume} {participant.prenume}, varsta de {participant.varsta} ani va participa la evenimentul {participant.eveniment}");

                                    }
                                    if (ok5 == 0)
                                        Console.WriteLine("Participantul nu a fost gasit!");

                                    break;
                                case "P":

                                    int ok6 = 0;
                                    Console.WriteLine("\nIntroduceti prenumele participantului: ");
                                    string prenume1 = Console.ReadLine();
                                    Participant[] participantiGasiti2 = adminParticipantif.CautareDupaPrenume(prenume1, nrParticipanti1);
                                    foreach (Participant participant in participantiGasiti2)
                                    {
                                        ok6++;
                                        Console.WriteLine($"Participantul {participant.nume} {participant.prenume}, varsta de {participant.varsta} ani va participa la evenimentul {participant.eveniment}");

                                    }
                                    if (ok6 == 0)
                                        Console.WriteLine("Participantul nu a fost gasit!");

                                    break;


                                   

                                case "V":
                                    int ok7 = 0;
                                    Console.WriteLine("\nIntroduceti varsta participantului: ");
                                    int varsta1 = Int32.Parse(Console.ReadLine());
                                    Participant[] participantiGasiti3 = adminParticipantif.CautareDupaVarsta(varsta1, nrParticipanti1);
                                    foreach (Participant participant in participantiGasiti3)
                                    {
                                        ok7++;
                                        Console.WriteLine($"Participantul {participant.nume} {participant.prenume}, varsta de {participant.varsta} ani va participa la evenimentul {participant.eveniment}");

                                    }
                                    if (ok7 == 0)
                                        Console.WriteLine("Participantul nu a fost gasit!");

                                    break;

                                 
                                case "E":

                                    int ok8 = 0;
                                    Console.WriteLine("\nIntroduceti evenimentul la care participantul va lua parte: ");
                                    string eveniment1 = Console.ReadLine();
                                    Participant[] participantiGasiti4 = adminParticipantif.CautareDupaEveniment(eveniment1);
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
        public static void AfisareEvenimente(Eveniment[] evenimente, int nrEvenimente)
        {
            Console.WriteLine("\nEvenimentele sunt:");
            for (int contor = 0; contor < nrEvenimente; contor++)
            {
                string infoEveniment = evenimente[contor].Info();
                Console.WriteLine(infoEveniment);
            }
        }
        public static void AfisareParticipanti(Participant[] participanti, int nrParticipanti)
        {
            Console.WriteLine("\nParticipantii sunt:");
            for (int contor = 0; contor < nrParticipanti; contor++)
            {
                string infoParticipant = participanti[contor].Info();
                Console.WriteLine(infoParticipant);
            }
        }

        

    }

}