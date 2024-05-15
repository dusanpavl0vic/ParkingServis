using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Mapiranja
{
    public class KartaMap : ClassMap<Karta>
    {
        public KartaMap()
        {
            Table("Karta");
            Id(x => x.SerijskiBroj);
            Map(x => x.KartaType).CustomType<EnumKartaType>().Not.Nullable();
            Map(x => x.Datum);
            Map(x => x.OdVreme);
            Map(x => x.DoVreme);
            Map(x => x.RegistarskiBrojVozila);
            References(x => x.Osoba, "IDOsobe");
            References(x => x.Vozilo, "RegistarskiBrojVozila");
            HasOne(x => x.IskoriscenaKarta).Cascade.All();
            CheckConstraint("DoVreme > OdVreme");
        }
    }
}
