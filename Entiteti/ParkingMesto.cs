﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CREATE TABLE ParkingMesto (
//    ID NUMBER PRIMARY KEY,
//    TrenutniStatus NVARCHAR2(30) NOT NULL,
//    PARKINGMESTOTYPE NVARCHAR2(20) NOT NULL,
//    NazivUlice NVARCHAR2(30) NOT NULL,
//    Zona NVARCHAR2(30) NOT NULL,
//    RedniBroj NUMBER,
//    IDParkinga NUMBER,
//    Sprat NUMBER,
//    FOREIGN KEY (IDParkinga) REFERENCES Parking(ID),
//    CONSTRAINT CheckPMType CHECK(PARKINGMESTOTYPE in ('NaUlici', 'JavnoParkingMesto')),
//    CONSTRAINT CheckTS CHECK(TrenutniStatus in ('Zauzeto', 'Slobodno'))
//);

namespace ParkingServis.Entiteti
{
    public enum EnumTrenutniStatus
    {
        Zauzeto,
        Slobodno
    }

    public enum EnumParkingMestoType
    {
        NaUlici,
        JavnoParkingMesto
    }

    public class ParkingMesto
    {
        public virtual int ID { get; set; }
        public virtual EnumTrenutniStatus TrenutniStatus { get; set; }
        public virtual EnumParkingMestoType ParkingMestoType { get; set; }
        public virtual string NazivUlice { get; set; }
        public virtual string Zona { get; set; }
        public virtual int? RedniBroj { get; set; }
        public virtual int? Sprat { get; set; }

        public virtual Parking Parking { get; set; }
        public Zakup Zakup { get; set; }
    }

}
