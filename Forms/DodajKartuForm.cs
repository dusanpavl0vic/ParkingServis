using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate.Linq.Functions;
using ParkingServis.Entiteti;

namespace ParkingServis.Forms
{
    public partial class DodajKartuForm : Form
    {
        private KarteForm karteForm;
        private int selectedOsobaId;
        private int selectedVoziloId;

        public DodajKartuForm(KarteForm karteForm)
        {
            InitializeComponent();

            this.karteForm = karteForm;
            this.selectedOsobaId = 0;
            this.selectedVoziloId = 0;
        }

        private void DodajKartuForm_Load(object sender, EventArgs e)
        {


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

        private void buttonIdOsobe_Click(object sender, EventArgs e)
        {
            OdaberiOsobu odaberiOsobuForm = new OdaberiOsobu(this);
            odaberiOsobuForm.Show();
        }
        private void buttonIDVozila_Click(object sender, EventArgs e)
        {
            OdaberiVozilo odaberiVoziloForm = new OdaberiVozilo(this);
            odaberiVoziloForm.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string kartaType = "Pretplatna";

            Osoba osoba = DTOManager.VratiOsobu(Convert.ToInt32(numericIDOsobe.Value));
            if (osoba == null)
            {
                MessageBox.Show("Ne postoji osoba sa tim id-jem");
                return;
            }

            Vozilo vozilo = DTOManager.VratiVozilo(Convert.ToInt32(numericIDVozila.Value));
            if (vozilo == null)
            {
                MessageBox.Show("Ne postoji vozilo sa tim id-jem");
                return;
            }

            KartaBasic novaKarta = new KartaBasic(Convert.ToInt32(numericSerijskiBroj.Value), kartaType,
                dateDatum.Value, dateOdVreme.Value, dateDoVreme.Value, osoba, vozilo);

            DTOManager.DodajKartu(novaKarta);
            karteForm.PopulateListView();
        }

    }
}
