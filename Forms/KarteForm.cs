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

        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            if (listaKarta.SelectedItems.Count < 1)
            {
                MessageBox.Show("Morate odabrati barem jednu kartu");
                return;
            }

            DTOManager.ObrisiKartu(Convert.ToInt32(listaKarta.SelectedItems[0].SubItems[0].Text));
            PopulateListView();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            if (listaKarta.SelectedItems.Count < 1)
            {
                MessageBox.Show("Morate odabrati barem jednu kartu");
                return;
            }


            AzurirajKartuForm azurirajKartu =
                new AzurirajKartuForm(this, Convert.ToInt32(listaKarta.SelectedItems[0].SubItems[0].Text));

            azurirajKartu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IskorisceneKarte iskorisceneForm = new IskorisceneKarte();
            iskorisceneForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listaKarta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati barem jednu kartu");
                return;
            }

            var selected = Convert.ToInt32(listaKarta.SelectedItems[0].SubItems[0].Text);

            ZoneKarata btForm = new ZoneKarata(selected);
            btForm.Show();
        }
    }
}
