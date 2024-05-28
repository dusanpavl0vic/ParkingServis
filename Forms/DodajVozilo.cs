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
        public DodajVozilo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            VoziloBasic s = new VoziloBasic();

            s.Id = Int32.Parse(textBox1.Text);
            s.RegistarskiBroj = textBox2.Text;
            s.BrojSaobracajneDozvole = textBox3.Text;
            s.Proizvodjac = textBox4.Text;
            s.Model = textBox5.Text;

            DTOManager.dodajVozilo(s);

            MessageBox.Show("Uspesno ste dodali novo vozilo!");
            
        }
    }
}
