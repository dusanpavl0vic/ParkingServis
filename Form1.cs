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
            ParkingForm parkingForm = new ParkingForm();
            parkingForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VozilaForm vozilaForm = new VozilaForm();
            vozilaForm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OsobeForm osobeForm = new OsobeForm();
            osobeForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KarteForm karteForm  = new KarteForm();
            karteForm.ShowDialog();
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string registarskiBroj = textBox1.Text;

        //    try
        //    {
        //        NHibernate.ISession s = DataLayer.GetSession();

        //        //Vozilo vozilo = s.Load<Vozilo>(registarskiBroj);
        //        Karta k = s.Load<Karta>(1);

        //        MessageBox.Show(k.DoVreme.ToString() + " ");
        //        //s.Delete(k);
        //        s.Flush();



        //        s.Close();

        //    }
        //    catch (Exception ec)
        //    {
        //        //handle exceptions
        //    }
        //}

    }
}
