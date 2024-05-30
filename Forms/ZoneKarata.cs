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
    public partial class ZoneKarata : Form
    {
        private int idZone;
        public ZoneKarata(int id)
        {
            InitializeComponent();
            this.idZone = id;
        }

        public void PopulateListView()
        {
            listaZona.Items.Clear();

            List<ZonePregled> podaci = DTOManager.VratiZone(idZone);
            foreach (ZonePregled podatak in podaci)
            {
                ListViewItem item = new ListViewItem(podatak.GetListViewItem());
                listaZona.Items.Add(item);
            }

            listaZona.Refresh();
        }

        private void listaZona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ZoneKarata_Load(object sender, EventArgs e)
        {

            PopulateListView();
        }
    }
}
