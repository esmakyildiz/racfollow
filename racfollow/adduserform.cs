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

namespace racfollow
{
    public partial class adduserform : Form
    {
        public adduserform()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=racfollow_maindb;Integrated Security=True");

        private void adduserform_Load(object sender, EventArgs e)
        {

        }

        private void kullanıcıekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kullanıcılar_bilgi(tc,isim,soyisim,numara,adres) values (@tc,@isim,@soyisim,@numara,@adres)", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@isim", txtİsim.Text);
            komut.Parameters.AddWithValue("@soyisim", txtSoyisim.Text);
            komut.Parameters.AddWithValue("@numara", txtNumara.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Eklendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
