using System;
using System.Windows.Forms;

namespace ParkingServis.Forms
{
    public partial class IzmeniOsobu : Form
    {
        private int idOsobe;
        private readonly OsobeForm osobeForm;

        public IzmeniOsobu(OsobeForm osobeForm, int idOsobe)
        {
            InitializeComponent();

            this.osobeForm = osobeForm;
            this.idOsobe = idOsobe;
        }

        private void IzmeniOsobu_Load(object sender, EventArgs e)
        {
            textNaziv.Hide();
            textPIB.Hide();

            labelNaziv.Hide();
            labelPIB.Hide();

            textJMBG.Hide();
            textBrojLicneKarte.Hide();
            textMestoIzdanjaLicne.Hide();
            textBrojVozackeDozvole.Hide();
            textZona.Hide();

            labelJMBG.Hide();
            labelBrojLicen.Hide();
            labelMestoIzdanjaLicne.Hide();
            labelBrojVozackeDozvole.Hide();
            labelZona.Hide();


            LoadData();
        }

        private void ShowHideInputs(string osobaType)
        {
            if (osobaType == "FizickoLice")
            {
                textNaziv.Hide();
                textPIB.Hide();

                labelNaziv.Hide();
                labelPIB.Hide();

                textJMBG.Show();
                textBrojLicneKarte.Show();
                textMestoIzdanjaLicne.Show();
                textBrojVozackeDozvole.Show();
                textZona.Show();

                labelJMBG.Show();
                labelBrojLicen.Show();
                labelMestoIzdanjaLicne.Show();
                labelBrojVozackeDozvole.Show();
                labelZona.Show();
            }
            else if (osobaType == "PravnoLice")
            {
                textNaziv.Show();
                textPIB.Show();

                labelNaziv.Show();
                labelPIB.Show();

                textJMBG.Hide();
                textBrojLicneKarte.Hide();
                textMestoIzdanjaLicne.Hide();
                textBrojVozackeDozvole.Hide();
                textZona.Hide();

                labelJMBG.Hide();
                labelBrojLicen.Hide();
                labelMestoIzdanjaLicne.Hide();
                labelBrojVozackeDozvole.Hide();
                labelZona.Hide();
            }
        }

        private void LoadData()
        {
            var osoba = DTOManager.VratiOsobu(idOsobe);

            if (osoba == null)
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

            numericID.Value = osoba.ID;
            textAdresa.Text = osoba.Adresa;
            textLicnoIme.Text = osoba.LicnoIme;
            textImeRoditelja.Text = osoba.ImeRoditelja;
            textPrezime.Text = osoba.Prezime;
            textJMBG.Text = osoba.JMBG;
            textBrojLicneKarte.Text = osoba.BrojLicneKarte;
            textMestoIzdanjaLicne.Text = osoba.MestoIzdavanjaLicne;
            textBrojVozackeDozvole.Text = osoba.BrojVozackeDozvole;
            textZona.Text = osoba.ZiviUZoni;

            textPIB.Text = osoba.PIB;
            textNaziv.Text = osoba.Naziv;

            string osobatype;
            if (osoba.Naziv == null)
            {
                osobatype = "FizickoLice";
            }
            else
            {
                osobatype = "PravnoLice";
            }

            ShowHideInputs(osobatype);
        }

        private void numericID_ValueChanged(object sender, EventArgs e)
        {
            idOsobe = Convert.ToInt32(numericID.Value);
            LoadData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var osoba = DTOManager.VratiOsobu(idOsobe);
            if (osoba == null)
            {
                MessageBox.Show("Osoba sa tim id-jem ne postoji");
                return;
            }

            string osobaType;
            if (osoba.Naziv == null)
            {
                osobaType = "FizickoLice";
            }
            else
            {
                osobaType = "PravnoLice";
            }


            var novaOsoba = new OsobaBasic(Convert.ToInt32(numericID.Value), textAdresa.Text, textLicnoIme.Text,
                textImeRoditelja.Text, textPrezime.Text, textJMBG.Text, textBrojLicneKarte.Text,
                textMestoIzdanjaLicne.Text, textBrojVozackeDozvole.Text, textZona.Text, textPIB.Text, textNaziv.Text,
                osobaType);


            DTOManager.AzurirajOsobu(novaOsoba);
            osobeForm.PopulateListView();
        }
    }
}