using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Mapiranja
{
    public class OsobaTelefonMap : ClassMap<OsobaTelefon>
    {
        public OsobaTelefonMap()
        {
            Table("OsobaTelefon");
            CompositeId()
                .KeyReference(x => x.Osoba, "IDOsobe")
                .KeyProperty(x => x.Telefon);
            Map(x => x.Telefon).Unique();
        }
    }
}
