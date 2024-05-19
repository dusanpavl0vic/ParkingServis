using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CREATE TABLE Osoba (
//    ID NUMBER PRIMARY KEY,
//    Adresa NVARCHAR2(30) NOT NULL,
//    LicnoIme NVARCHAR2(30) NOT NULL,
//    ImeRoditelja NVARCHAR2(30) NOT NULL,
//    Prezime NVARCHAR2(30) NOT NULL,
//    OSOBATYPE NVARCHAR2(20) NOT NULL,
//    JMBG NVARCHAR2(30) UNIQUE,
//    BrojLicneKarte NVARCHAR2(30) UNIQUE,
//    MestoIzdavanjaLicne NVARCHAR2(30),
//    BrojVozackeDozvole NVARCHAR2(30),
//    ZiviUZoni NVARCHAR2(30),
//    PIB NVARCHAR2(30),
//    Naziv NVARCHAR2(30),
//    CONSTRAINT CheckOType CHECK(OSOBATYPE in ('FizickoLice', 'PravnoLice'))
//);

namespace ParkingServis.Mapiranja
{
    public class OsobaMap : ClassMap<Osoba>
    {
        public OsobaMap()
        {
            Table("Osoba");
            Id(x => x.ID);
            Map(x => x.Adresa).Not.Nullable();
            Map(x => x.LicnoIme).Not.Nullable();
            Map(x => x.ImeRoditelja).Not.Nullable();
            Map(x => x.Prezime).Not.Nullable();
            Map(x => x.OsobaType).CustomType<EnumOsobaType>().Not.Nullable();
            Map(x => x.JMBG).Unique();
            Map(x => x.BrojLicneKarte).Unique();
            Map(x => x.MestoIzdavanjaLicne);
            Map(x => x.BrojVozackeDozvole);
            Map(x => x.ZiviUZoni);
            Map(x => x.PIB);
            Map(x => x.Naziv);
            HasMany(x => x.ListTelefoni).Cascade.All().KeyColumn("IDOsobe");
            HasMany(x => x.ListKarte).Cascade.All().KeyColumn("IDOsobe");
            HasMany(x => x.ListZakupa).Cascade.All().KeyColumn("IDOsobe");
            CheckConstraint("OSOBATYPE in ('FizickoLice', 'PravnoLice')");
        }
    }
}
