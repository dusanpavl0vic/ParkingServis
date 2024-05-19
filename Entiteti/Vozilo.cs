﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Vozilo
    {
        public virtual string RegistarskiBroj { get; set; }
        public virtual string BrojSaobracajneDozvole { get; set; }
        public virtual string Proizvodjac { get; set; }
        public virtual string Model { get; set; }
        public virtual Karta VoziloZaPretplatnu { get; set; }
        public Zakup Zakup { get; set; }
    }
}
