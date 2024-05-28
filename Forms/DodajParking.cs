using System;
using System.Windows.Forms;

namespace ParkingServis.Forms
{
    public partial class DodajParking : Form
    {
        private ParkingForm activeParkingForm;
        public DodajParking(ParkingForm activeParkingForm)
        {
            this.activeParkingForm = activeParkingForm;
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var noviParking = new ParkingBasic(Convert.ToInt32(inputID.Value), inputMontazniObjekat.Text, textZona.Text, textAdresa.Text, OdVreme.Value,
                DoVreme.Value, Convert.ToInt32(inputBrojParkingMesta.Value), textNaziv.Text, inputTipParkinga.Text,
                Convert.ToInt32(inputNivoi.Value), Convert.ToInt32(inputSpratovi.Value));

            DTOManager.DodajParking(noviParking);

            activeParkingForm.PopulateListView();

            //public ParkingBasic(string MontazniObjekat, string Zona, string Adresa, DateTime OdVreme, DateTime DoVreme,
            //    int BrojParkingMesta, string Naziv, string ParkingType, int? Nivoi, int? Spratovi)
        }
    }
}