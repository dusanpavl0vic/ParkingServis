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
    public partial class DodajBrojTelefona : Form
    {
        private BrojeviTelefonaOsobaForm form;
        private int osobaId;
        public DodajBrojTelefona(int osobaId, BrojeviTelefonaOsobaForm form)
        {
            InitializeComponent();

            this.osobaId = osobaId;
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int phoneNumber = Convert.ToInt32(numericID.Value);

            OsobaTelefon postojiTelefon = DTOManager.VratiTelefon(phoneNumber);
            if (postojiTelefon != null)
            {
                MessageBox.Show("Vec postoji telefon sa tim id-jem");
                return;
            }

            Osoba osoba = DTOManager.VratiOsobu(osobaId);
            if (osoba == null)
            {
                MessageBox.Show("Ne postoji osoba sa tim id-jem");
                return;
            }

            BrojTelefonaBasic brTel = new BrojTelefonaBasic(Convert.ToInt32(numericID.Value), textBrojTelefona.Text, osoba);

            DTOManager.DodajBrojTelefona(brTel);
            form.PopulateListView();
        }
    }
}
