using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingServis.Entiteti;

namespace ParkingServis.Forms
{
    public partial class DodajOsobuForm : Form
    {
        private OsobeForm osobeForm;
        public DodajOsobuForm(OsobeForm osobeForm)
        {
            InitializeComponent();

            this.osobeForm = osobeForm;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            string osobaType = comboOsobaType.Text;

            if(osobaType != "FizickoLice" && osobaType != "PravnoLice")
            {
                MessageBox.Show("Osoba mora biti ili pravno ili fizicko lice");
                return;
            }

            OsobaBasic novaOsoba = new OsobaBasic(Convert.ToInt32(numericID.Value), textAdresa.Text, textLicnoIme.Text,
                textImeRoditelja.Text, textPrezime.Text, textJMBG.Text, textBrojLicneKarte.Text,
                textMestoIzdanjaLicne.Text, textBrojVozackeDozvole.Text, textZona.Text, textPIB.Text, textNaziv.Text,
                osobaType);

            DTOManager.DodajOsobu(novaOsoba);
            osobeForm.PopulateListView();
        }

        private void comboOsobaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboOsobaType.Text == "FizickoLice")
            {
                textNaziv.Hide();
                textPIB.Hide();

                labelNaziv.Hide();
                labelPIB.Hide();
                
                textJMBG.Show();
                textBrojLicneKarte.Show();
                textMestoIzdanjaLicne.Show();
                textBrojVozackeDozvole.Show();
                textZona.Show();

                labelJMBG.Show();
                labelBrojLicen.Show();
                labelMestoIzdanjaLicne.Show();
                labelBrojVozackeDozvole.Show();
                labelZona.Show();
            }
            else if (comboOsobaType.Text == "PravnoLice")
            {
                textNaziv.Show();
                textPIB.Show();

                labelNaziv.Show();
                labelPIB.Show();

                textJMBG.Hide();
                textBrojLicneKarte.Hide();
                textMestoIzdanjaLicne.Hide();
                textBrojVozackeDozvole.Hide();
                textZona.Hide();

                labelJMBG.Hide();
                labelBrojLicen.Hide();
                labelMestoIzdanjaLicne.Hide();
                labelBrojVozackeDozvole.Hide();
                labelZona.Hide();
            }
        }

        private void DodajOsobuForm_Load(object sender, EventArgs e)
        {
                textNaziv.Hide();
                textPIB.Hide();

                labelNaziv.Hide();
                labelPIB.Hide();

                textJMBG.Hide();
                textBrojLicneKarte.Hide();
                textMestoIzdanjaLicne.Hide();
                textBrojVozackeDozvole.Hide();
                textZona.Hide();

                labelJMBG.Hide();
                labelBrojLicen.Hide();
                labelMestoIzdanjaLicne.Hide();
                labelBrojVozackeDozvole.Hide();
                labelZona.Hide();
        }
    }
}
