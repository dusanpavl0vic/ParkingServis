using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class OsobaTelefonId
    {
        public virtual OsobaTelefon OsobaTelefon{ get; set; }
        public virtual Osoba Osoba { get; set; }
        public override bool Equals(object obj) {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(OsobaTelefonId))
                return false;

            OsobaTelefonId recievedObject = (OsobaTelefonId)obj;

            if ((OsobaTelefon.Telefon == recievedObject.OsobaTelefon.Telefon) && (Osoba.ID == recievedObject.Osoba.ID))
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
