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
    public partial class ZakupForm : Form
    {
        public ZakupForm()
        {
            InitializeComponent();
        }

        private void listaVozila_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ZakupForm_Load(object sender, EventArgs e)
        {
            PopulateListView();
        }

        public void PopulateListView()
        {
            listaZakupa.Items.Clear();

            List<ZakupPregled> podaci = DTOManager.VratiZakupe();
            foreach (ZakupPregled podatak in podaci)
            {
                ListViewItem item = new ListViewItem(podatak.GetListViewItem());
                listaZakupa.Items.Add(item);
            }

            listaZakupa.Refresh();
        }

        private void buttonZakupi_Click(object sender, EventArgs e)
        {
            DodajZakupForm dodajZakupForm = new DodajZakupForm(this);
            dodajZakupForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaZakupa.SelectedItems.Count < 1)
            {
                MessageBox.Show("Morate odabrati barem jedan zakup");
                return;
            }

            DTOManager.ObrisiZakup(Convert.ToInt32(listaZakupa.SelectedItems[0].SubItems[0].Text));
            PopulateListView();
        }
    }
}
