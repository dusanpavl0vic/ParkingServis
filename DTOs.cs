using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
        public int Id;
        public string RegistarskiBroj;
        public string BrojSaobracajneDozvole;
        public string Model;
        public string Proizvodjac;

        public VoziloPregled(Vozilo vozilo)
        {
            this.Id = vozilo.Id;
            this.RegistarskiBroj = vozilo.RegistarskiBroj;
            this.BrojSaobracajneDozvole = vozilo.BrojSaobracajneDozvole;
            this.Proizvodjac = vozilo.Proizvodjac;
            this.Model = vozilo.Model;
        }

        public string[] GetListViewItem()
        {
            return new[]
            {
                this.Id.ToString(),
                this.RegistarskiBroj,
                this.BrojSaobracajneDozvole,
                this.Proizvodjac,
                this.Model
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
        public int Id;
        public string RegistarskiBroj;
        public string BrojSaobracajneDozvole;
        public string Model;
        public string Proizvodjac;

        public VoziloBasic(Vozilo vozilo)
        {
        }
        public VoziloBasic()
        {

        }
        public string[] GetListViewItem()
        {
            return new[]
            {
                this.Id.ToString(),
                this.RegistarskiBroj,
                this.BrojSaobracajneDozvole,
                this.Proizvodjac,
                this.Model
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