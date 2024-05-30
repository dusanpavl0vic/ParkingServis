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
    public partial class DodajZakupForm : Form
    {
        private int selectedOsobaId;
        private int selectedVoziloId;
        private int selectedParkingMestoId;

        private ZakupForm zakupForm;

        public DodajZakupForm(ZakupForm zakupForm)
        {
            InitializeComponent();

            this.zakupForm = zakupForm;
        }

        public void SelectOsobaID(int index)
        {
            this.selectedOsobaId = index;
            numericIdOsobe.Value = index;
        }

        public void SelectVoziloID(int index)
        {
            this.selectedVoziloId = index;
            numericIdVozila.Value = index;
        }

        public void SelectParkingMestoID(int index)
        {
            this.selectedParkingMestoId = index;
            numericIdParkingMesta.Value = index;
        }


        private void DodajZakupForm_Load(object sender, EventArgs e)
        {

        }
       
        private void buttonOdaberiOsobu_Click(object sender, EventArgs e)
        {
            OdaberiOsobu odaberiOsobu = new OdaberiOsobu(dodajZakupForm: this);
            odaberiOsobu.Show();
        }

        private void buttonOdaberiVozilo_Click(object sender, EventArgs e)
        {
            OdaberiVozilo odaberiVozilo = new OdaberiVozilo(dodajZakupForm: this);
            odaberiVozilo.Show();
        }

        private void buttonOdaberiParkingMesto_Click(object sender, EventArgs e)
        {
            OdaberiParkingMesto odaberiParkingMesto = new OdaberiParkingMesto(dodajZakupForm: this);
            odaberiParkingMesto.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int idZakupa = Convert.ToInt32(numericId.Value);

            Zakup zakup = DTOManager.VratiZakup(idZakupa);
            if (zakup != null)
            {
                MessageBox.Show("Zakup sa tim id-jem vec postoji");
                return;
            }

            Osoba osoba = DTOManager.VratiOsobu(Convert.ToInt32(numericIdOsobe.Text));
            if (osoba == null)
            {
                MessageBox.Show("Ne postoji osoba sa tim id-jem");
                return;
            }

            Vozilo vozilo = DTOManager.VratiVozilo(Convert.ToInt32(numericIdVozila.Text));
            if (vozilo == null)
            {
                MessageBox.Show("Ne postoji vozilo sa tim id-jem");
                return;
            }

            ParkingMesto parkingMesto = DTOManager.VratiParkingMesto(Convert.ToInt32(numericIdParkingMesta.Text));
            if(parkingMesto == null)
            {
                MessageBox.Show("Ne postoji parking mesto sa tim id-jem");
                return;
            }

            ZakupBasic noviZakup = new ZakupBasic(idZakupa, dateOdVreme.Value, dateDoVreme.Value,
                dateDatumPotpisa.Value, osoba, vozilo, parkingMesto);

            DTOManager.DodajZakup(noviZakup);
            zakupForm.PopulateListView();
        }

    }
}
