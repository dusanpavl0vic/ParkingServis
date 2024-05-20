using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class IskoriscenaKartaId
    {
        public virtual Karta Karta { get; set; }
        public virtual IskoriscenaKarta IskoriscenaKarta { get; set; }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(IskoriscenaKartaId))
                return false;

            IskoriscenaKartaId recievedObject = (IskoriscenaKartaId)obj;

            if ((IskoriscenaKarta.VremeIzvrseneKontrole == recievedObject.IskoriscenaKarta.VremeIzvrseneKontrole) && (Karta.SerijskiBroj == recievedObject.Karta.SerijskiBroj))
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
