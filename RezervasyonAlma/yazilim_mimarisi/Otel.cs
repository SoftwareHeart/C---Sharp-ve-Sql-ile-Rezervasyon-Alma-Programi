using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace yazilim_mimarisi
{
    public partial class Otel : Form, IKonaklama
    {
        public DateTime Gidis_Tarihi { get; set; }
        public DateTime Dönüs_Tarihi { get; set; }
        public int Oda_No { get; set; }
        public int TC_No { get; set; }
        public Otel()
        {
            InitializeComponent();
        }
        bool SeciliMi = false;
        string koltukno = "";
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazilimMimarisi;Integrated Security=True");
        private void button21_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update Tbl_Otel set Doluluk='True',TC=@a2,Giris_Tarihi=@a3,Cikis_Tarihi=@a4 where Oda=@a1", baglanti);
            cmd.Parameters.AddWithValue("@a1", koltukno);
            cmd.Parameters.AddWithValue("@a2", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@a3", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@a4", dateTimePicker2.Value);

            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Rezervasyon Oluştu","Bilgi",MessageBoxButtons.OK);
            RezervasyonSecim secim = new RezervasyonSecim();
            secim.Show();
            this.Hide();
        }

        private void A1_Click(object sender, EventArgs e)
        {
            Button koltukbutton = (Button)sender;
            koltukno = koltukbutton.Text;
            if (SeciliMi == true)
            {
                koltukbutton.BackColor = Color.Purple;
                SeciliMi = false;
            }
            else
            {
                koltukbutton.BackColor = Color.Green;
                SeciliMi = true;
            }
        }

        private void Otel_Load(object sender, EventArgs e)
        {

        }

        void IKonaklama.otel()
        {
            throw new NotImplementedException();
        }

        public void cadir()
        {
            throw new NotImplementedException();
        }
    }
    }
