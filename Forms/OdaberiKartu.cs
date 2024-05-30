using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingServis.Forms
{
    public partial class OdaberiKartu : Form
    {
        private DodajIskoriscenuKartu dodajIskoriscenuKartuForm;
        public OdaberiKartu(DodajIskoriscenuKartu dodajIskoriscenuKartu)
        {
            InitializeComponent();

            this.dodajIskoriscenuKartuForm = dodajIskoriscenuKartu;
        }

        private void OdaberiKartu_Load(object sender, EventArgs e)
        {
            PopulateListView();
        }

        private void PopulateListView()
        {
            listaKarata.Items.Clear();

            List<KartaPregled> podaci = DTOManager.VratiSveKarte();
            foreach (KartaPregled podatak in podaci)
            {
                ListViewItem item = new ListViewItem(podatak.GetListViewItem());
                listaKarata.Items.Add(item);
            }

            listaKarata.Refresh();
        }

        private void listaKarata_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listaKarata.SelectedItems.Count < 1)
            {
                MessageBox.Show("Morate odabrati barem jednu kartu");
                return;
            }

            int selectedKarta = Convert.ToInt32(listaKarata.SelectedItems[0].SubItems[0].Text);

            this.dodajIskoriscenuKartuForm.SelectKarta(selectedKarta);
            this.Close();
        }
    }
}
