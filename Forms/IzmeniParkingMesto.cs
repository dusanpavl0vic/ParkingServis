using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using ParkingServis.Entiteti;
using Prodavnica;

namespace ParkingServis.Forms
{
    public partial class IzmeniParkingMesto : Form
    {
        private ParkingMesta parkingMestaForm;
        private int idParkingMesta;
        public IzmeniParkingMesto(ParkingMesta parkingMesta, int idParkingMesta)
        {
            InitializeComponent();

            this.parkingMestaForm = parkingMesta;
            this.idParkingMesta = idParkingMesta;
        }


        private void IzmeniParkingMesto_Load(object sender, EventArgs e)
        {
            PopuniFormu();
        }

        private void PopuniFormu()
        {
            ParkingMesto pm = DTOManager.VratiParkingMesto(idParkingMesta);

            if (pm == null)
            {
                MessageBox.Show("Ne postoji parking mesto sa tim id-jem");

                comboTrenutniStatus.Text = "";
                comboTipParkingMesta.Text = "";
                textNazivUlice.Text = "";
                textZona.Text = "";
                numericRedniBroj.Value = 0;
                numericSprat.Value = 0;

                return;
            }

            numericID.Value = pm.ID;
            comboTrenutniStatus.Text = pm.TrenutniStatus;
            comboTipParkingMesta.Text = pm.ParkingMestoType;
            textNazivUlice.Text = pm.NazivUlice;
            textZona.Text = pm.Zona;
            numericRedniBroj.Value = Convert.ToDecimal(pm.RedniBroj);
            numericSprat.Value = Convert.ToDecimal(pm.Sprat);
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            ISession session = DataLayer.GetSession();

            int indexParkinga = Convert.ToInt32(numericID.Value);
            Parking parking = session.Load<Parking>(indexParkinga);

            var pm = new ParkingMestoBasic(Convert.ToInt32(numericID.Value), comboTrenutniStatus.Text,
                comboTipParkingMesta.Text, textNazivUlice.Text, textZona.Text, Convert.ToInt32(numericRedniBroj.Value),
                Convert.ToInt32(numericSprat.Value), parking);

            DTOManager.AzurirajParkingMesto(pm);
            parkingMestaForm.PopulateListView();
        }

    }
}
