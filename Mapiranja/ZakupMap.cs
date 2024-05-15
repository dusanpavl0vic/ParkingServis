using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Mapiranja
{
    public class ZakupMap : ClassMap<Zakup>
    {
        public ZakupMap()
        {
            Table("Zakup");
            CompositeId()
                .KeyReference(x => x.Osoba, "IDOsobe")
                .KeyReference(x => x.ListVozila, "RegistarskiBrojVozila")
                .KeyReference(x => x.ListParkingMesta, "IDParkingMesta");
            Map(x => x.OdVreme).Not.Nullable();
            Map(x => x.DoVreme).Not.Nullable();
            Map(x => x.DatumPotpisa).Not.Nullable();
            HasMany(x => x.ListVozila).Cascade.All().KeyColumn("RegistarskiBrojVozila");
            HasMany(x => x.ListParkingMesta).Cascade.All().KeyColumn("IDParkingMesta");
            CheckConstraint("DoVreme > OdVreme");
        }
    }
}
