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
using System.Windows.Forms;
using ISession = NHibernate.ISession;

namespace ParkingServis
{
    public class DTOManager
    {
        #region Vozilo

        public static List<VoziloPregled> VratiSvaVozila()
        {
            List<VoziloPregled> vozila = new List<VoziloPregled>();

            try
            {
                NHibernate.ISession session = DataLayer.GetSession();
                IEnumerable<Vozilo> svaVozila = from o in session.Query<Vozilo>()
                                                   select o;


                Vozilo testVozilo = svaVozila.ElementAt(0);
                MessageBox.Show(
                    testVozilo.BrojSaobracajneDozvole + " " + testVozilo.Model + " " + testVozilo.Proizvodjac);

                foreach(Vozilo vozilo in svaVozila)
                {
                    vozila.Add(new VoziloPregled(vozilo));
                }

                session.Close();
                return vozila;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return vozila;

        }
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

        #region Parking
        public static List<ParkingPregled> VratiSveParkinge()
        {
            List<ParkingPregled> parkinzi = new List<ParkingPregled>();

            try
            {
                NHibernate.ISession session = DataLayer.GetSession();
                IEnumerable<Parking> sviParkinzi = from o in session.Query<Parking>()
                                                   select o;

                foreach(Parking parking in sviParkinzi)
                {
                    parkinzi.Add(new ParkingPregled(parking));
                }

                session.Close();
                return parkinzi;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return parkinzi;

        }

        public static void ObrisiParking(int index)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();
                Parking parking = session.Load<Parking>(index);

                session.Delete(parking);
                session.Flush();
                session.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void DodajParking(int index)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();



                session.Flush();
                session.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        #endregion
    }
}
