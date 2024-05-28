using ParkingServis.Entiteti;

namespace ParkingServis
{
    internal class ObjectCreator
    {
        private ObjectCreator()
        {
        }

        public static ObjectCreator Instance { get; } = new ObjectCreator();

        public Parking ToParking(Parking parking, ParkingBasic parkingBasic)
        {
            parking.ID = parkingBasic.ID;
            parking.MontazniObjekat = parkingBasic.MontazniObjekat;
            parking.Zona = parkingBasic.Zona;
            parking.Adresa = parkingBasic.Adresa;
            parking.OdVreme = parkingBasic.OdVreme;
            parking.DoVreme = parkingBasic.DoVreme;
            parking.BrojParkingMesta = parkingBasic.BrojParkingMesta;
            parking.Naziv = parkingBasic.Naziv;
            parking.ParkingType = parkingBasic.ParkingType;
            parking.Spratovi = parkingBasic.Spratovi;
            parking.Nivoi = parkingBasic.Nivoi;

            return parking;
        }
    }
}