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
        public ParkingMestaForm()
        {
            InitializeComponent();
            // load and show data
        }
        private void ParkingMestaForm_Load(object sender, EventArgs e)
        {
            PopulateListView();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopulateListView()
        {
            MessageBox.Show("Mjau");
            listaParkinga.Items.Clear();

            List<ParkingPregled> podaci = DTOManager.VratiSveParkinge();
            foreach(ParkingPregled podatak in podaci)
            {
                ListViewItem item = new ListViewItem(podatak.GetListViewItem());
                listaParkinga.Items.Add(item);
            }

            listaParkinga.Refresh();
        }

            }
}
