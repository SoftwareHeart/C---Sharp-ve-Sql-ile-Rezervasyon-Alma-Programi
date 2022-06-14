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
    public partial class Ucak : Form, IUlasim
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Kalkis_Yeri { get; set; }
        public string Varis_Yeri { get; set; }
        public DateTime Kalkis_Tarihi { get; set; }
        public DateTime Dönüs_Tarihi { get; set; }
        public int Koltuk_No { get; set; }

        public Ucak()
        {
            InitializeComponent();
        }
        bool SeciliMi = false;
        string koltukno = "";
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazilimMimarisi;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            
           

            if (checkOtel.Checked==true)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Insert into Tbl_Seyahat(Ad,Soyad,Gidis_Tarihi,Donus_Tarihi,Kalkis_Yeri,Varis_Yeri,Ucak_Otel,Koltuk) values (@A1,@A2,@A3,@A4,@A5,@A6,'True',@A7)", baglanti);
                cmd.Parameters.AddWithValue("@A1", txt_Ad.Text);
                cmd.Parameters.AddWithValue("@A2", Txt_Soyad.Text);
                cmd.Parameters.AddWithValue("@A3", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@A4", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@A5", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@A6", comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("@A7", koltukno);


                cmd.ExecuteNonQuery();
                baglanti.Close();
                Otel otel = new Otel();
                otel.Show();
                this.Hide();
            
                
            }
            else if(checkCadir.Checked==true)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Insert into Tbl_Seyahat(Ad,Soyad,Gidis_Tarihi,Donus_Tarihi,Kalkis_Yeri,Varis_Yeri,Ucak_Cadir,Koltuk) values (@A1,@A2,@A3,@A4,@A5,@A6,'True',@A7)", baglanti);
                cmd.Parameters.AddWithValue("@A1", txt_Ad.Text);
                cmd.Parameters.AddWithValue("@A2", Txt_Soyad.Text);
                cmd.Parameters.AddWithValue("@A3", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@A4", dateTimePicker1.Value);
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

        private void Ucak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yazilimMimarisiDataSet1.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.yazilimMimarisiDataSet1.City);
            // TODO: This line of code loads data into the 'yazilimMimarisiDataSet.iller' table. You can move, or remove it, as needed.
            this.illerTableAdapter.Fill(this.yazilimMimarisiDataSet.iller);
         

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.illerTableAdapter.FillBy(this.yazilimMimarisiDataSet.iller);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void A1_Click(object sender, EventArgs e)
        {
            Button koltukbutton = (Button)sender;
            koltukno=koltukbutton.Text;
            if (SeciliMi==true)
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

        public void otobus()
        {
            throw new NotImplementedException();
        }

        void IUlasim.ucak()
        {
            throw new NotImplementedException();
        }
    }
}
