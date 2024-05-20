﻿using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CREATE TABLE Vozilo (
//    RegistarskiBroj NVARCHAR2(7) PRIMARY KEY,
//    BrojSaobracajneDozvole NVARCHAR2(14) NOT NULL UNIQUE,
//    Proizvodjac NVARCHAR2(30) NOT NULL,
//    Model NVARCHAR2(30) NOT NULL
//);

namespace ParkingServis.Mapiranja
{
    public class VoziloMap : ClassMap<Vozilo>
    {
        public VoziloMap()
        {
            Table("Vozilo");

            Id(x => x.RegistarskiBroj).Column("RegistarskiBroj").GeneratedBy.Assigned();
            
            Map(x => x.BrojSaobracajneDozvole, "BrojSaobracajneDozvole").Not.Nullable().Unique();
            Map(x => x.Proizvodjac, "Proizvodjac").Not.Nullable();
            Map(x => x.Model, "Model").Not.Nullable();

            HasOne(x => x.VoziloZaPretplatnu).Constrained().Cascade.All(); ;

            //HasOne(x => x.Zakup).Cascade.All();
        }
    }
}
