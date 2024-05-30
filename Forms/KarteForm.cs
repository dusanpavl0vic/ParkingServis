using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingServis.Forms;

namespace ParkingServis
{
    public partial class KarteForm : Form
    {
        public KarteForm()
        {
            InitializeComponent();
        }

        private void KarteForm_Load(object sender, EventArgs e)
        {
            PopulateListView();
        }

        public void PopulateListView()
        {
            listaKarta.Items.Clear();

            List<KartaPregled> podaci = DTOManager.VratiKarte();
            foreach(KartaPregled podatak in podaci)
            {
                ListViewItem item = new ListViewItem(podatak.GetListViewItem());
                listaKarta.Items.Add(item);
            }

            listaKarta.Refresh();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DodajKartuForm dodajKartu = new DodajKartuForm(this);
            dodajKartu.Show();
        }
    }
}
