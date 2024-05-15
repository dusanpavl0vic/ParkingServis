using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Mapiranja
{
    public class ParkingMap : ClassMap<Parking>
    {
        public ParkingMap()
        {
            Table("Parking");
            Id(x => x.ID);
            Map(x => x.MontazniObjekat).CustomType<EnumMontazniObjekat>().Not.Nullable();
            Map(x => x.Zona).Not.Nullable();
            Map(x => x.Adresa).Not.Nullable();
            Map(x => x.OdVreme).Not.Nullable();
            Map(x => x.DoVreme).Not.Nullable();
            Map(x => x.BrojParkingMesta).Not.Nullable();
            Map(x => x.Naziv).Not.Nullable();
            Map(x => x.ParkingType).CustomType<EnumParkingType>().Not.Nullable();
            Map(x => x.Spratovi);
            Map(x => x.Nivoi);
            HasMany(x => x.ListaParkingMesta).Cascade.All().KeyColumn("IDParkinga");
            CheckConstraint("BrojParkingMesta > 0");
            CheckConstraint("DoVreme > OdVreme");
            CheckConstraint("PARKINGTYPE in ('Nadzemna', 'Podzemna')");
            CheckConstraint("MontazniObjekat in ('Montazni', 'NijeMontazni')");
        }
    }
}
