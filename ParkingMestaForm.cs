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
    public partial class ParkingMestaForm : Form
    {
        public ParkingMestaForm()
        {
            InitializeComponent();
            // load and show data
            PopulateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopulateListView()
        {


        }
    }
}
