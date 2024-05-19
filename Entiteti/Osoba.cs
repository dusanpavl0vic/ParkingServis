using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public enum EnumOsobaType
    {
        FizickoLice,
        PravnoLice
    }

    public abstract class Osoba
    {
        public virtual int ID { get; set; }
        public virtual string Adresa { get; set; }
        public virtual EnumOsobaType OsobaType { get; set; }
        public virtual string LicnoIme { get; set; }
        public virtual string ImeRoditelja { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string JMBG { get; set; }
        public virtual string BrojLicneKarte { get; set; }
        public virtual string MestoIzdavanjaLicne { get; set; }
        public virtual string BrojVozackeDozvole { get; set; }
        public virtual string ZiviUZoni { get; set; }
        public virtual string PIB { get; set; }
        public virtual string Naziv { get; set; }

        public virtual IList<OsobaTelefon> ListTelefoni { get; set; }
        public virtual IList<Karta> KupovinaPretplatne { get; set; }
        public virtual IList<Zakup> ZakupljenaParkingMesta { get; set; }

        public Osoba()
        {
            ListTelefoni = new List<OsobaTelefon>();
            KupovinaPretplatne = new List<Karta>();
            ZakupljenaParkingMesta = new List<Zakup>();
        }
    }

    public class FizickoLice : Osoba
    {

    }
    public class PravnoLice : Osoba
    {

    }

}
