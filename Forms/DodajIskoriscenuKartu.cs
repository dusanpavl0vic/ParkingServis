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
    public partial class DodajIskoriscenuKartu : Form
    {
        private int selectedKartaId;
        private int selectedParkingMestoId;
        private int selectedVoziloId;

        private IskorisceneKarte iskoriscenaKartaForm;

        public DodajIskoriscenuKartu(IskorisceneKarte iskorisceneKarte)
        {
            InitializeComponent();


            this.selectedVoziloId = 0;
            this.selectedKartaId = 0;
            this.selectedParkingMestoId = 0;
            this.iskoriscenaKartaForm = iskorisceneKarte;
        }

        public void SelectKarta(int index)
        {
            this.selectedKartaId = index;
            numericKartaId.Value = index;
        }

        public void SelectVoziloID(int index)
        {
            this.selectedVoziloId = index;
            numericVoziloId.Value = index;
        }

        public void SelectParkingMestoID(int index)
        {
            this.selectedParkingMestoId = index;
            numericParkingMestoId.Value = index;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(numericUpDown1.Text);
            if (DTOManager.VratiIskoriscenuKartu(index) != null)
            {
                MessageBox.Show("Vec postoji karta sa tim idjem");
                return;
            }

            Vozilo vozilo = DTOManager.VratiVozilo(Convert.ToInt32(numericVoziloId.Text));
            if (vozilo == null)
            {
                MessageBox.Show("Ne postoji vozilo sa tim idjem");
                return;
            }

            Karta karta = DTOManager.VratiKartu(Convert.ToInt32(numericKartaId.Text));
            if (karta == null)
            {
                MessageBox.Show("Ne postoji karta sa tim idjem");
                return;
            }

            ParkingMesto parking = DTOManager.VratiParkingMesto(Convert.ToInt32(numericParkingMestoId.Text));
            if (parking == null)
            {
                MessageBox.Show("Ne postoji parking mesto sa tim idjem");
                return;
            }


            IskoriscenaKartaBasic isk = new IskoriscenaKartaBasic(index, dateVremeIzvrsenja.Value, dateOdVreme.Value,
                dateDateDo.Value, vozilo, parking, karta);
            DTOManager.DodajIskoriscenuKartu(isk);
            iskoriscenaKartaForm.PopulateListView();
        }

        private void buttonIDOsobe_Click(object sender, EventArgs e)
        {
            OdaberiVozilo odaberiVozilo = new OdaberiVozilo(dodajKartuForm: this);
            odaberiVozilo.Show();
        }

        private void buttonIDKarte_Click(object sender, EventArgs e)
        {
            OdaberiKartu odaberiKartu = new OdaberiKartu(this);
            odaberiKartu.Show();
        }

        private void buttonIDPArkingMesta_Click(object sender, EventArgs e)
        {
            OdaberiParkingMesto odaberiParking = new OdaberiParkingMesto(dodajIskoriscenuKartuForm: this);
            odaberiParking.Show();
        }
    }
}
