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
    public partial class OdaberiVozilo : Form
    {
        private DodajKartuForm kartaForm;
        private AzurirajKartuForm azurirajKartuForm;
        private DodajZakupForm dodajZakupForm;

        public OdaberiVozilo(DodajKartuForm kartaForm = null, AzurirajKartuForm azurirajKartuForm = null, DodajZakupForm dodajZakupForm = null)
        {
            InitializeComponent();

            this.kartaForm = kartaForm;
            this.azurirajKartuForm = azurirajKartuForm;
            this.dodajZakupForm = dodajZakupForm;
        }

        
        private void OdaberiVozilo_Load(object sender, EventArgs e)
        {
            PopulateListView();
        }

        private void PopulateListView()
        {
            listaVozila.Items.Clear();

            List<VoziloPregled> podaci = DTOManager.VratiSvaVozila();
            foreach (VoziloPregled podatak in podaci)
            {
                ListViewItem item = new ListViewItem(podatak.GetListViewItem());
                listaVozila.Items.Add(item);
            }

            listaVozila.Refresh();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listaVozila.SelectedItems.Count < 1)
            {
                MessageBox.Show("Molimo odaberite barem jedno vozilo");
                return;
            }

            int selectedID = Convert.ToInt32(listaVozila.SelectedItems[0].SubItems[0].Text);

            kartaForm?.SelectVoziloID(selectedID);
            azurirajKartuForm?.SelectVoziloID(selectedID);
            dodajZakupForm?.SelectVoziloID(selectedID);

            this.Close();
        }
    }
}
