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

        public static Vozilo VratiVozilo(int idVozila)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                Vozilo vozilo = session.Get<Vozilo>(idVozila);

                return vozilo;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

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
        public static void AzurirajVozilo(VoziloBasic novoVozilo)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                Vozilo vozilo = session.Load<Vozilo>(novoVozilo.Id);
                if (vozilo == null)
                {
                    MessageBox.Show("Ne postoji vozilo sa tim id-jem");
                    session.Close();
                    return;
                }

                vozilo = ObjectCreator.Instance.ToVozilo(vozilo, novoVozilo);
                session.Update(vozilo);

                session.Flush();
                session.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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

                Parking parking;
                if (noviParking.ParkingType == "Podzemna")
                {
                    parking = new Podzemna();
                }
                else if (noviParking.ParkingType == "Nadzemna")
                {
                    parking = new Nadzemna();
                }
                else
                {
                    MessageBox.Show("Tip parkinga nije validan");
                    session.Close();
                    return;
                }

                ObjectCreator.Instance.ToParking(parking, noviParking);
                MessageBox.Show(parking.ParkingType);
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

        public static List<ParkingMestoPregled> VratiSvaParkingMesta()
        {
            List<ParkingMestoPregled> parkingMesta = new List<ParkingMestoPregled>();

            try
            {
                ISession session = DataLayer.GetSession();
                IEnumerable<ParkingMesto> sviParkingzi = from o in session.Query<ParkingMesto>()
                    select o;

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

                ParkingMesto parkingMesto;
                if (novoParkingMesto.ParkingMestoType == "NaUlici")
                {
                    parkingMesto = new NaUlici();
                }
                else if (novoParkingMesto.ParkingMestoType == "JavnoParkingMesto")
                {
                    parkingMesto = new JavnoParkingMesto();
                }
                else
                {
                    MessageBox.Show("Tip parking mesta nije validan");
                    return;
                }

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

        #region BrojeviTelefona

        public static OsobaTelefon VratiTelefon(int index)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                OsobaTelefon telefon = session.Get<OsobaTelefon>(index);
                return telefon;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

        }

        public static List<BrojTelefonaPregled> VratiBrojeve(int idOsobe)
        {
            List<BrojTelefonaPregled> brojeviTelefona = new List<BrojTelefonaPregled>();

            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<OsobaTelefon> sveOsobeTelefoni = from ot in session.Query<OsobaTelefon>()
                                                     where ot.Osoba.ID == idOsobe select ot;

                foreach (OsobaTelefon telefon in sveOsobeTelefoni)
                {
                    brojeviTelefona.Add(new BrojTelefonaPregled(telefon));
                }

                return brojeviTelefona;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return brojeviTelefona;
            }
        } 

        public static void DodajBrojTelefona(BrojTelefonaBasic noviBrTelefonBasic)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                OsobaTelefon postojiTelefon = session.Get<OsobaTelefon>(noviBrTelefonBasic.Id);

                if (postojiTelefon != null)
                {
                    MessageBox.Show("Vec postoji telefon sa tim id-jem");
                    session.Close();
                    return;
                }

                OsobaTelefon telefon = new OsobaTelefon();

                ObjectCreator.Instance.ToTelefon(telefon, noviBrTelefonBasic);
                session.Save(telefon);

                session.Flush();
                session.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void ObrisiBrojTelefona(int index)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                OsobaTelefon telefon = session.Get<OsobaTelefon>(index);

                if (telefon == null)
                {
                    MessageBox.Show("Ne postoji telefon sa tim id-jem");

                    session.Close();
                    return;
                }

                session.Delete(telefon);
                session.Flush();
                session.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        #endregion

        #region Karte

        public static Karta VratiKartu(int index)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Karta karta = session.Get<Karta>(index);
                return karta;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        public static List<KartaPregled> VratiSveKarte()
        {
            List<KartaPregled> karteList = new List<KartaPregled>();

            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Karta> sveKarte = from ot in session.Query<Karta>()
                    select ot;

                foreach (Karta karta in sveKarte)
                {
                    karteList.Add(new KartaPregled(karta));
                }

                return karteList;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return karteList;
            }
        } 
        
        public static List<KartaPregled> VratiKarte()
        {
            List<KartaPregled> karteList = new List<KartaPregled>();

            try
            {
                ISession session = DataLayer.GetSession();

                List<Pretplatna> sveKarte = session.Query<Karta>()
                    .OfType<Pretplatna>()
                    .ToList();

                foreach (Pretplatna karta in sveKarte)
                {
                    karteList.Add(new KartaPregled(karta));
                }

                return karteList;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return karteList;
            }
        } 

        public static void AzurirajKartu(KartaBasic novaKarta)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                Karta karta = session.Get<Karta>(novaKarta.SerijskiBroj);

                if (karta == null)
                {
                    MessageBox.Show("Ne postoji karta sa tim id-jem");
                    session.Close();
                    return;
                }

                karta = ObjectCreator.Instance.ToKarta(karta, novaKarta);
                session.Update(karta);

                session.Flush();
                session.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        
         public static void DodajKartu(KartaBasic novaKarta)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                Karta postojiKarta = session.Get<Karta>(novaKarta.SerijskiBroj);
                if (postojiKarta != null)
                {
                    MessageBox.Show("Vec postoji karta sa tim serijskim brojem");
                    session.Close();
                    return;
                }

                Karta karta = new Pretplatna(); 
                
                ObjectCreator.Instance.ToKarta(karta, novaKarta);
                session.Save(karta);

                session.Flush();
                session.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void ObrisiKartu(int index)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();
                Karta karta = session.Get<Karta>(index);

                if (karta == null)
                {
                    MessageBox.Show("Ne postoji osoba sa tim id-jem");

                    session.Close();
                    return;
                }

                session.Delete(karta);
                session.Flush();
                session.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region IskorisceneKarte


        public static IskoriscenaKarta VratiIskoriscenuKartu(int index)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                IskoriscenaKarta karta = session.Get<IskoriscenaKarta>(index);
                return karta;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }


        public static List<IskoriscenaKartaPregled> VratiIskorisceneKarte()
        {
            List<IskoriscenaKartaPregled> ikarte = new List<IskoriscenaKartaPregled>();

            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                IEnumerable<IskoriscenaKarta> iskoriscenekarte = from o in session.Query<IskoriscenaKarta>()
                                                select o;

                foreach (IskoriscenaKarta iskoriscenakarta in iskoriscenekarte)
                {
                    ikarte.Add(new IskoriscenaKartaPregled(iskoriscenakarta));
                }

                return ikarte;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return ikarte;
            }
        }
        
        public static void DodajIskoriscenuKartu(IskoriscenaKartaBasic novaIskoriscenaKarta)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                IskoriscenaKarta iskoriscenaKarta = session.Get<IskoriscenaKarta>(novaIskoriscenaKarta.Id);

                if (iskoriscenaKarta != null)
                {
                    MessageBox.Show("Vec postoji zakup sa tim id-jem");
                    session.Close();
                    return;
                }

                IskoriscenaKarta dodjIskoriscenaKarta = new IskoriscenaKarta();

                ObjectCreator.Instance.ToIskoriscenaKarta(dodjIskoriscenaKarta, novaIskoriscenaKarta);
                
                session.Save(dodjIskoriscenaKarta);
                session.Flush();
                session.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void ObrisiIskoriscenuKartu(int index)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                IskoriscenaKarta iskoriscenaKarta = session.Get<IskoriscenaKarta>(index);

                if (iskoriscenaKarta == null)
                {
                    MessageBox.Show("Ne postoji telefon sa tim id-jem");

                    session.Close();
                    return;
                }

                session.Delete(iskoriscenaKarta);
                session.Flush();
                session.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region Zakup

        public static Zakup VratiZakup(int index)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Zakup zakup = session.Get<Zakup>(index);
                return zakup;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        public static List<ZakupPregled> VratiZakupe()
        {
            List<ZakupPregled> karteList = new List<ZakupPregled>();

            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Zakup> sviZakupi = from o in session.Query<Zakup>()
                    select o;


                foreach (Zakup zakup in sviZakupi)
                {
                    karteList.Add(new ZakupPregled(zakup));
                }

                return karteList;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return karteList;
            }
        } 


        public static void DodajZakup(ZakupBasic noviZakup)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                Zakup postojiZakup = session.Get<Zakup>(noviZakup.Id);

                if (postojiZakup != null)
                {
                    MessageBox.Show("Vec postoji zakup sa tim id-jem");
                    session.Close();
                    return;
                }

                Zakup zakup = new Zakup();

                ObjectCreator.Instance.ToZakup(zakup, noviZakup);
                
                session.Save(zakup);
                session.Flush();

                //using (var transaction = session.BeginTransaction())
                //{
                //    session.Save(zakup);
                //    session.Flush();
                //    transaction.Commit();
                //}

                //using (var transaction = session.BeginTransaction())
                //{
                //    zakup.ParkingMesto.TrenutniStatus = "Zauzeto";
                //    session.SaveOrUpdate(zakup.ParkingMesto);
                //    session.Flush();
                //    transaction.Commit();
                //}

                session.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
         
        public static void ObrisiZakup(int index)
        {
            try
            {
                NHibernate.ISession session = DataLayer.GetSession();

                Zakup zakup = session.Get<Zakup>(index);

                if (zakup == null)
                {
                    MessageBox.Show("Ne postoji zakup sa tim id-jem");
                    
                    session.Close();
                    return;
                }

                session.Delete(zakup);
                session.Flush();
                session.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region Zone
        public static KartaZone VratiZonu(int index)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                KartaZone zone = session.Get<KartaZone>(index);
                return zone;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

        }

        public static List<ZonePregled> VratiZone(int idZone)
        {
            List<ZonePregled> zone = new List<ZonePregled>();

            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<KartaZone> svezone = from ot in session.Query<KartaZone>()
                                                             where ot.Karta.SerijskiBroj == idZone
                                                             select ot;

                foreach (KartaZone z in svezone)
                {
                    MessageBox.Show(z.Zona);
                    zone.Add(new ZonePregled(z));
                }

                return zone;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return zone;
            }
        }
        #endregion

    }
}
