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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazilimMimarisi;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Tbl_Giris(KullaniciAd,KullaniciSifre,Ad,Soyad,Tc) values (@k1,@k2,@k3,@k4,@k5)", baglanti);
            komut1.Parameters.AddWithValue("@k1", txt_Kullanici.Text);
            komut1.Parameters.AddWithValue("@k2", txt_Sifre.Text);
            komut1.Parameters.AddWithValue("@k3", txt_AD.Text);
            komut1.Parameters.AddWithValue("@k4", Txt_Soyad.Text);
            komut1.Parameters.AddWithValue("@k5", txt_Tc.Text);



            komut1.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıdınız başarıyla gerçekleşmiştir.");
           
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
