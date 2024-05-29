using ParkingServis.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingServis
{
    public partial class VozilaForm : Form
    {
        public VozilaForm()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void VozilaForm_Load(object sender, EventArgs e)
        {
            PopulateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void PopulateListView()
        {
            //MessageBox.Show("Mrnjao");
            listaVozila.Items.Clear();

            List<VoziloPregled> podaci = DTOManager.VratiSvaVozila();
            foreach (VoziloPregled podatak in podaci)
            {
                ListViewItem item = new ListViewItem(podatak.GetListViewItem());
                listaVozila.Items.Add(item);
            }

            listaVozila.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati barem jedan parking");
                return;
            }

            IzmeniVozilo izmeniV = new IzmeniVozilo(this, Convert.ToInt32(listaVozila.SelectedItems[0].SubItems[0].Text));
            izmeniV.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listaVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati barem jedno vozilo");
                return;
            }

            var selected = listaVozila.SelectedItems;

            for (int i = 0; i < selected.Count; i++)
            {
                DTOManager.obrisiVozilo(int.Parse(selected[i].SubItems[0].Text));
            }
            PopulateListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajVozilo dodajVoziloForm = new DodajVozilo(this);
            dodajVoziloForm.ShowDialog();
        }
    }
}
