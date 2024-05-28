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
using NHibernate.Transform;
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


                //Vozilo testVozilo = svaVozila.ElementAt(0);
                //MessageBox.Show(
                //    testVozilo.BrojSaobracajneDozvole + " " + testVozilo.Model + " " + testVozilo.Proizvodjac);

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
        public static void dodajVozilo(VoziloBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ParkingServis.Entiteti.Vozilo o = new ParkingServis.Entiteti.Vozilo();
                o.Id = r.Id;
                o.RegistarskiBroj = r.RegistarskiBroj;
                o.BrojSaobracajneDozvole = r.BrojSaobracajneDozvole;
                o.Proizvodjac = r.Proizvodjac;
                o.Model = r.Model;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static void obrisiVozilo(int index)
        {
            try
            {
                NHibernate.ISession s = DataLayer.GetSession();
                Vozilo vozilo = s.Load<Vozilo>(index);

                s.Delete(vozilo);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        #endregion

        #region Parking
        public static Parking VratiParking(int idVozila)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                Parking parking = session.Get<Parking>(idVozila);

                return parking;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

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

        public static void DodajParking(ParkingBasic noviParking)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                // proveri dal postoji parking sa taj ID
                Parking postojiParking = session.Get<Parking>(noviParking.ID);
                if (postojiParking != null)
                {
                    MessageBox.Show("Vec postoji parking sa tim id-jem");
                    return;
                }

                Parking parking = new Parking();
                ObjectCreator.Instance.ToParking(parking, noviParking);
                session.Save(parking);

                session.Flush();
                session.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public static void AzurirajParking(ParkingBasic noviParking)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                Parking parking = session.Load<Parking>(noviParking.ID);
                if (parking == null)
                {
                    MessageBox.Show("Ne postoji parking sa tim id-jem");
                    return;
                }

                parking = ObjectCreator.Instance.ToParking(parking, noviParking);
                session.Update(parking);

                session.Flush();
                session.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        #endregion

        #region ParkingMesto


        public static ParkingMesto VratiParkingMesto(int idParkingMesta)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                ParkingMesto parkingMesto = session.Get<ParkingMesto>(idParkingMesta);

                return parkingMesto;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        public static List<ParkingMestoPregled> VratiParkingMesta(int idParkinga)
        {
            List<ParkingMestoPregled> parkingMesta = new List<ParkingMestoPregled>();

            try
            {
                ISession session = DataLayer.GetSession();
                List<ParkingMesto> sviParkingzi =
                    (from o in session.Query<ParkingMesto>()
                        where o.PripadaParkingu.ID == idParkinga
                        select o).ToList();

                foreach (ParkingMesto p in sviParkingzi)
                {
                    parkingMesta.Add(new ParkingMestoPregled(p));
                }

                return parkingMesta;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return parkingMesta;
            }
        } 
        
        public static void ObrisiParkingMesto(int index)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();
                ParkingMesto parkingMesto = session.Get<ParkingMesto>(index);

                session.Delete(parkingMesto);
                session.Flush();
                session.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void DodajParkingMesto(ParkingMestoBasic novoParkingMesto)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                // proveri dal postoji parking sa taj ID
                ParkingMesto postojiParkingMesto = session.Get<ParkingMesto>(novoParkingMesto.ID);
                if (postojiParkingMesto != null)
                {
                    MessageBox.Show("Vec postoji parking sa tim id-jem");
                    return;
                }

                ParkingMesto parkingMesto = new ParkingMesto();
                ObjectCreator.Instance.ToParkingMesto(parkingMesto, novoParkingMesto);
                session.Save(parkingMesto);

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
