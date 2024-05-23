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
    public partial class ParkingMestaForm : Form
    {
        private int selectedIndex;
        public ParkingMestaForm()
        {
            InitializeComponent();
            selectedIndex = -1;
            // load and show data
        }
        private void ParkingMestaForm_Load(object sender, EventArgs e)
        {
            PopulateListView();
        }

        private void PopulateListView()
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
                DTOManager.ObrisiParking(int.Parse(selected[i].SubItems[0].Text));
            }
        }

    }
}
