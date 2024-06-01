using LibrarieModele;
using System.Collections.Generic;

namespace NivelStocareDate
{
    //definitia interfetei
    public interface IStocareDataEvenimente
    {
        void AddEveniment(Eveniment eveniment);
        List<Eveniment> GetEvenimente();
        List<Eveniment> GetEvenimentDenumire(string denumire);
        List<Eveniment> GetEvenimentData(string data);
        List<Eveniment> GetEvenimentLocatie(string locatie);
        List<Eveniment> GetEvenimentTip(string tip);

        void StergeEveniment(string denumire);

        void UpdateEveniment(Eveniment eveniment);

       



    }
}
