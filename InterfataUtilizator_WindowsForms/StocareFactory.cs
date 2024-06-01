using NivelStocareDate;
using System.Configuration;
using System.IO;

namespace InterfataUtilizator_WindowsForms
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER_EVENIMENTE = "NumeFisierE";
        private const string NUME_FISIER_PARTICIPANTI = "NumeFisierP";

        public static IStocareDataEvenimente GetAdministratorStocareEvenimente()
        {
            string formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            string numeFisier = ConfigurationManager.AppSettings[NUME_FISIER_EVENIMENTE];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    case "bin":
                        return new AdministrareMemorieEvenimente_FisierBinar(caleCompletaFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareMemorieEvenimente_Fisier(caleCompletaFisier + "." + formatSalvare);
                }
            }

            return null;
        }

        public static IStocareDataParticipanti GetAdministratorStocareParticipanti()
        {
            string formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            string numeFisier = ConfigurationManager.AppSettings[NUME_FISIER_PARTICIPANTI];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    case "bin":
                        return new AdministrareMemorieParticipanti_FisierBinar(caleCompletaFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareMemorieParticipanti_Fisier(caleCompletaFisier + "." + formatSalvare);
                }
            }

            return null;
        }
    }
}
