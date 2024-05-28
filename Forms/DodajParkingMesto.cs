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
    public partial class DodajParkingMesto : Form
    {
        private ParkingMesta parkingMestaForm;
        private int idParkinga;
        public DodajParkingMesto(ParkingMesta parkingMesta, int idParkinga)
        {
            InitializeComponent();

            this.parkingMestaForm = parkingMesta;
            this.idParkinga = idParkinga;
        }

        private void DodajParkingMesto_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Parking parking = DTOManager.VratiParking(idParkinga);

            var pm = new ParkingMestoBasic(Convert.ToInt32(numericID.Value), comboTrenutniStatus.Text,
                comboTipParkingMesta.Text, textNazivUlice.Text, textZona.Text, Convert.ToInt32(numericRedniBroj.Value),
                Convert.ToInt32(numericSprat.Value), parking);

            DTOManager.DodajParkingMesto(pm);

            parkingMestaForm.PopulateListView();
        }

        private void comboTipParkingMesta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void numericRedniBroj_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericSprat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textZona_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textNazivUlice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericID_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboTrenutniStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
