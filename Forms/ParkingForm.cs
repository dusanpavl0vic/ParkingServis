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
    public partial class ParkingForm : Form
    {
        public ParkingForm()
        {
            InitializeComponent();
        }
        private void ParkingForm_Load(object sender, EventArgs e)
        {
            PopulateListView();
        }

        public void PopulateListView()
        {
            listaParkinga.Items.Clear();

            List<ParkingPregled> podaci = DTOManager.VratiSveParkinge();
            foreach(ParkingPregled podatak in podaci)
            {
                ListViewItem item = new ListViewItem(podatak.GetListViewItem());
                listaParkinga.Items.Add(item);
            }

            listaParkinga.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajParking dodajParkingForm = new DodajParking(this);
            dodajParkingForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaParkinga.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati barem jedan parking");
                return;
            }

            var selected = listaParkinga.SelectedItems;

            for (int i = 0; i < selected.Count; i++)
            {
                MessageBox.Show("Brisanje " + int.Parse(selected[i].SubItems[0].Text));
                DTOManager.ObrisiParking(int.Parse(selected[i].SubItems[0].Text));
            }
            PopulateListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listaParkinga.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati barem jedan parking");
                return;
            }

            IzmeniParking izmeniParkingForm = new IzmeniParking(this ,Convert.ToInt32(listaParkinga.SelectedItems[0].SubItems[0].Text));
            izmeniParkingForm.Show();
        }

        private void buttonParkingMesta_Click(object sender, EventArgs e)
        {
            if (listaParkinga.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati barem jedan parking");
                return;
            }

            ParkingMesta parkingMestoForm =
                new ParkingMesta(Convert.ToInt32(listaParkinga.SelectedItems[0].SubItems[0].Text));
            parkingMestoForm.Show();
        }
    }
}
