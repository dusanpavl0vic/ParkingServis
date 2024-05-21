using ParkingServis.Entiteti;
using Prodavnica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ParkingServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string registarskiBroj = textBox1.Text;

            try
            {
                NHibernate.ISession s = DataLayer.GetSession();

                //Vozilo vozilo = s.Load<Vozilo>(registarskiBroj);
                Karta k = s.Load<Karta>(1);

                MessageBox.Show(k.DoVreme.ToString() + " ");
                //s.Delete(k);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
    }
}
