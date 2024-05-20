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
            if (ReferenceEquals(this, obj))
                return true;

            if (obj == null || GetType() != obj.GetType())
                return false;

            IskoriscenaKartaId other = (IskoriscenaKartaId)obj;

            return Karta.SerijskiBroj == other.Karta.SerijskiBroj &&
                   IskoriscenaKarta.VremeIzvrseneKontrole == other.IskoriscenaKarta.VremeIzvrseneKontrole;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Karta.SerijskiBroj.GetHashCode();
                hash = hash * 23 + IskoriscenaKarta.VremeIzvrseneKontrole.GetHashCode();
                return hash;
            }
        }
    }
}
