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
    public partial class OsobeForm : Form
    {
        public OsobeForm()
        {
            InitializeComponent();
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DodajOsobuForm dodajOsobu = new DodajOsobuForm(this);
            dodajOsobu.Show();
        }

        private void OsobeForm_Load(object sender, EventArgs e)
        {
            PopulateListView();
        }

       public void PopulateListView()
        {
            listaOsoba.Items.Clear();

            List<OsobaPregled> podaci = DTOManager.VratiOsobe();
            foreach(OsobaPregled podatak in podaci)
            {
                ListViewItem item = new ListViewItem(podatak.GetListViewItem());
                listaOsoba.Items.Add(item);
            }

            listaOsoba.Refresh();
        }

        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            if (listaOsoba.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati barem jednu osobu");
                return;
            }

            var selected = listaOsoba.SelectedItems;

            for (int i = 0; i < selected.Count; i++)
            {
                MessageBox.Show("Brisanje " + int.Parse(selected[i].SubItems[0].Text));
                DTOManager.ObrisiOsobu(int.Parse(selected[i].SubItems[0].Text));
            }

            PopulateListView();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            if (listaOsoba.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati barem jednu osobu");
                return;
            }

            var selected = listaOsoba.SelectedItems;

            IzmeniOsobu izmeniOsobu =
                new IzmeniOsobu(this, Convert.ToInt32(listaOsoba.SelectedItems[0].SubItems[0].Text));
            izmeniOsobu.Show();
        }
    }
}
