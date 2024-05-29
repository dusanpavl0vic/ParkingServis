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
        public static void DodajVozilo(VoziloBasic novoVozilo)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                // proveri dal postoji vozilo sa taj ID
                Vozilo postojiVozilo = session.Get<Vozilo>(novoVozilo.Id);
                if (postojiVozilo != null)
                {
                    session.SaveOrUpdate(postojiVozilo);
                    MessageBox.Show("Vec postoji vozilo sa tim id-jem");
                    session.Close();
                    return;
                }

                Vozilo vozilo = new Vozilo();
                ObjectCreator.Instance.ToVozilo(vozilo, novoVozilo);
                session.Save(vozilo);

                session.Flush();
                session.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public static void obrisiVozilo(int index)
        {
            try
            {
                NHibernate.ISession s = DataLayer.GetSession();
                Vozilo vozilo = s.Get<Vozilo>(index);

                if (vozilo == null)
                {
                    MessageBox.Show("Ne postoji vozilo sa tim id-jem");
                    s.Close();
                    return;
                }

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
                Parking parking = session.Get<Parking>(index);

                if(parking == null)
                {
                    MessageBox.Show("Ne postoji parking sa tim id-jem");
                    session.Close();
                    return;
                }

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
                    session.Close();
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
                    session.Close();
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

                if (parkingMesto == null)
                {
                    MessageBox.Show("Ne postoji parking sa tim id-jem");
                    session.Close();
                    return;
                }

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
                    session.Close();
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

        public static void AzurirajParkingMesto(ParkingMestoBasic novoParkingMesto)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                ParkingMesto parkingMesto = session.Load<ParkingMesto>(novoParkingMesto.ID);
                if (parkingMesto == null)
                {
                    MessageBox.Show("Ne postoji parking sa tim id-jem");
                    session.Close();
                    return;
                }

                parkingMesto = ObjectCreator.Instance.ToParkingMesto(parkingMesto, novoParkingMesto);
                session.Update(parkingMesto);

                session.Flush();
                session.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        #endregion

        #region Osobe

        public static Osoba VratiOsobu(int index)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Osoba osoba = session.Get<Osoba>(index);
                return osoba;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

        }

        public static List<OsobaPregled> VratiOsobe()
        {
            List<OsobaPregled> osobeList = new List<OsobaPregled>();

            try
            {
                ISession session = DataLayer.GetSession();
                IEnumerable<Osoba> sveOsobe = from o in session.Query<Osoba>()
                                                   select o;

                foreach (Osoba osoba in sveOsobe)
                {
                    osobeList.Add(new OsobaPregled(osoba));
                }

                return osobeList;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return osobeList;
            }
        } 
        public static void ObrisiOsobu(int index)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();
                Osoba osoba = session.Get<Osoba>(index);

                if (osoba == null)
                {
                    MessageBox.Show("Ne postoji osoba sa tim id-jem");

                    session.Close();
                    return;
                }

                session.Delete(osoba);
                session.Flush();
                session.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void DodajOsobu(OsobaBasic novaOsoba)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                Osoba postojiOsoba = session.Get<Osoba>(novaOsoba.ID);
                if (postojiOsoba != null)
                {
                    MessageBox.Show("Vec postoji parking sa tim id-jem");
                    session.Close();
                    return;
                }

                Osoba osoba;
                if (novaOsoba.OsobaType == "FizickoLice")
                {
                    osoba = new FizickoLice();
                }
                else if (novaOsoba.OsobaType == "PravnoLice")
                {
                    osoba = new PravnoLice();
                }
                else
                {
                    MessageBox.Show("Osoba mora biti ili fizicko ili pravno lice");
                    session.Close();
                    return;
                }
                
                ObjectCreator.Instance.ToOsoba(osoba, novaOsoba);
                session.Save(osoba);

                session.Flush();
                session.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void AzurirajOsobu(OsobaBasic novaOsoba)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                Osoba osoba = session.Get<Osoba>(novaOsoba.ID);

                if (osoba == null)
                {
                    MessageBox.Show("Ne postoji osoba sa tim id-jem");
                    session.Close();
                    return;
                }

                osoba = ObjectCreator.Instance.ToOsoba(osoba, novaOsoba);
                session.Update(osoba);

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
