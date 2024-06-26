﻿using System;
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
    public partial class OdaberiOsobu : Form
    {
        private DodajKartuForm kartaForm;
        private AzurirajKartuForm azurirajKartuForm;
        private DodajZakupForm dodajZakupForm;

        public OdaberiOsobu(DodajKartuForm kartaForm = null, AzurirajKartuForm azurirajKartuForm = null, DodajZakupForm dodajZakupForm = null)
        {
            InitializeComponent();

            this.kartaForm = kartaForm;
            this.azurirajKartuForm = azurirajKartuForm;
            this.dodajZakupForm = dodajZakupForm;
        }


        private void OdaberiOsobu_Load(object sender, EventArgs e)
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
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listaOsoba.SelectedItems.Count < 1)
            {
                MessageBox.Show("Molimo odaberite barem jednu osobu");
                return;
            }

            int selectedId = Convert.ToInt32(listaOsoba.SelectedItems[0].SubItems[0].Text); 

            kartaForm?.SelectOsobaID(selectedId);
            azurirajKartuForm?.SelectOsobaID(selectedId);
            dodajZakupForm?.SelectOsobaID(selectedId);

            this.Close();
        }
    }
}
