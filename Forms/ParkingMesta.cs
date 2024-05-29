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
    public partial class ParkingMesta : Form
    {
        private int idParkinga;
        public ParkingMesta(int idParkinga)
        {
            InitializeComponent();

            this.idParkinga = idParkinga;
        }

        public void ParkingMesta_Load(object sender, EventArgs e)
        {
            PopulateListView();
        }

       public void PopulateListView()
        {
            listaParkingMesta.Items.Clear();

            List<ParkingMestoPregled> podaci = DTOManager.VratiParkingMesta(idParkinga);
            foreach(ParkingMestoPregled podatak in podaci)
            {
                ListViewItem item = new ListViewItem(podatak.GetListViewItem());
                listaParkingMesta.Items.Add(item);
            }

            listaParkingMesta.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajParkingMesto dodajPM = new DodajParkingMesto(this, idParkinga);
            dodajPM.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaParkingMesta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati barem jedan parking");
                return;
            }

            IzmeniParkingMesto izmeniPM = new IzmeniParkingMesto(this, Convert.ToInt32(listaParkingMesta.SelectedItems[0].SubItems[0].Text));
            izmeniPM.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listaParkingMesta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati barem jedan parking");
                return;
            }

            var selected = listaParkingMesta.SelectedItems;

            for (int i = 0; i < selected.Count; i++)
            {
                MessageBox.Show("Brisanje " + int.Parse(selected[i].SubItems[0].Text));
                DTOManager.ObrisiParkingMesto(int.Parse(selected[i].SubItems[0].Text));
            }

            PopulateListView();
        }
    }
}
