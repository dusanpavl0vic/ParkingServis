using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class OsobaTelefon
    {
        public virtual OsobaTelefonId Id { get; set; }
        public virtual string Telefon { get; set; }

        public virtual Osoba Osoba { get; set; }

        public OsobaTelefon()
        {
            Id = new OsobaTelefonId();
        }
    }

}
