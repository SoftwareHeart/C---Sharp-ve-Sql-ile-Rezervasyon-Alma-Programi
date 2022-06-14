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
    public partial class Otobus : Form, IUlasim
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Kalkis_Yeri { get; set; }
        public string Varis_Yeri { get; set; }
        public DateTime Kalkis_Tarihi { get; set; }
        public DateTime Dönüs_Tarihi { get; set; }
        public int Koltuk_No { get; set; }
        public Otobus()
        {
            InitializeComponent();
        }
        bool SeciliMi = false;
        string koltukno = "";
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazilimMimarisi;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            if (otel_check.Checked == true)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Insert into Tbl_Seyahat(Ad,Soyad,Gidis_Tarihi,Donus_Tarihi,Kalkis_Yeri,Varis_Yeri,Otobus_Otel,Koltuk) values (@A1,@A2,@A3,@A4,@A5,@A6,'True',@A7)", baglanti);
                cmd.Parameters.AddWithValue("@A1", txt_Ad.Text);
                cmd.Parameters.AddWithValue("@A2", txt_Soyad.Text);
                cmd.Parameters.AddWithValue("@A3", dateTimeKalkis.Value);
                cmd.Parameters.AddWithValue("@A4", dateTimeVaris.Value);
                cmd.Parameters.AddWithValue("@A5", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@A6", comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("@A7", koltukno);


                cmd.ExecuteNonQuery();
                baglanti.Close();
                Otel otel = new Otel();
                otel.Show();
                this.Hide();


            }
            else if (cadir_check.Checked == true)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Insert into Tbl_Seyahat(Ad,Soyad,Gidis_Tarihi,Donus_Tarihi,Kalkis_Yeri,Varis_Yeri,Otobus_Cadir,Koltuk) values (@A1,@A2,@A3,@A4,@A5,@A6,'True',@A7)", baglanti);
                cmd.Parameters.AddWithValue("@A1", txt_Ad.Text);
                cmd.Parameters.AddWithValue("@A2", txt_Soyad.Text);
                cmd.Parameters.AddWithValue("@A3", dateTimeKalkis.Value);
                cmd.Parameters.AddWithValue("@A4", dateTimeVaris.Value);
                cmd.Parameters.AddWithValue("@A5", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@A6", comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("@A7", koltukno);


                cmd.ExecuteNonQuery();
                baglanti.Close();
                Cadir cadir = new Cadir();
                cadir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tüm kısımları doldurduğunuzdan emin olun", "Uyarı", MessageBoxButtons.OK);
            }

        }
        
      
        private void Otobus_Load(object sender, EventArgs e)
        {
         
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Seyahat where Koltuk=@K2", baglanti);
            komut.Parameters.AddWithValue("@K2", A1.Text);
           
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                A1.Enabled = false;
                A1.BackColor = Color.Red;
            }
          
            baglanti.Close();





            this.cityTableAdapter.Fill(this.yazilimMimarisiDataSet1.City);
            
            this.illerTableAdapter.Fill(this.yazilimMimarisiDataSet.iller);

        }

        private void A1_Click(object sender, EventArgs e)
        {
            Button koltukbutton = (Button)sender;
            koltukno = koltukbutton.Text;
            if (SeciliMi == true)
            {
                koltukbutton.BackColor = Color.Lime;
                SeciliMi = false;
            }
            else
            {
                koltukbutton.BackColor = Color.Red;
                SeciliMi = true;
            }
        }

        void IUlasim.otobus()
        {
            throw new NotImplementedException();
        }

        public void ucak()
        {
            throw new NotImplementedException();
        }
    }
}
