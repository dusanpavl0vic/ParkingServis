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

        private void PopulateListView()
        {
            MessageBox.Show("Mrnjao");
            listaVozila.Items.Clear();

            List<VoziloPregled> podaci = DTOManager.VratiSvaVozila();
            return;
            foreach (VoziloPregled podatak in podaci)
            {
                ListViewItem item = new ListViewItem(podatak.GetListViewItem());
                listaVozila.Items.Add(item);
            }

            listaVozila.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
