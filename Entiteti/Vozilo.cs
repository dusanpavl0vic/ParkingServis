using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Vozilo
    {
        public virtual string RegistarskiBroj { get; set; }
        public virtual string BrojSaobracajneDozvole { get; set; }
        public virtual string Proizvodjac { get; set; }
        public virtual string Model { get; set; }

        // strani kljucevi
        public virtual Karta VoziloZaPretplatnu { get; set; }
        public virtual IskoriscenaKarta IskoriscenaKarta { get; set; }
        public virtual IList<Zakup> ListaZakupa { get; set; }

        public Vozilo()
        {
            this.ListaZakupa = new List<Zakup>();
        }
    }
}
