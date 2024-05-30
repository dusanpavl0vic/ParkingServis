using ParkingServis.Entiteti;

namespace ParkingServis
{
    internal class ObjectCreator
    {
        private ObjectCreator()
        {
        }

        public static ObjectCreator Instance { get; } = new ObjectCreator();


        public Vozilo ToVozilo(Vozilo vozilo, VoziloBasic voziloBasic)
        {
            vozilo.Id = voziloBasic.Id;
            vozilo.RegistarskiBroj = voziloBasic.RegistarskiBroj;
            vozilo.BrojSaobracajneDozvole = voziloBasic.BrojSaobracajneDozvole;
            vozilo.Model = voziloBasic.Model;
            vozilo.Proizvodjac = voziloBasic.Proizvodjac;

            return vozilo;
        }

        public Parking ToParking(Parking parking, ParkingBasic parkingBasic)
        {
            parking.ID = parkingBasic.ID;
            parking.MontazniObjekat = parkingBasic.MontazniObjekat;
            parking.Zona = parkingBasic.Zona;
            parking.Adresa = parkingBasic.Adresa;
            parking.OdVreme = parkingBasic.OdVreme;
            parking.DoVreme = parkingBasic.DoVreme;
            parking.BrojParkingMesta = parkingBasic.BrojParkingMesta;
            parking.Naziv = parkingBasic.Naziv;
            parking.ParkingType = parkingBasic.ParkingType;

            if (parkingBasic.ParkingType == "Podzemna")
            {
                parking.Nivoi = parkingBasic.Nivoi;
            }
            else if (parkingBasic.ParkingType == "Nadzemna")
            {
                parking.Spratovi = parkingBasic.Spratovi;
            }

            return parking;
        }


        public ParkingMesto ToParkingMesto(ParkingMesto parking, ParkingMestoBasic parkingBasic)
        {
            parking.ID = parkingBasic.ID;
            parking.TrenutniStatus = parkingBasic.TrenutniStatus;
            parking.ParkingMestoType = parkingBasic.ParkingMestoType;
            parking.NazivUlice = parkingBasic.NazivUlice;
            parking.Zona = parkingBasic.Zona;
            parking.RedniBroj = parkingBasic.RedniBroj;
            parking.Sprat = parkingBasic.Sprat;
            parking.PripadaParkingu = parkingBasic.PripadaParkingu;

            return parking;
        }

        public Osoba ToOsoba(Osoba osoba, OsobaBasic osobaBasic)
        {
            osoba.ID = osobaBasic.ID;
            osoba.Adresa = osobaBasic.Adresa;
            osoba.LicnoIme = osobaBasic.LicnoIme;
            osoba.ImeRoditelja = osobaBasic.ImeRoditelja;
            osoba.Prezime = osobaBasic.Prezime;


            if (osobaBasic.OsobaType == "FizickoLice")
            {
                osoba.JMBG = osobaBasic.JMBG;
                osoba.BrojLicneKarte = osobaBasic.BrojLicneKarte;
                osoba.MestoIzdavanjaLicne = osobaBasic.MestoIzdavanjaLicne;
                osoba.BrojVozackeDozvole = osobaBasic.BrojVozackeDozvole;
                osoba.ZiviUZoni = osobaBasic.ZiviUZoni;
            }

            if (osobaBasic.OsobaType == "PravnoLice")
            {
                osoba.PIB = osobaBasic.PIB;
                osoba.Naziv = osobaBasic.Naziv;
            }

            return osoba;
        }

        public Karta ToKarta(Karta karta, KartaBasic kartaBasic)
        {
            karta.SerijskiBroj = kartaBasic.SerijskiBroj;
            karta.KartaType = kartaBasic.KartaType;
            karta.Datum = kartaBasic.Datum;
            karta.OdVreme = kartaBasic.OdVreme;
            karta.DoVreme = kartaBasic.DoVreme;
            karta.ProdajaOsobi = kartaBasic.ProdajaOsobi;
            karta.OdnosiNaVozilo = kartaBasic.OdnosiSeNaVozilo;

            return karta;
        }
    }
}