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
    public partial class OdaberiParkingMesto : Form
    {

        private DodajZakupForm dodajZakupForm;

        public OdaberiParkingMesto(DodajZakupForm dodajZakupForm = null)
        {
            InitializeComponent();

            this.dodajZakupForm = dodajZakupForm;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listaParkingMesta.SelectedItems.Count < 1)
            {
                MessageBox.Show("Morate odabrati barem jedno parking mesto");
                return;
            }

            this.dodajZakupForm?.SelectParkingMestoID(
                Convert.ToInt32(listaParkingMesta.SelectedItems[0].SubItems[0].Text));

            this.Close();
        }

        private void OdaberiParkingMesto_Load(object sender, EventArgs e)
        {
            PopulateListView();
        }
        
        
        private void PopulateListView()
        {
            listaParkingMesta.Items.Clear();

            List<ParkingMestoPregled> podaci = DTOManager.VratiSvaParkingMesta();

            foreach (ParkingMestoPregled podatak in podaci)
            {
                ListViewItem item = new ListViewItem(podatak.GetListViewItem());
                listaParkingMesta.Items.Add(item);
            }

            listaParkingMesta.Refresh();
        }

    }
}
