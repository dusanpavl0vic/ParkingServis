using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class KartaZoneId
    {
        public virtual Karta Karta { get; set; }
        public virtual KartaZone KartaZone { get; set; }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(KartaZoneId))
                return false;

            KartaZoneId recievedObject = (KartaZoneId)obj;

            if ((KartaZone.Zona == recievedObject.KartaZone.Zona) && (Karta.SerijskiBroj == recievedObject.Karta.SerijskiBroj))
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
