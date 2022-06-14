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
    public partial class Cadir : Form, IKonaklama
    {
        public int Kisi_Sayisi { get; set; }
        public DateTime Kira_Baslangic_Tarihi { get; set; }
        public DateTime Kira_Bitis_Tarihi { get; set; }
        public string Cadir_Yeri { get; set; }
        public int TC_No { get; set; }
        public Cadir()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazilimMimarisi;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Tbl_Cadir(CadirKisiSayisi,Cadir_Baslangic,Cadir_Bitis,Cadir_Yeri,TC) values (@C1,@C2,@C3,@C4,@C5)", baglanti);
            cmd.Parameters.AddWithValue("@C1", Convert.ToInt32(comboBox1.Text));
            cmd.Parameters.AddWithValue("@C2", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@C3", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@C4", comboBox2.Text);
            cmd.Parameters.AddWithValue("@C5", Convert.ToInt32(textBox1.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Rezervasyonunuz Oluşmuştur", "BİLGİ", MessageBoxButtons.OK);
            RezervasyonSecim rezervasyonSecim = new RezervasyonSecim();
            rezervasyonSecim.Show();
            this.Hide();
        }

        public void otel()
        {
            throw new NotImplementedException();
        }

        void IKonaklama.cadir()
        {
            throw new NotImplementedException();
        }
    }
}
