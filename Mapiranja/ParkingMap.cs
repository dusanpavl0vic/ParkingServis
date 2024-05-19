using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CREATE TABLE Parking (
//    ID NUMBER PRIMARY KEY,
//    MontazniObjekat NVARCHAR2(30) NOT NULL,
//    Zona NVARCHAR2(20) NOT NULL,
//    Adresa NVARCHAR2(30) NOT NULL,
//    OdVreme TIMESTAMP NOT NULL,
//    DoVreme TIMESTAMP NOT NULL,
//    BrojParkingMesta NUMBER NOT NULL,
//    Naziv NVARCHAR2(30) NOT NULL,
//    PARKINGTYPE NVARCHAR2(20) NOT NULL,
//    Spratovi NUMBER,
//    Nivoi NUMBER,
//    CONSTRAINT CheckBPM CHECK(BrojParkingMesta > 0),
//    CONSTRAINT CheckVreme CHECK(DoVreme > OdVreme),
//    CONSTRAINT CheckPType CHECK(PARKINGTYPE in ('Nadzemna', 'Podzemna')),
//    CONSTRAINT CheckMO CHECK(MontazniObjekat in ('Montazni', 'NijeMontazni'))
//);

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
