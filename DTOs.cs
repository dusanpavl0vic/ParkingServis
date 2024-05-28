using System;
using ParkingServis.Entiteti;

namespace ParkingServis
{
    public class ParkingPregled
    {
        public string Adresa;
        public int BrojParkingMesta;
        public DateTime DoVreme;
        public int Id;
        public string Naziv;
        public DateTime OdVreme;
        public string Zona;

        public ParkingPregled(Parking parking)
        {
            Id = parking.ID;
            Naziv = parking.Naziv;
            Zona = parking.Zona;
            Adresa = parking.Adresa;
            OdVreme = parking.OdVreme;
            DoVreme = parking.DoVreme;
            BrojParkingMesta = parking.BrojParkingMesta;
        }

        public string[] GetListViewItem()
        {
            return new[]
            {
                Id.ToString(),
                Naziv,
                Zona,
                Adresa,
                OdVreme.ToString(),
                DoVreme.ToString(),
                BrojParkingMesta.ToString()
            };
        }
    }


    public class VoziloPregled
    {
        public string BrojSaobracajneDozvole;
        public string Model;
        public string Proizvodjac;
        public string RegistarskiBroj;

        public VoziloPregled(Vozilo vozilo)
        {
            RegistarskiBroj = vozilo.RegistarskiBroj;
            BrojSaobracajneDozvole = vozilo.BrojSaobracajneDozvole;
            Proizvodjac = vozilo.Proizvodjac;
            Model = vozilo.Model;
        }

        public string[] GetListViewItem()
        {
            return new[]
            {
                RegistarskiBroj,
                BrojSaobracajneDozvole,
                Proizvodjac,
                Model
            };
        }
    }


    public class ParkingBasic
    {
        public string Adresa;
        public int BrojParkingMesta;
        public DateTime DoVreme;
        public int ID;
        public string MontazniObjekat;
        public string Naziv;
        public int? Nivoi;
        public DateTime OdVreme;
        public string ParkingType;
        public int? Spratovi;
        public string Zona;

        public ParkingBasic(Parking parking)
        {
            ID = parking.ID;
            MontazniObjekat = parking.MontazniObjekat;
            Zona = parking.Zona;
            Adresa = parking.Adresa;
            OdVreme = parking.OdVreme;
            DoVreme = parking.DoVreme;
            BrojParkingMesta = parking.BrojParkingMesta;
            Naziv = parking.Naziv;
            ParkingType = parking.ParkingType;
            Spratovi = parking.Spratovi;
            Nivoi = parking.Nivoi;
        }

        public ParkingBasic(int ID, string MontazniObjekat, string Zona, string Adresa, DateTime OdVreme,
            DateTime DoVreme,
            int BrojParkingMesta, string Naziv, string ParkingType, int? Nivoi, int? Spratovi)
        {
            this.ID = ID;
            this.MontazniObjekat = MontazniObjekat;
            this.Zona = Zona;
            this.Adresa = Adresa;
            this.OdVreme = OdVreme;
            this.DoVreme = DoVreme;
            this.BrojParkingMesta = BrojParkingMesta;
            this.Naziv = Naziv;
            this.ParkingType = ParkingType;
            this.Nivoi = ParkingType == "Podzemna" ? Nivoi : null;
            this.Spratovi = ParkingType == "Nadzemna" ? Spratovi : null;
        }
    }


    public class VoziloBasic
    {
        public string BrojSaobracajneDozvole;
        public string Model;
        public string Proizvodjac;
        public string RegistarskiBroj;

        public VoziloBasic(Vozilo vozilo)
        {
        }

        public string[] GetListViewItem()
        {
            return new[]
            {
                RegistarskiBroj,
                BrojSaobracajneDozvole,
                Proizvodjac,
                Model
            };
        }
    }
}

//public virtual string MontazniObjekat { get; set; }
//public virtual string Zona { get; set; }
//public virtual string Adresa { get; set; }
//public virtual DateTime OdVreme { get; set; }
//public virtual DateTime DoVreme { get; set; }
//public virtual int BrojParkingMesta { get; set; }
//public virtual string Naziv { get; set; }
//public virtual string ParkingType { get; set; }
//public virtual int? Spratovi { get; set; }
//public virtual int? Nivoi { get; set; }