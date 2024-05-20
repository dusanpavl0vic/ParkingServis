using ParkingServis.Entiteti;
using Prodavnica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;

namespace ParkingServis
{
    public class DTOManager
    {
        #region Vozilo
        public static void obrisiVozilo(int registarskiBroj)
        {
            try
            {
                NHibernate.ISession s = DataLayer.GetSession();

                Vozilo vozilo = s.Load<Vozilo>(registarskiBroj);

                s.Delete(vozilo);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        #endregion
    }
}
