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
    public partial class IzmeniVozilo : Form
    {
        private readonly VozilaForm activeVoziloForm;
        private int selectedVozilo;

        public IzmeniVozilo(VozilaForm activeVoziloForm, int id)
        {
            this.activeVoziloForm = activeVoziloForm;
            selectedVozilo = id;
            InitializeComponent();
        }

        private void IzmeniVozilo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var vozilo = DTOManager.VratiVozilo(selectedVozilo);

            if (vozilo == null)
            {
                MessageBox.Show("Ne postoji vozilo sa tim id-jem");

                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                return;
            }

            numericUpDown1.Value = vozilo.Id;
            textBox2.Text = vozilo.RegistarskiBroj;
            textBox3.Text = vozilo.BrojSaobracajneDozvole;
            textBox4.Text = vozilo.Proizvodjac;
            textBox5.Text = vozilo.Model;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vozilo = DTOManager.VratiVozilo(selectedVozilo);
            if (vozilo == null)
            {
                MessageBox.Show("Vozilo sa tim id-jem ne postoji");
                return;
            }

            var novoVozilo = new VoziloBasic(Convert.ToInt32(numericUpDown1.Value), textBox2.Text, textBox3.Text,
                                                textBox5.Text, textBox4.Text);

            DTOManager.AzurirajVozilo(novoVozilo);
            activeVoziloForm.PopulateListView();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            selectedVozilo = Convert.ToInt32(numericUpDown1.Value);
            LoadData();
        }
    }
}
