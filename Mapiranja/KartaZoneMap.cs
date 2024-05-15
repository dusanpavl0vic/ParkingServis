using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Mapiranja
{
    public class KartaZoneMap : ClassMap<KartaZone>
    {
        public KartaZoneMap()
        {
            Table("KartaZone");
            CompositeId()
                .KeyReference(x => x.Karta, "SerijskiBrojKarte")
                .KeyProperty(x => x.Zona);
        }
    }
}
