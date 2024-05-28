using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ParkingServis.Forms
{
    public partial class DodajVozilo : Form
    {
        private VozilaForm activeVozilaForm;
        public DodajVozilo(VozilaForm activeVozilaform)
        {
            this.activeVozilaForm = activeVozilaform;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            var novoVozilo = new VoziloBasic(Convert.ToInt32(numericUpDown1.Value), textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text);

            DTOManager.DodajVozilo(novoVozilo);

            activeVozilaForm.PopulateListView();
          
        }
    }
}
