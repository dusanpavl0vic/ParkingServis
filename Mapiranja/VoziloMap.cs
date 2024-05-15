using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Mapiranja
{
    public class VoziloMap : ClassMap<Vozilo>
    {
        public VoziloMap()
        {
            Table("Vozilo");
            Id(x => x.RegistarskiBroj);
            Map(x => x.BrojSaobracajneDozvole).Not.Nullable().Unique();
            Map(x => x.Proizvodjac).Not.Nullable();
            Map(x => x.Model).Not.Nullable();
            HasOne(x => x.Zakup).Cascade.All();
        }
    }
}
