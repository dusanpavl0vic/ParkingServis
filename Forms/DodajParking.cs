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

        private void DodajParking_Load(object sender, EventArgs e)
        {
            inputNivoi.Hide();
            inputSpratovi.Hide();

            labelSpratovi.Hide();
            labelNivoi.Hide();
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

        private void inputTipParkinga_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inputTipParkinga.Text == "Podzemna")
            {
                inputSpratovi.Hide();
                inputNivoi.Show();

                labelSpratovi.Hide();
                labelNivoi.Show();
            }
            else if (inputTipParkinga.Text == "Nadzemna") 
            {
                inputSpratovi.Show();
                inputNivoi.Hide();

                labelSpratovi.Show();
                labelNivoi.Hide();
            }
        }
    }
}