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
    }
}
