using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Zakup
    {
        public virtual DateTime OdVreme { get; set; }
        public virtual DateTime DoVreme { get; set; }
        public virtual DateTime DatumPotpisa { get; set; }

        public virtual Osoba Osoba { get; set; }
        public virtual IList<Vozilo> ListVozila { get; set; }
        public virtual IList<ParkingMesto> ListParkingMesta { get; set; }

        public Zakup()
        {
            ListVozila = new List<Vozilo>();
            ListParkingMesta = new List<ParkingMesto>();
        }
    }



}
