using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Mapiranja
{
    public class IskoriscenaKartaMap : ClassMap<IskoriscenaKarta>
    {
        public IskoriscenaKartaMap()
        {
            Table("IskoriscenaKarta");
            CompositeId()
                .KeyProperty(x => x.VremeIzvrseneKontrole)
                .KeyReference(x => x.Karta, "SerijskiBroj");
            Map(x => x.OdVreme).Not.Nullable();
            Map(x => x.DoVreme).Not.Nullable();
            References(x => x.Vozilo, "RegistarskiBrojVozila").Not.Nullable();
            References(x => x.ParkingMesto, "IDParkingMesta").Not.Nullable();
            CheckConstraint("DoVreme > OdVreme");
        }
    }
}
