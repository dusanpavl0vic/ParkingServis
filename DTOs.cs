using ParkingServis.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis
{
    public class ParkingPregled
    {
        public int Id;
        public string Naziv;
        public string Zona;
        public string Adresa;
        public DateTime OdVreme;
        public DateTime DoVreme;
        public int BrojParkingMesta;

        public ParkingPregled(Parking parking)
        {
            this.Id = parking.ID;
            this.Naziv = parking.Naziv;
            this.Zona = parking.Zona;
            this.Adresa = parking.Adresa;
            this.OdVreme = parking.OdVreme;
            this.DoVreme = parking.DoVreme;
            this.BrojParkingMesta = parking.BrojParkingMesta;
        }

        public string[] GetListViewItem()
        {
            return new string[]
            {
                this.Id.ToString(),
                this.Naziv,
                this.Zona,
                this.Adresa,
                this.OdVreme.ToString(),
                this.DoVreme.ToString(),
                this.BrojParkingMesta.ToString()
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

