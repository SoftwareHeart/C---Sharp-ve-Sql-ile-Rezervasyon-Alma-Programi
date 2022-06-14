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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.Show();
            this.Hide();

        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazilimMimarisi;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Giris where KullaniciAd=@p1 and KullaniciSifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", Txt_KullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                RezervasyonSecim rezervasyonSecim = new RezervasyonSecim();
                rezervasyonSecim.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız..");
            }
            baglanti.Close();
            
        }
    }
}
