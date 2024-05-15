using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class IskoriscenaKarta
    {
        public virtual DateTime VremeIzvrseneKontrole { get; set; }
        public virtual DateTime OdVreme { get; set; }
        public virtual DateTime DoVreme { get; set; }
        public virtual Vozilo Vozilo { get; set; }
        public virtual ParkingMesto ParkingMesto { get; set; }
        public virtual Karta Karta { get; set; }
    }
}
