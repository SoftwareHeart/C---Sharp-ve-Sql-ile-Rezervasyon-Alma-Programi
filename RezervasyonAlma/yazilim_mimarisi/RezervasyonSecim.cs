using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilim_mimarisi
{
    public partial class RezervasyonSecim : Form
    {
        public RezervasyonSecim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ucak ucak = new Ucak();
            ucak.Show();
            this.Hide();      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Otobus otobus = new Otobus();
            otobus.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Rapor ile ilgili kodlar gelecek
        }

        private void RezervasyonSecim_Load(object sender, EventArgs e)
        {

            
        }
    }
}
