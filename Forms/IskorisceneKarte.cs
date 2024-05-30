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

namespace ParkingServis.Forms
{
    public partial class IskorisceneKarte : Form
    {
        public IskorisceneKarte()
        {
            InitializeComponent();
        }

        private void IskorisceneKarteForm_Load(object sender, EventArgs e)
        {
            PopulateListView();
        }

        private void listaIskoriscenih_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void PopulateListView()
        {
            listaIskoriscenih.Items.Clear();

            List<IskoriscenaKartaPregled> podaci = DTOManager.VratiIskorisceneKarte();
            foreach (IskoriscenaKartaPregled podatak in podaci)
            {
                ListViewItem item = new ListViewItem(podatak.GetListViewItem());
                listaIskoriscenih.Items.Add(item);
            }

            listaIskoriscenih.Refresh();
        }
    }
}
