using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingServis.Entiteti;

namespace ParkingServis.Forms
{
    public partial class AzurirajKartuForm : Form
    {
        private KarteForm karteForm;
        private int serijskiBrojKarte;
        private int selectedOsobaId;
        private int selectedVoziloId;

        public AzurirajKartuForm(KarteForm karteForm, int index)
        {
            InitializeComponent();

            this.karteForm = karteForm;
            this.serijskiBrojKarte = index;
            this.selectedOsobaId = 0;
            this.selectedVoziloId = 0;
        }

        private void AzurirajKartuForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            Karta karta = DTOManager.VratiKartu(serijskiBrojKarte);

            if (karta == null)
            {
                MessageBox.Show("Ne postoji karta sa tim id-jem");


                dateDatum.Value = DateTime.Now;
                dateOdVreme.Value = DateTime.Now;
                dateDoVreme.Value = DateTime.Now;
                numericIDOsobe.Value = 0;
                numericIDVozila.Value = 0;

                return;
            }

            numericSerijskiBroj.Value = karta.SerijskiBroj;
            dateDatum.Value = karta.Datum ?? DateTime.Now;
            dateOdVreme.Value = karta.OdVreme ?? DateTime.Now;
            dateDoVreme.Value = karta.DoVreme ?? DateTime.Now;
            numericIDOsobe.Value = karta.ProdajaOsobi?.ID ?? 0;
            numericIDVozila.Value = karta.OdnosiNaVozilo?.Id ?? 0;

            this.selectedOsobaId = karta.ProdajaOsobi?.ID ?? 0;
            this.selectedVoziloId = karta.OdnosiNaVozilo?.Id ?? 0;
        }

        public void SelectOsobaID(int index)
        {
            this.selectedOsobaId = index;
            numericIDOsobe.Value = this.selectedOsobaId;
        }

        public void SelectVoziloID(int index)
        {
            this.selectedVoziloId = index;
            numericIDVozila.Value = this.selectedVoziloId;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Karta karta = DTOManager.VratiKartu(serijskiBrojKarte);
            if (karta == null)
            {
                MessageBox.Show("Karta sa tim serijskim brojem ne postoji");
                return;
            }

            Osoba osoba = DTOManager.VratiOsobu(Convert.ToInt32(numericIDOsobe.Value));
            if (osoba == null)
            {
                MessageBox.Show("Osoba sa tim id-jem ne postoji");
                return;
            }

            Vozilo vozilo = DTOManager.VratiVozilo(Convert.ToInt32(numericIDVozila.Value));
            if (vozilo == null)
            {
                MessageBox.Show("Vozilo sa tim id-jem ne postoji");
                return;
            }

            KartaBasic novaKarta = new KartaBasic(Convert.ToInt32(numericSerijskiBroj.Text), "Pretplatna",
                dateDatum.Value, dateOdVreme.Value, dateDoVreme.Value, osoba, vozilo);

            DTOManager.AzurirajKartu(novaKarta);
            karteForm.PopulateListView();
        }

        private void numericSerijskiBroj_ValueChanged(object sender, EventArgs e)
        {
            this.serijskiBrojKarte = Convert.ToInt32(numericSerijskiBroj.Value);
            LoadData();
        }

        private void buttonIdOsobe_Click(object sender, EventArgs e)
        {
            OdaberiOsobu odaberiOsobuForm = new OdaberiOsobu(azurirajKartuForm: this);
            odaberiOsobuForm.Show();
        }

        private void buttonIDVozila_Click(object sender, EventArgs e)
        {
            OdaberiVozilo odaberiVoziloForm = new OdaberiVozilo(azurirajKartuForm: this);
            odaberiVoziloForm.Show();
        }
    }
}
