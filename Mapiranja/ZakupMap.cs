using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CREATE TABLE Zakup (
//    IDOsobe NUMBER,
//    RegistarskiBrojVozila NVARCHAR2(7),
//    IDParkingMesta NUMBER,
//    OdVreme TIMESTAMP NOT NULL,
//    DoVreme TIMESTAMP NOT NULL,
//    DatumPotpisa DATE NOT NULL,
//    FOREIGN KEY (IDOsobe) REFERENCES Osoba(ID),
//    FOREIGN KEY (IDParkingMesta) REFERENCES ParkingMesto(ID),
//    FOREIGN KEY (RegistarskiBrojVozila) REFERENCES Vozilo(RegistarskiBroj),
//    CONSTRAINT CheckVremeZakup CHECK(DoVreme > OdVreme),
//    CONSTRAINT PK_Zakup PRIMARY KEY(IDOsobe, RegistarskiBrojVozila, IDParkingMesta)
//);

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

            Map(x => x.OdVreme, "OdVreme").Not.Nullable();
            Map(x => x.DoVreme, "DoVreme").Not.Nullable();
            Map(x => x.DatumPotpisa, "DatumPotpisa").Not.Nullable();

            //HasMany(x => x.ListVozila).Cascade.All().KeyColumn("RegistarskiBrojVozila");
            //HasMany(x => x.ListParkingMesta).Cascade.All().KeyColumn("IDParkingMesta");

            //CheckConstraint("DoVreme > OdVreme");
        }
    }
}
