using System;
using System.Net.Configuration;
using System.Windows.Forms;
using ParkingServis.Entiteti;

namespace ParkingServis.Forms
{
    public partial class IzmeniOsobu : Form
    {
        private int idOsobe;
        private OsobeForm osobeForm;

        public IzmeniOsobu(OsobeForm osobeForm, int idOsobe)
        {
            InitializeComponent();

            this.osobeForm = osobeForm;
            this.idOsobe = idOsobe;
        }

        private void IzmeniOsobu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var parking = DTOManager.VratiOsobu(idOsobe);

            if (parking == null)
            {
                MessageBox.Show("Ne postoji osoba sa tim id-jem");

                textAdresa.Text = "";
                textLicnoIme.Text = "";
                textImeRoditelja.Text = "";
                textPrezime.Text = "";
                textJMBG.Text = "";
                textBrojLicneKarte.Text = "";
                textMestoIzdanjaLicne.Text = "";
                textBrojVozackeDozvole.Text = "";
                textZona.Text = "";

                textPIB.Text = "";
                textNaziv.Text = "";

                return;
            }

            numericID.Value = parking.ID;
            textAdresa.Text = parking.Adresa;
            textLicnoIme.Text = parking.LicnoIme;
            textImeRoditelja.Text = parking.ImeRoditelja;
            textPrezime.Text = parking.Prezime;
            textJMBG.Text = parking.JMBG;
            textBrojLicneKarte.Text = parking.BrojLicneKarte;
            textMestoIzdanjaLicne.Text = parking.MestoIzdavanjaLicne;
            textBrojVozackeDozvole.Text = parking.BrojVozackeDozvole;
            textZona.Text = parking.ZiviUZoni;

            textPIB.Text = parking.PIB;
            textNaziv.Text = parking.Naziv;
        }

        private void numericID_ValueChanged(object sender, EventArgs e)
        {
            this.idOsobe = Convert.ToInt32(numericID.Value);
            LoadData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Osoba osoba = DTOManager.VratiOsobu(idOsobe);
            if (osoba == null)
            {
                MessageBox.Show("Osoba sa tim id-jem ne postoji");
                return;
            }

            string osobaType;
            if (osoba.Naziv == null)
            {
                osobaType = "PravnoLice";
            }
            else
            {
                osobaType = "PrivatnoLice";
            }

            MessageBox.Show(osoba.OsobaType + " " + osobaType);

            //string osobaType = (osoba.Naziv != null) 

            //OsobaBasic novaOsoba = new OsobaBasic(Convert.ToInt32(numericID.Value), textAdresa.Text, textLicnoIme.Text,
            //    textImeRoditelja.Text, textPrezime.Text, textJMBG.Text, textBrojLicneKarte.Text,
            //    textMestoIzdanjaLicne.Text, textBrojVozackeDozvole.Text, textZona.Text, textPIB.Text, textNaziv.Text,
            //    osobaType);

            //var noviParking = new ParkingBasic(Convert.ToInt32(inputID.Value), inputMontazniObjekat.Text, textZona.Text,
            //    textAdresa.Text, OdVreme.Value,
            //    DoVreme.Value, Convert.ToInt32(inputBrojParkingMesta.Value), textNaziv.Text, inputTipParkinga.Text,
            //    Convert.ToInt32(inputNivoi.Value), Convert.ToInt32(inputSpratovi.Value));

            //DTOManager.AzurirajOsobu(nova);
            //activeParkingForm.PopulateListView();
        }
    }
}