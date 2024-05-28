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
<<<<<<< HEAD
            
            VoziloBasic s = new VoziloBasic();

            s.Id = Int32.Parse(textBox1.Text);
            s.RegistarskiBroj = textBox2.Text;
            s.BrojSaobracajneDozvole = textBox3.Text;
            s.Proizvodjac = textBox4.Text;
            s.Model = textBox5.Text;
=======
        
            var novoVozilo = new VoziloBasic(Convert.ToInt32(numericUpDown1.Value), textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text);
>>>>>>> 3574251bbfa29bca44aa53585842ba483fa83d25

            DTOManager.DodajVozilo(novoVozilo);

<<<<<<< HEAD
            MessageBox.Show("Uspesno ste dodali novo vozilo!");
            
=======
            activeVozilaForm.PopulateListView();
          
>>>>>>> 3574251bbfa29bca44aa53585842ba483fa83d25
        }
    }
}
