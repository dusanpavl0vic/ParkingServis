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
    public partial class BrojeviTelefonaOsobaForm : Form
    {
        private int idOsobe;
        public BrojeviTelefonaOsobaForm(int id)
        {
            InitializeComponent();

            this.idOsobe = id;
        }

        private void BrojeviTelefonaOsobaForm_Load(object sender, EventArgs e)
        {
            PopulateListView();
        }
        
        public void PopulateListView()
        {
            listaBrojeva.Items.Clear();

            List<BrojTelefonaPregled> podaci = DTOManager.VratiBrojeve(idOsobe);
            foreach(BrojTelefonaPregled podatak in podaci)
            {
                ListViewItem item = new ListViewItem(podatak.GetListViewItem());
                listaBrojeva.Items.Add(item);
            }

            listaBrojeva.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajBrojTelefona dodajBrojForma = new DodajBrojTelefona(idOsobe, this);
            dodajBrojForma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaBrojeva.SelectedItems.Count < 1)
            {
                MessageBox.Show("Morate odabrati barem jedan broj telefona");
                return;
            }

            DTOManager.ObrisiBrojTelefona(Convert.ToInt32(listaBrojeva.SelectedItems[0].SubItems[0].Text));
            PopulateListView();
        }
    }
}
