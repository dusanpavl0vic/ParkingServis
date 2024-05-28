using System;
using System.Windows.Forms;

namespace ParkingServis.Forms
{
    public partial class IzmeniParking : Form
    {
        private readonly ParkingForm activeParkingForm;
        private int selectedParking;

        public IzmeniParking(ParkingForm activeParkingForm, int id)
        {
            this.activeParkingForm = activeParkingForm;
            selectedParking = id;
            InitializeComponent();
        }

        private void IzmeniParking_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var parking = DTOManager.VratiParking(selectedParking);

            if (parking == null)
            {
                MessageBox.Show("Ne postoji parking sa tim id-jem");

                textNaziv.Text = "";
                textAdresa.Text = "";
                textZona.Text = "";
                inputMontazniObjekat.Text = "";
                inputTipParkinga.Text = "";
                inputSpratovi.Value = 0;
                inputNivoi.Value = 0;
                inputBrojParkingMesta.Value = 0;

                return;
            }

            inputID.Value = parking.ID;
            textNaziv.Text = parking.Naziv;
            textAdresa.Text = parking.Adresa;
            textZona.Text = parking.Zona;
            OdVreme.Value = parking.OdVreme;
            DoVreme.Value = parking.DoVreme;
            inputMontazniObjekat.Text = parking.MontazniObjekat;
            inputTipParkinga.Text = parking.ParkingType;
            inputSpratovi.Value = Convert.ToDecimal(parking.Spratovi);
            inputNivoi.Value = Convert.ToDecimal(parking.Nivoi);
            inputBrojParkingMesta.Value = parking.BrojParkingMesta;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var parking = DTOManager.VratiParking(selectedParking);
            if (parking == null)
            {
                MessageBox.Show("Parking sa tim id-jem ne postoji");
                return;
            }

            var noviParking = new ParkingBasic(Convert.ToInt32(inputID.Value), inputMontazniObjekat.Text, textZona.Text,
                textAdresa.Text, OdVreme.Value,
                DoVreme.Value, Convert.ToInt32(inputBrojParkingMesta.Value), textNaziv.Text, inputTipParkinga.Text,
                Convert.ToInt32(inputNivoi.Value), Convert.ToInt32(inputSpratovi.Value));

            DTOManager.AzurirajParking(noviParking);
            activeParkingForm.PopulateListView();
        }

        private void inputID_ValueChanged(object sender, EventArgs e)
        {
            selectedParking = Convert.ToInt32(inputID.Value);
            LoadData();
        }
    }
}